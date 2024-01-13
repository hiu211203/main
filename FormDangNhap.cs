using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BaiThucHanh3
{
    public partial class FormDangNhap : Form
    {
        public bool CheckDangNhap = false;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void iconButtonDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = textBoxTenTaiKhoan.Text;
                string mk = textBoxMatKhau.Text;
                string sql = "select SoDienThoai from NguoiDung where TaiKhoan = '"+tk+"' and MatKhau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    int hmm = int.Parse(result.ToString());
                    form1.id = hmm;
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void labelQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.ShowDialog();
            this.Show();
        }

        private void iconButtonTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKi formDangKi = new FormDangKi();
            formDangKi.ShowDialog();
            this.Show();
        }
    }
}
