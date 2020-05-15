using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Threading;

namespace 口琴练琴助手
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Player.Callback = Position_Updated;
            KeyPreview = true;

        }
        public class MyPlayer
        {
            public delegate void PositionCallback(TimeSpan current, TimeSpan total);
            public PositionCallback Callback { get; set; }
            private Timer timer;
            private Mp3FileReader reader;
            public string Path { get; private set; }
            public float Volume { get { return this.waveOut.Volume; } set { this.waveOut.Volume = value; } }
            private WaveOut waveOut;
            public MyPlayer()
            {
                this.timer = new Timer();
            }
            public void Load(string path)
            {
                this.Clear();

                this.Path = path;
                this.reader = new Mp3FileReader(path);
                this.waveOut = new WaveOut(); // or WaveOutEvent()
                this.waveOut.Init(reader);

                this.timer.Enabled = false;
                this.timer.Interval = 200;
                this.timer.Tick += Timer_Tick;
            }

            public void Clear()
            {
                this.waveOut?.Stop();
                this.reader?.Dispose();
                this.waveOut?.Dispose();
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                Callback.Invoke(this.reader.CurrentTime, this.reader.TotalTime);
            }

            public void Play()
            {
                this.waveOut.Play();
                this.timer.Enabled = true;
            }
            public void Pause()
            {
                this.waveOut.Pause();
                this.timer.Enabled = false;
            }
            public void SetPos(TimeSpan pos)
            {
                if (null == this.reader)
                {
                    MessageBox.Show("请先加载文件");
                    return;
                }
                this.reader.CurrentTime = pos;
                //this.timer.Enabled = false;                
                //this.waveOut.Stop();
                //this.reader.Position = (int)((float)pos.TotalSeconds / (float)this.reader.TotalTime.TotalSeconds) * this.reader.Length;
                //this.waveOut.Play();
                //this.timer.Enabled = true;
            }
        }
        public MyPlayer Player = new MyPlayer();
        private void 播放测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.Load(@"D:\CloudMusic\憐歌 - Kanon.mp3");
            Player.Play();
            音量控制条.Value = (int)(Player.Volume * 50);
        }
        private bool lockPos = false;
        private long[] posMem = new[] { 0L, 0L, 0L, 0L, 0L, 0L };
        public void Position_Updated(TimeSpan current, TimeSpan total)
        {
            Dispatcher.CurrentDispatcher.Invoke(new Action(() =>
            {
                if (!lockPos)
                {
                    播放进度.Maximum = (int)total.TotalSeconds;
                    播放进度.Value = (int)current.TotalSeconds;
                }
            }), null);
        }
        public List<string> recentFiles = new List<string>();
        string recentFileRec = "recent.txt";

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(recentFileRec))
            {
                File.WriteAllText(recentFileRec, string.Empty);
            }
            加载最近文件菜单();
        }

        private void 加载最近文件菜单()
        {

            var lines = File.ReadAllLines(recentFileRec);
            recentFiles.Clear();
            foreach (var line in lines)
            {
                if (line.Trim() == string.Empty) continue;
                recentFiles.Insert(0, line);
            }
            最近的文件ToolStripMenuItem.DropDownItems.Clear();
            foreach (var item in recentFiles)
            {
                var recentItem = 最近的文件ToolStripMenuItem.DropDownItems.Add(item);
                recentItem.Click += RecentItem_Click;
            }
        }

        private void RecentItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (!File.Exists(item.Text))
            {
                MessageBox.Show("文件不见了！");
                return;
            }
            LoadFile(item.Text);
        }

        private void 音量控制条_Scroll(object sender, EventArgs e)
        {
            Player.Volume = (float)音量控制条.Value / (float)音量控制条.Maximum;
            this.Text = "音量：" + Player.Volume;
        }

        private void 播放进度_MouseDown(object sender, MouseEventArgs e)
        {
            lockPos = true;
        }

        private void 播放进度_MouseUp(object sender, MouseEventArgs e)
        {
            var ts = TimeSpan.FromSeconds(播放进度.Value);
            Player.SetPos(ts);
            lockPos = false;

        }

        private void 播放进度_ValueChanged(object sender, EventArgs e)
        {
            播放位置标签.Text = $"{TimeSpan.FromSeconds(播放进度.Value):mm':'ss} / {TimeSpan.FromSeconds(播放进度.Maximum):mm':'ss}";

        }

        private void 回到上次的点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = int.Parse((sender as ToolStripMenuItem).Tag.ToString());
            Player.SetPos(TimeSpan.FromSeconds(posMem[index]));
        }

        private void 重置上次的点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = int.Parse((sender as ToolStripMenuItem).Tag.ToString());
            posMem[index] = 播放进度.Value; 
            posMem[0] = 播放进度.Value;

        }


        private void 寻找口琴谱按钮_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.acgmuse.com/");
        }

        private void 播放按钮_Click(object sender, EventArgs e)
        {
            Player.Play();
        }

        private void 暂停按钮_Click(object sender, EventArgs e)
        {
            Player.Pause();
        }

        private void 打开文件按钮_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            d.Filter = "MP3文件|*.mp3";
            var o = d.ShowDialog();
            if (o != DialogResult.OK)
            {
                return;

            }
            if (!File.Exists(d.FileName))
            {
                return;
            }
            LoadFile(d.FileName);
        }

        private void LoadFile(string fn)
        {
            recentFiles.RemoveAll(x => x == fn);
            recentFiles.Insert(0, fn);
            var rec = new StringBuilder();
            foreach (var item in recentFiles)
            {
                rec.AppendLine(item);
            }
            File.WriteAllText(recentFileRec, rec.ToString());
            加载最近文件菜单();
            文件名文本框.Text = fn;
            Player.Load(fn);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                回到上次的点ToolStripMenuItem_Click(回到上次的点ToolStripMenuItem, null);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Player.Clear();
        }
    }
}
