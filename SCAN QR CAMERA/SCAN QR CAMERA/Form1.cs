using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace SCAN_QR_CAMERA
{
    public partial class Form1 : Form
    {

        MJPEGStream stream;
        private Timer _timer;


        public Form1()
        {
            InitializeComponent();
            InitializeCamera();

        }

        private void InitializeCamera()
        {
            // Kết nối tới luồng RTSP của camera
            string rtspUrl = "rtsp://uyen:@Uyen23071998@192.168.1.7:554/cam/realmonitor?channel=4&subtype=0&unicast=true&proto=Onvif";
            stream = new MJPEGStream(rtspUrl);
            stream.NewFrame += stream_NewFrame;
            stream.Start();
            _timer.Enabled = true;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
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

    }
}
