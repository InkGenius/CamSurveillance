using System;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
using System.Reflection;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using StreamCoders.Network;
using RTPServer;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Diagnostics;

namespace CamSurveillance
{
    public partial class FormTab : Form
    {
        private bool isLocalOpen = false;
        private bool isJPEGOpen = false;
        private bool isMJPEGOpen = false;
        private bool isRTPSOpen = false;

        //RTP
        private const int MTU = 1000;//一个rtp包如果是经过UDP传输的原则上不要超过1460
        private RtpFramer _rtpFramer;
        List<RTPPacket> packets = new List<RTPPacket>();

        //Client
        private Dictionary<uint, List<RTPPacket>> Clients;
        private Dictionary<ImageBox, uint?> ImagesBoxMapping;

        public FormTab()
        {
            InitializeComponent();

            Clients = new Dictionary<uint, List<RTPPacket>>();
            ImagesBoxMapping = new Dictionary<ImageBox, uint?>()
            {
                {imageBoxRTP, null},
                {imageBox1, null},
                {imageBox2, null},
                {imageBox3, null}
            };
        }

        private void OpenVideoSource(IVideoSource source, VideoSourcePlayer player)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // stop current video source
            CloseVideoSource(player);

            // start new video source
            player.VideoSource = source;
            player.Start();

            this.Cursor = Cursors.Default;
        }

        private void CloseVideoSource(VideoSourcePlayer player)
        {
            if (player.VideoSource != null)
            {
                player.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!player.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (player.IsRunning)
                {
                    player.Stop();
                }

                player.VideoSource = null;
            }
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            if (!isLocalOpen)
            {
                btnLocal.Text = "关闭本地摄像头";
                isLocalOpen = true;
                VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    // create video source
                    VideoCaptureDevice videoSource = form.VideoDevice;

                    // open it
                    OpenVideoSource(videoSource,videoSourcePlayerLocal);
                }
            }
            else
            {
                btnLocal.Text = "打开本地摄像头";
                isLocalOpen = false;
                CloseVideoSource(videoSourcePlayerLocal);
            }
        }

        private void btnLinkJPEG_Click(object sender, EventArgs e)
        {
            if (!isJPEGOpen)
            {
                btnLinkJPEG.Text = "关闭";
                isJPEGOpen = true;
                string url = comboBoxJPEG.Text;
                if (url.Trim().Length == 0)
                {
                    MessageBox.Show("请输入远程URL地址！");
                    return;
                }
                JPEGStream jpegSource = new JPEGStream(url);
                OpenVideoSource(jpegSource, videoSourcePlayerJPEG);
            }
            else
            {
                btnLinkJPEG.Text = "连接";
                isJPEGOpen = false;
                comboBoxJPEG.Text = "";
                CloseVideoSource(videoSourcePlayerJPEG);
            }

        }

        private void btnMJPEG_Click(object sender, EventArgs e)
        {
            if (!isMJPEGOpen)
            {
                btnLinkMJPEG.Text = "关闭";
                isMJPEGOpen = true;
                string url = comboBoxMJPEG.Text;
                if (url.Trim().Length == 0)
                {
                    MessageBox.Show("请输入远程URL地址！");
                    return;
                }
                MJPEGStream mjpegSource = new MJPEGStream(url);
                OpenVideoSource(mjpegSource, videoSourcePlayerMJPEG);
            }
            else
            {
                btnLinkMJPEG.Text = "连接";
                isMJPEGOpen = false;
                comboBoxMJPEG.Text = "";
                CloseVideoSource(videoSourcePlayerMJPEG);
            }
        }

        private void btnLinkRTPS_Click(object sender, EventArgs e)
        {
            if (!isRTPSOpen)
            {
                btnLinkRTPS.Text = "关闭";
                isRTPSOpen = true;
                string url = comboBoxRTPS.Text;
                if (url.Trim().Length == 0)
                {
                    MessageBox.Show("请输入远程URL地址！");
                    return;
                }
                vlcControl.Play(new Uri(url.Trim()));
            }
            else
            {
                btnLinkMJPEG.Text = "连接";
                isRTPSOpen = false;
                comboBoxRTPS.Text = "";
                //CloseVideoSource(videoSourcePlayerMJPEG);
            }
        }

        private void vlcControl_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            if (currentDirectory == null)
                return;
            if (IntPtr.Size == 4)
                e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @"..\..\lib\x86\"));
            else
                e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @"..\..\lib\x64\"));

            if (!e.VlcLibDirectory.Exists)
            {
                var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
                folderBrowserDialog.Description = "Select Vlc libraries folder.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                }
            }
        }

     

        private void btnLinkRTP_Click(object sender, EventArgs e)
        {
            try
            {
                //初始化RTPSession
                var rtpIp = textBoxLocalIP.Text.Trim();
                var rtpPort = 20000;
                var rtcpIp = rtpIp;
                var rtcpPort = 20001;
                var forwardIp = textBoxRemoteIP.Text.Trim();
                var forwardPort = Convert.ToInt32(textBoxRemotePort.Text.Trim());

                _rtpFramer = new RtpFramer(rtpIp, rtpPort, rtcpIp, rtcpPort, forwardIp, forwardPort); //配置好
                _rtpFramer.Session.NewRTPPacket = NewRTPPacket;
                _rtpFramer.Session.NewRTCPPacket = NewRTCPPacket;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool NewRTPPacket(RTPPacket packet)
        {
            if (!Clients.ContainsKey(packet.SSRC))//如果接受端第一次接受到某源的数据，则加入到
            {
                if (Clients.Count < 4)//如果发送端为4，则丢弃包
                {
                    Clients.Add(packet.SSRC, new List<RTPPacket> { packet });
                    ImagesBoxMapping[ImagesBoxMapping.First(pair => pair.Value == null).Key] = packet.SSRC;
                }
            }
            else
            {
                Clients[packet.SSRC].Add(packet);
            }

            if (packet.Marker)//如果已经发送完毕
            {
                //丢包检测
                var orderPackets = Clients[packet.SSRC].OrderBy(rtpPacket => rtpPacket.SequenceNumber);
                if (Clients[packet.SSRC].Count != (orderPackets.Last().SequenceNumber - orderPackets.First().SequenceNumber + 1))
                {
                    Clients[packet.SSRC].Clear();//清空缓存区
                    return true;
                }

                //1.包重组
                var count = Clients[packet.SSRC].Sum(rtpPacket => rtpPacket.DataSize);//数据总数

                var newData = new byte[count];

                long offSet = 0;
                foreach (var rtpPacket in Clients[packet.SSRC])
                {
                    Array.Copy(rtpPacket.DataPointer, 0, newData, offSet, rtpPacket.DataSize);
                    offSet += rtpPacket.DataSize;
                }
                Clients[packet.SSRC].Clear();//清空缓存区

                var ms = new MemoryStream(newData);
                try
                {
                    var bmp = new Bitmap(Image.FromStream(ms));
                    var img = new Image<Bgr, Byte>(bmp);
                    ImagesBoxMapping.First(pair => pair.Value == packet.SSRC).Key.Image = img;
                }
                catch (Exception)
                {

                }
                finally
                {
                    ms.Close();
                }
            }
            return true;
        }

        private void NewRTCPPacket(RTCPCompoundPacket packet)
        {
        }
    }
}

