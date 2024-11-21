using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QR_SCAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MJPEGStream stream;

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kết nối tới luồng RTSP của camera
            string rtspUrl = "rtsp://uyen:@Uyen23071998@192.168.1.7:554/cam/realmonitor?channel=4&subtype=0&unicast=true&proto=Onvif";
            //stream = new MJPEGStream("2");
            //stream.NewFrame += stream_NewFrame;
            //stream.Start();
            //timer1.Enabled = true;
            //timer1.Start();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice(videoDevices[3].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;

            // Bắt đầu phát luồng
            videoSource.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap img = (Bitmap)pic_cam.Image;
            if (img != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(img);
                try
                {
                    string decoded = result.ToString().Trim();
                    if (!listBox1.Items.Contains(decoded))
                    {
                        listBox1.Items.Insert(0, decoded);
                    }

                    img.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "");
                }

            }
        }

        public void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pic_cam.Image = bmp;
        }


        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Lấy khung hình hiện tại
            pic_cam.Image = (Bitmap)eventArgs.Frame.Clone();

            // Hiển thị hình ảnh lên PictureBox (nếu có giao diện)
            currentFrame = (Bitmap)eventArgs.Frame.Clone();

            // Quét mã QR
            ScanQRCode(currentFrame);
        }

        private void ScanQRCode(Bitmap frame)
        {
            try
            {
                // Sử dụng ZXing để quét mã QR
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(frame);

                if (result != null)
                {
                    // Hiển thị nội dung mã QR
                    Invoke(new Action(() =>
                    {
                        //MessageBox.Show($"Mã QR được phát hiện: {result.Text}", "Thông báo");
                    }));

                    // Dừng luồng video sau khi quét xong (tuỳ chọn)
                    //videoSource.SignalToStop();
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Lỗi khi quét mã QR: {ex.Message}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dừng video khi đóng form
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
        }
    }
}
