namespace CamSurveillance
{
    partial class FormTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.btnLocal = new System.Windows.Forms.Button();
            this.videoSourcePlayerLocal = new AForge.Controls.VideoSourcePlayer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelUrl = new System.Windows.Forms.Panel();
            this.btnLinkJPEG = new System.Windows.Forms.Button();
            this.comboBoxJPEG = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.videoSourcePlayerJPEG = new AForge.Controls.VideoSourcePlayer();
            this.tabPageMJPEG = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLinkMJPEG = new System.Windows.Forms.Button();
            this.comboBoxMJPEG = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.videoSourcePlayerMJPEG = new AForge.Controls.VideoSourcePlayer();
            this.tabPageRTPS = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLinkRTPS = new System.Windows.Forms.Button();
            this.comboBoxRTPS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.tabPageRTP = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxRemotePort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRemoteIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLocalIP = new System.Windows.Forms.TextBox();
            this.btnLinkRTP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imageBoxRTP = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.tabControl.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelUrl.SuspendLayout();
            this.tabPageMJPEG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageRTPS.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).BeginInit();
            this.tabPageRTP.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxRTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLocal);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPageMJPEG);
            this.tabControl.Controls.Add(this.tabPageRTPS);
            this.tabControl.Controls.Add(this.tabPageRTP);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1044, 784);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.Controls.Add(this.btnLocal);
            this.tabPageLocal.Controls.Add(this.videoSourcePlayerLocal);
            this.tabPageLocal.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocal.Size = new System.Drawing.Size(1036, 758);
            this.tabPageLocal.TabIndex = 0;
            this.tabPageLocal.Text = "本地监控";
            this.tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(6, 16);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(121, 38);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.Text = "打开本地摄像头";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // videoSourcePlayerLocal
            // 
            this.videoSourcePlayerLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayerLocal.BackColor = System.Drawing.SystemColors.Desktop;
            this.videoSourcePlayerLocal.Location = new System.Drawing.Point(0, 85);
            this.videoSourcePlayerLocal.Name = "videoSourcePlayerLocal";
            this.videoSourcePlayerLocal.Size = new System.Drawing.Size(1036, 673);
            this.videoSourcePlayerLocal.TabIndex = 0;
            this.videoSourcePlayerLocal.Text = "videoSourcePlayer1";
            this.videoSourcePlayerLocal.VideoSource = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelUrl);
            this.tabPage2.Controls.Add(this.videoSourcePlayerJPEG);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 758);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "远程JPEG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelUrl
            // 
            this.panelUrl.Controls.Add(this.btnLinkJPEG);
            this.panelUrl.Controls.Add(this.comboBoxJPEG);
            this.panelUrl.Controls.Add(this.labelTip);
            this.panelUrl.Location = new System.Drawing.Point(6, 16);
            this.panelUrl.Name = "panelUrl";
            this.panelUrl.Size = new System.Drawing.Size(617, 47);
            this.panelUrl.TabIndex = 4;
            // 
            // btnLinkJPEG
            // 
            this.btnLinkJPEG.Location = new System.Drawing.Point(527, 8);
            this.btnLinkJPEG.Name = "btnLinkJPEG";
            this.btnLinkJPEG.Size = new System.Drawing.Size(75, 30);
            this.btnLinkJPEG.TabIndex = 2;
            this.btnLinkJPEG.Text = "连接";
            this.btnLinkJPEG.UseVisualStyleBackColor = true;
            this.btnLinkJPEG.Click += new System.EventHandler(this.btnLinkJPEG_Click);
            // 
            // comboBoxJPEG
            // 
            this.comboBoxJPEG.FormattingEnabled = true;
            this.comboBoxJPEG.Items.AddRange(new object[] {
            "http://www.gtc.iac.es/multimedia/netcam/camaraExt.jpg",
            "http://217.168.94.131/axis-cgi/jpg/image.cgi?resolution=320x240"});
            this.comboBoxJPEG.Location = new System.Drawing.Point(110, 14);
            this.comboBoxJPEG.Name = "comboBoxJPEG";
            this.comboBoxJPEG.Size = new System.Drawing.Size(399, 20);
            this.comboBoxJPEG.TabIndex = 1;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(3, 17);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(101, 12);
            this.labelTip.TabIndex = 0;
            this.labelTip.Text = "请输入JPEG URL：";
            // 
            // videoSourcePlayerJPEG
            // 
            this.videoSourcePlayerJPEG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayerJPEG.BackColor = System.Drawing.SystemColors.Desktop;
            this.videoSourcePlayerJPEG.Location = new System.Drawing.Point(0, 85);
            this.videoSourcePlayerJPEG.Name = "videoSourcePlayerJPEG";
            this.videoSourcePlayerJPEG.Size = new System.Drawing.Size(1036, 673);
            this.videoSourcePlayerJPEG.TabIndex = 1;
            this.videoSourcePlayerJPEG.VideoSource = null;
            // 
            // tabPageMJPEG
            // 
            this.tabPageMJPEG.Controls.Add(this.panel1);
            this.tabPageMJPEG.Controls.Add(this.videoSourcePlayerMJPEG);
            this.tabPageMJPEG.Location = new System.Drawing.Point(4, 22);
            this.tabPageMJPEG.Name = "tabPageMJPEG";
            this.tabPageMJPEG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMJPEG.Size = new System.Drawing.Size(1036, 758);
            this.tabPageMJPEG.TabIndex = 2;
            this.tabPageMJPEG.Text = "远程MJPEG";
            this.tabPageMJPEG.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLinkMJPEG);
            this.panel1.Controls.Add(this.comboBoxMJPEG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 47);
            this.panel1.TabIndex = 6;
            // 
            // btnLinkMJPEG
            // 
            this.btnLinkMJPEG.Location = new System.Drawing.Point(527, 8);
            this.btnLinkMJPEG.Name = "btnLinkMJPEG";
            this.btnLinkMJPEG.Size = new System.Drawing.Size(75, 30);
            this.btnLinkMJPEG.TabIndex = 2;
            this.btnLinkMJPEG.Text = "连接";
            this.btnLinkMJPEG.UseVisualStyleBackColor = true;
            this.btnLinkMJPEG.Click += new System.EventHandler(this.btnMJPEG_Click);
            // 
            // comboBoxMJPEG
            // 
            this.comboBoxMJPEG.FormattingEnabled = true;
            this.comboBoxMJPEG.Items.AddRange(new object[] {
            "http://towercam.uu.edu/axis-cgi/mjpg/video.cgi"});
            this.comboBoxMJPEG.Location = new System.Drawing.Point(110, 14);
            this.comboBoxMJPEG.Name = "comboBoxMJPEG";
            this.comboBoxMJPEG.Size = new System.Drawing.Size(399, 20);
            this.comboBoxMJPEG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入MJPEG URL：";
            // 
            // videoSourcePlayerMJPEG
            // 
            this.videoSourcePlayerMJPEG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayerMJPEG.BackColor = System.Drawing.SystemColors.WindowText;
            this.videoSourcePlayerMJPEG.Location = new System.Drawing.Point(0, 85);
            this.videoSourcePlayerMJPEG.Name = "videoSourcePlayerMJPEG";
            this.videoSourcePlayerMJPEG.Size = new System.Drawing.Size(1033, 673);
            this.videoSourcePlayerMJPEG.TabIndex = 5;
            this.videoSourcePlayerMJPEG.VideoSource = null;
            // 
            // tabPageRTPS
            // 
            this.tabPageRTPS.Controls.Add(this.panel2);
            this.tabPageRTPS.Controls.Add(this.vlcControl);
            this.tabPageRTPS.Location = new System.Drawing.Point(4, 22);
            this.tabPageRTPS.Name = "tabPageRTPS";
            this.tabPageRTPS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRTPS.Size = new System.Drawing.Size(1036, 758);
            this.tabPageRTPS.TabIndex = 3;
            this.tabPageRTPS.Text = "远程RTPS";
            this.tabPageRTPS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLinkRTPS);
            this.panel2.Controls.Add(this.comboBoxRTPS);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 47);
            this.panel2.TabIndex = 7;
            // 
            // btnLinkRTPS
            // 
            this.btnLinkRTPS.Location = new System.Drawing.Point(527, 8);
            this.btnLinkRTPS.Name = "btnLinkRTPS";
            this.btnLinkRTPS.Size = new System.Drawing.Size(75, 30);
            this.btnLinkRTPS.TabIndex = 2;
            this.btnLinkRTPS.Text = "连接";
            this.btnLinkRTPS.UseVisualStyleBackColor = true;
            this.btnLinkRTPS.Click += new System.EventHandler(this.btnLinkRTPS_Click);
            // 
            // comboBoxRTPS
            // 
            this.comboBoxRTPS.FormattingEnabled = true;
            this.comboBoxRTPS.Location = new System.Drawing.Point(110, 14);
            this.comboBoxRTPS.Name = "comboBoxRTPS";
            this.comboBoxRTPS.Size = new System.Drawing.Size(399, 20);
            this.comboBoxRTPS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入RPTS URL：";
            // 
            // vlcControl
            // 
            this.vlcControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlcControl.BackColor = System.Drawing.Color.Black;
            this.vlcControl.Location = new System.Drawing.Point(0, 85);
            this.vlcControl.Name = "vlcControl";
            this.vlcControl.Size = new System.Drawing.Size(1036, 673);
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 0;
            this.vlcControl.Text = "vlcControl";
            this.vlcControl.VlcLibDirectory = null;
            this.vlcControl.VlcMediaplayerOptions = null;
            this.vlcControl.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl_VlcLibDirectoryNeeded);
            // 
            // tabPageRTP
            // 
            this.tabPageRTP.Controls.Add(this.imageBox3);
            this.tabPageRTP.Controls.Add(this.imageBox2);
            this.tabPageRTP.Controls.Add(this.imageBox1);
            this.tabPageRTP.Controls.Add(this.panel3);
            this.tabPageRTP.Controls.Add(this.imageBoxRTP);
            this.tabPageRTP.Location = new System.Drawing.Point(4, 22);
            this.tabPageRTP.Name = "tabPageRTP";
            this.tabPageRTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRTP.Size = new System.Drawing.Size(1036, 758);
            this.tabPageRTP.TabIndex = 4;
            this.tabPageRTP.Text = "远程RTP";
            this.tabPageRTP.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxRemotePort);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxRemoteIP);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxLocalIP);
            this.panel3.Controls.Add(this.btnLinkRTP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 73);
            this.panel3.TabIndex = 8;
            // 
            // textBoxRemotePort
            // 
            this.textBoxRemotePort.Location = new System.Drawing.Point(266, 46);
            this.textBoxRemotePort.Name = "textBoxRemotePort";
            this.textBoxRemotePort.Size = new System.Drawing.Size(111, 21);
            this.textBoxRemotePort.TabIndex = 7;
            this.textBoxRemotePort.Text = "10011";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "目的端口：";
            // 
            // textBoxRemoteIP
            // 
            this.textBoxRemoteIP.Location = new System.Drawing.Point(62, 46);
            this.textBoxRemoteIP.Name = "textBoxRemoteIP";
            this.textBoxRemoteIP.Size = new System.Drawing.Size(111, 21);
            this.textBoxRemoteIP.TabIndex = 5;
            this.textBoxRemoteIP.Text = "192.168.112.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "目的IP：";
            // 
            // textBoxLocalIP
            // 
            this.textBoxLocalIP.Location = new System.Drawing.Point(62, 14);
            this.textBoxLocalIP.Name = "textBoxLocalIP";
            this.textBoxLocalIP.Size = new System.Drawing.Size(111, 21);
            this.textBoxLocalIP.TabIndex = 3;
            this.textBoxLocalIP.Text = "192.168.112.4";
            // 
            // btnLinkRTP
            // 
            this.btnLinkRTP.Location = new System.Drawing.Point(462, 17);
            this.btnLinkRTP.Name = "btnLinkRTP";
            this.btnLinkRTP.Size = new System.Drawing.Size(75, 30);
            this.btnLinkRTP.TabIndex = 2;
            this.btnLinkRTP.Text = "连接";
            this.btnLinkRTP.UseVisualStyleBackColor = true;
            this.btnLinkRTP.Click += new System.EventHandler(this.btnLinkRTP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "本机IP：";
            // 
            // imageBoxRTP
            // 
            this.imageBoxRTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxRTP.BackColor = System.Drawing.Color.Gray;
            this.imageBoxRTP.Location = new System.Drawing.Point(0, 85);
            this.imageBoxRTP.Name = "imageBoxRTP";
            this.imageBoxRTP.Size = new System.Drawing.Size(1033, 670);
            this.imageBoxRTP.TabIndex = 2;
            this.imageBoxRTP.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(598, 18);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(75, 23);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(598, 52);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(75, 23);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(692, 18);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(75, 23);
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // FormTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 784);
            this.Controls.Add(this.tabControl);
            this.Name = "FormTab";
            this.Text = "视频通信";
            this.tabControl.ResumeLayout(false);
            this.tabPageLocal.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelUrl.ResumeLayout(false);
            this.panelUrl.PerformLayout();
            this.tabPageMJPEG.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageRTPS.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).EndInit();
            this.tabPageRTP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxRTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.TabPage tabPage2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayerLocal;
        private System.Windows.Forms.Button btnLocal;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayerJPEG;
        private System.Windows.Forms.Panel panelUrl;
        private System.Windows.Forms.Button btnLinkJPEG;
        private System.Windows.Forms.ComboBox comboBoxJPEG;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.TabPage tabPageMJPEG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLinkMJPEG;
        private System.Windows.Forms.ComboBox comboBoxMJPEG;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayerMJPEG;
        private System.Windows.Forms.TabPage tabPageRTPS;
        private Vlc.DotNet.Forms.VlcControl vlcControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLinkRTPS;
        private System.Windows.Forms.ComboBox comboBoxRTPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageRTP;
        private Emgu.CV.UI.ImageBox imageBoxRTP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLinkRTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLocalIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRemoteIP;
        private System.Windows.Forms.TextBox textBoxRemotePort;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}