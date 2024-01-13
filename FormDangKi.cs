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
using System.Windows.Markup;

namespace BaiThucHanh3
{
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
        }
        private void iconButtonTroVeDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonDangKy_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != null || textBoxSoDienThoai.Text != null || textBoxTaiKhoan.Text != null || textBoxMatKhau.Text != null || textBoxHoVaTen.Text != null)
            { 
                string email = textBoxEmail.Text;
                string phone = textBoxSoDienThoai.Text;
                string username = textBoxTaiKhoan.Text;
                string password = textBoxMatKhau.Text;
                string fullName = textBoxHoVaTen.Text;
                int amount = 500000;

                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
                string query = "INSERT INTO NguoiDung (Email, SoDienThoai, TaiKhoan, MatKhau, HoVaTen, SoDu) VALUES (@Email, @SoDienThoai, @TaiKhoan, @MatKhau, @HoVaTen, @SoDu)";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@SoDienThoai", phone);
                command.Parameters.AddWithValue("@TaiKhoan", username);
                command.Parameters.AddWithValue("@MatKhau", password);
                command.Parameters.AddWithValue("@HoVaTen", fullName);
                command.Parameters.AddWithValue("@SoDu", amount);

                try
                {
                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đăng kí thành công");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lưu thông tin");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
            }
        }
        private void ClearTextBoxes()
        {
            textBoxEmail.Text = "";
            textBoxSoDienThoai.Text = "";
            textBoxTaiKhoan.Text = "";
            textBoxMatKhau.Text = "";
            textBoxHoVaTen.Text = "";
        }
    }
}
