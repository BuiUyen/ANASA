using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using ZXing;

namespace SCAN_QR_CAMERA
{
    public partial class Form1 : Form
    {

        private VideoCapture _capture;
        private Timer _timer;


        public Form1()
        {
            InitializeComponent();
            InitializeCamera();

        }

        private void InitializeCamera()
        {
            // Kết nối tới luồng RTSP của camera
            string rtspUrl = "rtsp://uyen:@Uyen23071998@192.168.1.7:554/cam/realmonitor?channel=3&subtype=0&unicast=true&proto=Onvif";
            _capture = new VideoCapture(rtspUrl);
            _capture.SetCaptureProperty(CapProp.Fps, 30); // Set frame rate nếu cần

            _timer = new Timer();
            _timer.Interval = 1000 / 30; // Quét mỗi frame
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            using (Mat frame = _capture.QueryFrame())
            {
                if (frame != null)
                {
                    // Chuyển Mat thành Bitmap
                    Bitmap bitmap = frame.ToBitmap();

                    // Giải mã QR từ hình ảnh
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode(bitmap);

                    if (result != null)
                    {
                        textBox1.Text = result.Text; // Hiển thị nội dung QR code
                    }

                    pictureBox1.Image = bitmap; // Hiển thị video từ camera
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer?.Stop();
            _capture?.Dispose();
        }
    }
}
