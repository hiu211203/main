using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;
using AForge.Video.DirectShow;
using System.Windows.Media.Media3D;
using AForge.Video;
using ZXing;

namespace BaiThucHanh3
{
    public partial class FormQRcode : Form
    {
        FilterInfoCollection cameras;
        VideoCaptureDevice cam;
        private Panel BorderBtn;
        public int id = 0;
        public FormQRcode()
        {
            InitializeComponent();
            BorderBtn = new Panel();
            BorderBtn.Size = new Size(78, 2);
            panelMenu.Controls.Add(BorderBtn);
            BorderBtn.BackColor = Color.LightSkyBlue;
            BorderBtn.Location = new Point(iconButtonQRcode.Location.X, iconButtonQRcode.Location.Y);
            BorderBtn.Visible = true;
            BorderBtn.BringToFront();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;

        }
        void GiaiMa()
        {
            Bitmap imgQRCode = (Bitmap)pictureBox1.Image;
            if (imgQRCode != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(imgQRCode);
                if (result != null)
                {
                    string qrText = result.Text;
                    string[] qrData = qrText.Split(':');
                    string tenNganHang = qrData[0];
                    string soTaiKhoan = qrData[1];
                    imgQRCode.Dispose();
                    timer1.Stop();
                    this.Close();
                    FormChuyenTien formchuyentien = new FormChuyenTien();
                    formchuyentien.qrcode = soTaiKhoan;
                    formchuyentien.nh = tenNganHang;
                    formchuyentien.id = id;
                    formchuyentien.Show();
                }
            }
        }
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap b = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = b;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
        }

        private void FormQRcode_Load(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GiaiMa();
        }


        private void iconButtonTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.id = id;
            form1.Show();
        }

        private void iconButtonChuyenTien_Click(object sender, EventArgs e)
        {
            this.Close();
            FormChuyenTien formchuyentien = new FormChuyenTien();
            formchuyentien.id = id;
            formchuyentien.Show();
        }

        private void iconButtonTietKiem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTietKiem formtietkiem = new FormTietKiem();
            formtietkiem.id = id;
            formtietkiem.Show();
        }

        private void iconButtonSaoKe_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSaoKe formsaoke = new FormSaoKe();
            formsaoke.id = id;
            formsaoke.Show();
        }
    }
}
