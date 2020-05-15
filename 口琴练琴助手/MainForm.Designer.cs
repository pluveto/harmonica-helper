namespace 口琴练琴助手
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.打开文件按钮 = new System.Windows.Forms.Button();
            this.文件名文本框 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开MP3文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回到点1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回到点2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回到点3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回到点4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回到点5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.设置点1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置点2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置点3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置点4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置点5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.回到上次的点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置上次的点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放进度 = new System.Windows.Forms.TrackBar();
            this.播放位置标签 = new System.Windows.Forms.Label();
            this.音量控制条 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.寻找口琴谱按钮 = new System.Windows.Forms.Button();
            this.播放按钮 = new System.Windows.Forms.Button();
            this.暂停按钮 = new System.Windows.Forms.Button();
            this.最近的文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.播放进度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.音量控制条)).BeginInit();
            this.SuspendLayout();
            // 
            // 打开文件按钮
            // 
            this.打开文件按钮.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.打开文件按钮.AutoEllipsis = true;
            this.打开文件按钮.Location = new System.Drawing.Point(549, 28);
            this.打开文件按钮.Name = "打开文件按钮";
            this.打开文件按钮.Size = new System.Drawing.Size(75, 23);
            this.打开文件按钮.TabIndex = 0;
            this.打开文件按钮.Text = "打开 MP3";
            this.打开文件按钮.UseVisualStyleBackColor = true;
            this.打开文件按钮.Click += new System.EventHandler(this.打开文件按钮_Click);
            // 
            // 文件名文本框
            // 
            this.文件名文本框.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.文件名文本框.Location = new System.Drawing.Point(12, 30);
            this.文件名文本框.Name = "文件名文本框";
            this.文件名文本框.ReadOnly = true;
            this.文件名文本框.Size = new System.Drawing.Size(531, 21);
            this.文件名文本框.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.播放ToolStripMenuItem,
            this.调试ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开MP3文件ToolStripMenuItem,
            this.最近的文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开MP3文件ToolStripMenuItem
            // 
            this.打开MP3文件ToolStripMenuItem.Name = "打开MP3文件ToolStripMenuItem";
            this.打开MP3文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开MP3文件ToolStripMenuItem.Text = "打开 MP3 文件";
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.回到点1ToolStripMenuItem,
            this.回到点2ToolStripMenuItem,
            this.回到点3ToolStripMenuItem,
            this.回到点4ToolStripMenuItem,
            this.回到点5ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.设置点1ToolStripMenuItem,
            this.设置点2ToolStripMenuItem,
            this.设置点3ToolStripMenuItem,
            this.设置点4ToolStripMenuItem,
            this.设置点5ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.回到上次的点ToolStripMenuItem,
            this.重置上次的点ToolStripMenuItem});
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.播放ToolStripMenuItem.Text = "播放";
            // 
            // 回到点1ToolStripMenuItem
            // 
            this.回到点1ToolStripMenuItem.Name = "回到点1ToolStripMenuItem";
            this.回到点1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.回到点1ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.回到点1ToolStripMenuItem.Tag = "1";
            this.回到点1ToolStripMenuItem.Text = "回到点 1";
            this.回到点1ToolStripMenuItem.Click += new System.EventHandler(this.回到上次的点ToolStripMenuItem_Click);
            // 
            // 回到点2ToolStripMenuItem
            // 
            this.回到点2ToolStripMenuItem.Name = "回到点2ToolStripMenuItem";
            this.回到点2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.回到点2ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.回到点2ToolStripMenuItem.Tag = "2";
            this.回到点2ToolStripMenuItem.Text = "回到点 2";
            this.回到点2ToolStripMenuItem.Click += new System.EventHandler(this.回到上次的点ToolStripMenuItem_Click);
            // 
            // 回到点3ToolStripMenuItem
            // 
            this.回到点3ToolStripMenuItem.Name = "回到点3ToolStripMenuItem";
            this.回到点3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.回到点3ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.回到点3ToolStripMenuItem.Tag = "3";
            this.回到点3ToolStripMenuItem.Text = "回到点 3";
            this.回到点3ToolStripMenuItem.Click += new System.EventHandler(this.回到上次的点ToolStripMenuItem_Click);
            // 
            // 回到点4ToolStripMenuItem
            // 
            this.回到点4ToolStripMenuItem.Name = "回到点4ToolStripMenuItem";
            this.回到点4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.回到点4ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.回到点4ToolStripMenuItem.Tag = "4";
            this.回到点4ToolStripMenuItem.Text = "回到点 4";
            this.回到点4ToolStripMenuItem.Click += new System.EventHandler(this.回到上次的点ToolStripMenuItem_Click);
            // 
            // 回到点5ToolStripMenuItem
            // 
            this.回到点5ToolStripMenuItem.Name = "回到点5ToolStripMenuItem";
            this.回到点5ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.回到点5ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.回到点5ToolStripMenuItem.Tag = "5";
            this.回到点5ToolStripMenuItem.Text = "回到点 5";
            this.回到点5ToolStripMenuItem.Click += new System.EventHandler(this.回到上次的点ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // 设置点1ToolStripMenuItem
            // 
            this.设置点1ToolStripMenuItem.Name = "设置点1ToolStripMenuItem";
            this.设置点1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.设置点1ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.设置点1ToolStripMenuItem.Tag = "1";
            this.设置点1ToolStripMenuItem.Text = "设置点 1";
            this.设置点1ToolStripMenuItem.Click += new System.EventHandler(this.重置上次的点ToolStripMenuItem_Click);
            // 
            // 设置点2ToolStripMenuItem
            // 
            this.设置点2ToolStripMenuItem.Name = "设置点2ToolStripMenuItem";
            this.设置点2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D2)));
            this.设置点2ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.设置点2ToolStripMenuItem.Tag = "2";
            this.设置点2ToolStripMenuItem.Text = "设置点 2";
            this.设置点2ToolStripMenuItem.Click += new System.EventHandler(this.重置上次的点ToolStripMenuItem_Click);
            // 
            // 设置点3ToolStripMenuItem
            // 
            this.设置点3ToolStripMenuItem.Name = "设置点3ToolStripMenuItem";
            this.设置点3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D3)));
            this.设置点3ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.设置点3ToolStripMenuItem.Tag = "3";
            this.设置点3ToolStripMenuItem.Text = "设置点 3";
            this.设置点3ToolStripMenuItem.Click += new System.EventHandler(this.重置上次的点ToolStripMenuItem_Click);
            // 
            // 设置点4ToolStripMenuItem
            // 
            this.设置点4ToolStripMenuItem.Name = "设置点4ToolStripMenuItem";
            this.设置点4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D4)));
            this.设置点4ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.设置点4ToolStripMenuItem.Tag = "4";
            this.设置点4ToolStripMenuItem.Text = "设置点 4";
            this.设置点4ToolStripMenuItem.Click += new System.EventHandler(this.重置上次的点ToolStripMenuItem_Click);
            // 
            // 设置点5ToolStripMenuItem
            // 
            this.设置点5ToolStripMenuItem.Name = "设置点5ToolStripMenuItem";
            this.设置点5ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D5)));
            this.设置点5ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.设置点5ToolStripMenuItem.Tag = "5";
            this.设置点5ToolStripMenuItem.Text = "设置点 5";
            this.设置点5ToolStripMenuItem.Click += new System.EventHandler(this.重置上次的点ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // 回到上次的点ToolStripMenuItem
            // 
            this.回到上次的点ToolStripMenuItem.Name = "回到上次的点ToolStripMenuItem";
            this.回到上次的点ToolStripMenuItem.ShortcutKeyDisplayString = "R";
            this.回到上次的点ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.回到上次的点ToolStripMenuItem.Tag = "0";
            this.回到上次的点ToolStripMenuItem.Text = "回到上次的点";
            this.回到上次的点ToolStripMenuItem.Click += new System.EventHandler(this.回到上次的点ToolStripMenuItem_Click);
            // 
            // 重置上次的点ToolStripMenuItem
            // 
            this.重置上次的点ToolStripMenuItem.Name = "重置上次的点ToolStripMenuItem";
            this.重置上次的点ToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.重置上次的点ToolStripMenuItem.Tag = "0";
            this.重置上次的点ToolStripMenuItem.Text = "重置上次的点";
            this.重置上次的点ToolStripMenuItem.Click += new System.EventHandler(this.重置上次的点ToolStripMenuItem_Click);
            // 
            // 调试ToolStripMenuItem
            // 
            this.调试ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.播放测试ToolStripMenuItem});
            this.调试ToolStripMenuItem.Name = "调试ToolStripMenuItem";
            this.调试ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.调试ToolStripMenuItem.Text = "调试";
            // 
            // 播放测试ToolStripMenuItem
            // 
            this.播放测试ToolStripMenuItem.Name = "播放测试ToolStripMenuItem";
            this.播放测试ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.播放测试ToolStripMenuItem.Text = "播放测试";
            this.播放测试ToolStripMenuItem.Click += new System.EventHandler(this.播放测试ToolStripMenuItem_Click);
            // 
            // 播放进度
            // 
            this.播放进度.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.播放进度.Location = new System.Drawing.Point(12, 57);
            this.播放进度.Name = "播放进度";
            this.播放进度.Size = new System.Drawing.Size(531, 45);
            this.播放进度.TabIndex = 3;
            this.播放进度.ValueChanged += new System.EventHandler(this.播放进度_ValueChanged);
            this.播放进度.MouseDown += new System.Windows.Forms.MouseEventHandler(this.播放进度_MouseDown);
            this.播放进度.MouseUp += new System.Windows.Forms.MouseEventHandler(this.播放进度_MouseUp);
            // 
            // 播放位置标签
            // 
            this.播放位置标签.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.播放位置标签.AutoEllipsis = true;
            this.播放位置标签.AutoSize = true;
            this.播放位置标签.Location = new System.Drawing.Point(549, 66);
            this.播放位置标签.Name = "播放位置标签";
            this.播放位置标签.Size = new System.Drawing.Size(83, 12);
            this.播放位置标签.TabIndex = 4;
            this.播放位置标签.Text = "00:00 / 00:00";
            // 
            // 音量控制条
            // 
            this.音量控制条.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.音量控制条.Location = new System.Drawing.Point(12, 118);
            this.音量控制条.Maximum = 50;
            this.音量控制条.Name = "音量控制条";
            this.音量控制条.Size = new System.Drawing.Size(135, 45);
            this.音量控制条.TabIndex = 5;
            this.音量控制条.Value = 25;
            this.音量控制条.Scroll += new System.EventHandler(this.音量控制条_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "音量";
            // 
            // 寻找口琴谱按钮
            // 
            this.寻找口琴谱按钮.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.寻找口琴谱按钮.Location = new System.Drawing.Point(551, 110);
            this.寻找口琴谱按钮.Name = "寻找口琴谱按钮";
            this.寻找口琴谱按钮.Size = new System.Drawing.Size(75, 23);
            this.寻找口琴谱按钮.TabIndex = 7;
            this.寻找口琴谱按钮.Text = "寻找口琴谱";
            this.寻找口琴谱按钮.UseVisualStyleBackColor = true;
            this.寻找口琴谱按钮.Click += new System.EventHandler(this.寻找口琴谱按钮_Click);
            // 
            // 播放按钮
            // 
            this.播放按钮.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.播放按钮.Location = new System.Drawing.Point(258, 110);
            this.播放按钮.Name = "播放按钮";
            this.播放按钮.Size = new System.Drawing.Size(51, 23);
            this.播放按钮.TabIndex = 8;
            this.播放按钮.Text = "播放";
            this.播放按钮.UseVisualStyleBackColor = true;
            this.播放按钮.Click += new System.EventHandler(this.播放按钮_Click);
            // 
            // 暂停按钮
            // 
            this.暂停按钮.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.暂停按钮.Location = new System.Drawing.Point(315, 110);
            this.暂停按钮.Name = "暂停按钮";
            this.暂停按钮.Size = new System.Drawing.Size(51, 23);
            this.暂停按钮.TabIndex = 8;
            this.暂停按钮.Text = "暂停";
            this.暂停按钮.UseVisualStyleBackColor = true;
            this.暂停按钮.Click += new System.EventHandler(this.暂停按钮_Click);
            // 
            // 最近的文件ToolStripMenuItem
            // 
            this.最近的文件ToolStripMenuItem.Name = "最近的文件ToolStripMenuItem";
            this.最近的文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.最近的文件ToolStripMenuItem.Text = "最近的文件";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Acgmuse ACG 口琴站 acgmuse.com (c) 2020 版权所有";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.暂停按钮);
            this.Controls.Add(this.播放按钮);
            this.Controls.Add(this.寻找口琴谱按钮);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.音量控制条);
            this.Controls.Add(this.播放位置标签);
            this.Controls.Add(this.播放进度);
            this.Controls.Add(this.文件名文本框);
            this.Controls.Add(this.打开文件按钮);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "练琴助手 by Pluvet v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.播放进度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.音量控制条)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 打开文件按钮;
        private System.Windows.Forms.TextBox 文件名文本框;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开MP3文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回到点1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回到点2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回到点3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回到点4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回到点5ToolStripMenuItem;
        private System.Windows.Forms.TrackBar 播放进度;
        private System.Windows.Forms.Label 播放位置标签;
        private System.Windows.Forms.ToolStripMenuItem 调试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放测试ToolStripMenuItem;
        private System.Windows.Forms.TrackBar 音量控制条;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 回到上次的点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置点1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置点2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置点3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置点4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置点5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 重置上次的点ToolStripMenuItem;
        private System.Windows.Forms.Button 寻找口琴谱按钮;
        private System.Windows.Forms.Button 播放按钮;
        private System.Windows.Forms.Button 暂停按钮;
        private System.Windows.Forms.ToolStripMenuItem 最近的文件ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

