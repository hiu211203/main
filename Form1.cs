using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ZXing.Common;
using ZXing;

namespace BaiThucHanh3
{
    public partial class Form1 : Form
    {
        private Panel BorderBtn;
        public int id = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            BorderBtn = new Panel();
            BorderBtn.Size = new Size(78, 2);
            panelMenu.Controls.Add(BorderBtn);
            BorderBtn.BackColor = Color.LightSkyBlue;
            BorderBtn.Location = new Point(iconButtonTrangChu.Location.X, iconButtonTrangChu.Location.Y);
            BorderBtn.Visible = true;
            BorderBtn.BringToFront();
        }

        private void iconButtonChuyenTien_Click(object sender, EventArgs e)
        {
            FormChuyenTien formchuyentien = new FormChuyenTien();
            formchuyentien.id = id;
            formchuyentien.Show();
            this.Close();
        }

        private void iconButtonQRcode_Click(object sender, EventArgs e)
        {
            FormQRcode formqrcode = new FormQRcode();
            formqrcode.id = id;
            formqrcode.Show();
            this.Close();
        }

        private void iconButtonTietKiem_Click(object sender, EventArgs e)
        {
            FormTietKiem formtietkiem = new FormTietKiem();
            formtietkiem.id = id;
            formtietkiem.Show();
            this.Close();
        }

        private void iconButtonSaoKe_Click(object sender, EventArgs e)
        {
            FormSaoKe formsaoke = new FormSaoKe();
            formsaoke.id = id;
            formsaoke.Show();
            this.Close();
        }

        private void iconPictureBoxThongBao_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongBao formThongBao = new FormThongBao();
            formThongBao.id = id;
            formThongBao.ShowDialog();
            this.Show();
        }

        private void iconButtonAnSoDu_Click(object sender, EventArgs e)
        {
            if (iconButtonAnSoDu.IconChar == IconChar.Eye)
            {
                iconButtonAnSoDu.IconChar = IconChar.EyeSlash;
                textBoxSoDu.PasswordChar = default(char);
            }
            else
            {
                iconButtonAnSoDu.IconChar = IconChar.Eye;
                textBoxSoDu.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSoTaiKhoan.Text = id.ToString();
            string sql = "select HoVaTen, SoDu, TaiKhoan, Email from NguoiDung where SoDienThoai = @UserID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                labelTenTaiKhoan.Text = reader["HoVaTen"].ToString();
                textBoxSoDu.Text =  string.Format("{0:#,##0} VND", reader["SoDu"]);
                textBoxTenTaiKhoan.Text = reader["TaiKhoan"].ToString();
                textBoxEmail.Text = reader["Email"].ToString();
            }
            else
            {
                MessageBox.Show("Sai");
            }    
            reader.Close();
        }

        private void iconButtonDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
        }
        Bitmap qrCodeImage;
        private void GenerateQRCode(string text)
        {
            try
            {
                BarcodeWriter barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                qrCodeImage = barcodeWriter.Write(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void XemChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            string text = "HK Bank:" + id;
            GenerateQRCode(text);
            pictureBox1.Image = qrCodeImage;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void iconButtonDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachTietKiem formDanhSachTietKiem = new FormDanhSachTietKiem();
            formDanhSachTietKiem.id = id;
            formDanhSachTietKiem.ShowDialog();
            this.Show();
        }
    }
}
