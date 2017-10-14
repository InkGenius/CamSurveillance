namespace CamSurveillance
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
            this.components = new System.ComponentModel.Container();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.本地摄像头ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开JPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelUrl = new System.Windows.Forms.Panel();
            this.btnLink = new System.Windows.Forms.Button();
            this.comboBoxUrls = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.flowLayoutPanelVlc = new System.Windows.Forms.FlowLayoutPanel();
            this.vlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.flowLayoutPanelNormal = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelUrl.SuspendLayout();
            this.flowLayoutPanelVlc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).BeginInit();
            this.flowLayoutPanelNormal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(623, 343);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本地摄像头ToolStripMenuItem,
            this.打开JPEGURLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 本地摄像头ToolStripMenuItem
            // 
            this.本地摄像头ToolStripMenuItem.Name = "本地摄像头ToolStripMenuItem";
            this.本地摄像头ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.本地摄像头ToolStripMenuItem.Text = "本地摄像头";
            this.本地摄像头ToolStripMenuItem.Click += new System.EventHandler(this.本地摄像头ToolStripMenuItem_Click);
            // 
            // 打开JPEGURLToolStripMenuItem
            // 
            this.打开JPEGURLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jPEGURLToolStripMenuItem,
            this.mJPEGURLToolStripMenuItem,
            this.rTPSToolStripMenuItem});
            this.打开JPEGURLToolStripMenuItem.Name = "打开JPEGURLToolStripMenuItem";
            this.打开JPEGURLToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.打开JPEGURLToolStripMenuItem.Text = "远程摄像头";
            // 
            // jPEGURLToolStripMenuItem
            // 
            this.jPEGURLToolStripMenuItem.Name = "jPEGURLToolStripMenuItem";
            this.jPEGURLToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.jPEGURLToolStripMenuItem.Text = "JPEG URL";
            this.jPEGURLToolStripMenuItem.Click += new System.EventHandler(this.jPEGURLToolStripMenuItem_Click);
            // 
            // mJPEGURLToolStripMenuItem
            // 
            this.mJPEGURLToolStripMenuItem.Name = "mJPEGURLToolStripMenuItem";
            this.mJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.mJPEGURLToolStripMenuItem.Text = "MJPEG URL";
            this.mJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.mJPEGURLToolStripMenuItem_Click);
            // 
            // rTPSToolStripMenuItem
            // 
            this.rTPSToolStripMenuItem.Name = "rTPSToolStripMenuItem";
            this.rTPSToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.rTPSToolStripMenuItem.Text = "RTPS URL";
            this.rTPSToolStripMenuItem.Click += new System.EventHandler(this.rTPSToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 791);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(668, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panelUrl
            // 
            this.panelUrl.Controls.Add(this.btnLink);
            this.panelUrl.Controls.Add(this.comboBoxUrls);
            this.panelUrl.Controls.Add(this.labelTip);
            this.panelUrl.Location = new System.Drawing.Point(3, 28);
            this.panelUrl.Name = "panelUrl";
            this.panelUrl.Size = new System.Drawing.Size(654, 37);
            this.panelUrl.TabIndex = 3;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(538, 8);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(75, 23);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "连接";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // comboBoxUrls
            // 
            this.comboBoxUrls.FormattingEnabled = true;
            this.comboBoxUrls.Location = new System.Drawing.Point(111, 10);
            this.comboBoxUrls.Name = "comboBoxUrls";
            this.comboBoxUrls.Size = new System.Drawing.Size(399, 20);
            this.comboBoxUrls.TabIndex = 1;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(9, 13);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(53, 12);
            this.labelTip.TabIndex = 0;
            this.labelTip.Text = "labelTip";
            // 
            // flowLayoutPanelVlc
            // 
            this.flowLayoutPanelVlc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelVlc.Controls.Add(this.vlcControl);
            this.flowLayoutPanelVlc.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelVlc.Location = new System.Drawing.Point(9, 361);
            this.flowLayoutPanelVlc.Name = "flowLayoutPanelVlc";
            this.flowLayoutPanelVlc.Size = new System.Drawing.Size(642, 353);
            this.flowLayoutPanelVlc.TabIndex = 4;
            // 
            // vlcControl
            // 
            this.vlcControl.BackColor = System.Drawing.Color.Black;
            this.vlcControl.Location = new System.Drawing.Point(3, 3);
            this.vlcControl.Name = "vlcControl";
            this.vlcControl.Size = new System.Drawing.Size(588, 304);
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 0;
            this.vlcControl.Text = "vlcControl1";
            this.vlcControl.VlcLibDirectory = null;
            this.vlcControl.VlcMediaplayerOptions = null;
            this.vlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl_VlcLibDirectoryNeeded);
            // 
            // flowLayoutPanelNormal
            // 
            this.flowLayoutPanelNormal.Controls.Add(this.videoSourcePlayer);
            this.flowLayoutPanelNormal.Location = new System.Drawing.Point(9, 3);
            this.flowLayoutPanelNormal.Name = "flowLayoutPanelNormal";
            this.flowLayoutPanelNormal.Size = new System.Drawing.Size(642, 352);
            this.flowLayoutPanelNormal.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flowLayoutPanelNormal);
            this.panel1.Controls.Add(this.flowLayoutPanelVlc);
            this.panel1.Location = new System.Drawing.Point(3, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 717);
            this.panel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 813);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUrl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "摄像头通信";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelUrl.ResumeLayout(false);
            this.panelUrl.PerformLayout();
            this.flowLayoutPanelVlc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).EndInit();
            this.flowLayoutPanelNormal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 本地摄像头ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开JPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mJPEGURLToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelUrl;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.ComboBox comboBoxUrls;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVlc;
        private Vlc.DotNet.Forms.VlcControl vlcControl;
        private System.Windows.Forms.ToolStripMenuItem rTPSToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNormal;
        private System.Windows.Forms.Panel panel1;
    }
}

