using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;

namespace CamSurveillance
{
    public partial class MainForm : Form
    {
        private Stopwatch stopWatch = null;
        private enum LINKTYPE { JPEG, MJPEG };
        private LINKTYPE currentChoice = LINKTYPE.JPEG;

        public MainForm()
        {
            InitializeComponent();
            this.panelUrl.Visible = false;
        }

        private void 本地摄像头ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // create video source
                VideoCaptureDevice videoSource = form.VideoDevice;

                // open it
                OpenVideoSource(videoSource);
            }
        }

        private void jPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelUrl.Visible = true;
            this.labelTip.Text = "请输入JEPG URL";
            this.comboBoxUrls.Text = "";
            currentChoice = LINKTYPE.JPEG;
            string[] URLs = new string[]
            {
                "http://www.gtc.iac.es/multimedia/netcam/camaraExt.jpg",
                "http://217.168.94.131/axis-cgi/jpg/image.cgi?resolution=320x240"
            };
            comboBoxUrls.Items.Clear();
            comboBoxUrls.Items.AddRange(URLs);
        }

        private void mJPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelUrl.Visible = true;
            this.labelTip.Text = "请输入MJEPG URL";
            this.comboBoxUrls.Text = "";
            currentChoice = LINKTYPE.MJPEG;
            string[] URLs = new string[]
            {
                "http://towercam.uu.edu/axis-cgi/mjpg/video.cgi"
            };
            comboBoxUrls.Items.Clear();
            comboBoxUrls.Items.AddRange(URLs);
        }

        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();

            // reset stop watch
            stopWatch = null;

            // start timer
            timer.Start();

            this.Cursor = Cursors.Default;
        }

        // Close video source if it is running
        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            string url = comboBoxUrls.Text;
            if (url.Trim().Length == 0)
            {
                MessageBox.Show("请输入远程URL地址！");
                return;
            }
            switch (currentChoice)
            {
                case LINKTYPE.JPEG:
                {
                    
                    // create video source
                    JPEGStream jpegSource = new JPEGStream(url);

                    // open it
                    OpenVideoSource(jpegSource);
                    break;
                }
                case LINKTYPE.MJPEG:
                {
                    // create video source
                    MJPEGStream mjpegSource = new MJPEGStream(url);

                    // open it
                    OpenVideoSource(mjpegSource);
                    break;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            DateTime now = DateTime.Now;
            Graphics g = Graphics.FromImage(image);

            // paint current time
            SolidBrush brush = new SolidBrush(Color.Red);
            g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
            brush.Dispose();

            g.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            IVideoSource videoSource = videoSourcePlayer.VideoSource;

            if (videoSource != null)
            {
                // get number of frames since the last timer tick
                int framesReceived = videoSource.FramesReceived;

                if (stopWatch == null)
                {
                    stopWatch = new Stopwatch();
                    stopWatch.Start();
                }
                else
                {
                    stopWatch.Stop();

                    float fps = 1000.0f * framesReceived / stopWatch.ElapsedMilliseconds;
                    toolStripStatusLabel.Text = fps.ToString("F2") + " fps";

                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }
        }
    }
}
