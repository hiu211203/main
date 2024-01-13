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
using System.Net;
using System.Net.Mail;

namespace BaiThucHanh3
{
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
            groupBox1.Visible = true;
            textBoxSoDienThoai.Visible = true;
            groupBox1.BringToFront();
        }

        private void iconButtonTroVeDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SendNotificationEmail(string recipientEmail, string newPassword)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("hieu211203@gmail.com");
                mail.To.Add(recipientEmail);
                mail.Subject = "Thông báo: Mật khẩu đã được thay đổi";
                mail.Body = $"Mật khẩu của bạn đã được thay đổi thành: {newPassword}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("21520853@gm.uit.edu.vn", "Hiu211203!!!!!");
                smtp.Send(mail);
            }
        }
        private void iconButtonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Visible == true)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
                try
                {
                    conn.Open();
                    string email = textBoxEmail.Text;
                    string sdt = textBoxSoDienThoai.Text;
                    string sql = "select *from NguoiDung where Email = '" + email + "' and SoDienThoai = '" + sdt + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read() == true)
                    {
                        groupBoxMatKhauMoi.Visible = true;
                        groupBoxNhapLaiMatKhau.Visible = true;
                        textBoxMatKhauMoi.Visible = true;
                        textBoxNhapLaiMatKhau.Visible = true;
                        groupBox1.Visible = false;
                        textBoxSoDienThoai.Visible = false;
                        groupBoxEmail.Visible = false;
                        textBoxEmail.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại");
                    }
                    data.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
            else
            {
                string password = textBoxMatKhauMoi.Text;
                string passworda = textBoxNhapLaiMatKhau.Text;
                string email = textBoxEmail.Text;
                string sdt = textBoxSoDienThoai.Text;
                if (password == passworda) 
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
                    string query = "UPDATE NguoiDung SET MatKhau = @NewMatKhau WHERE Email = @Email and SoDienThoai = @SoDienThoai";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@NewMatKhau", password);
                    command.Parameters.AddWithValue("@SoDienThoai", sdt);

                    try
                    {
                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            SendNotificationEmail(email, password);
                            MessageBox.Show("Đổi mật khẩu thành công");
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Đổi thất bại");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin điền sai");
                }
            }
        }
        private void ClearTextBoxes()
        {
            textBoxEmail.Text = "";
            textBoxMatKhauMoi.Text = "";
            textBoxNhapLaiMatKhau.Text = "";
            textBoxSoDienThoai.Text = "";
            groupBoxMatKhauMoi.Visible = false;
            groupBoxNhapLaiMatKhau.Visible = false;
            textBoxMatKhauMoi.Visible = false;
            textBoxNhapLaiMatKhau.Visible = false;
            groupBox1.Visible = true;
            textBoxSoDienThoai.Visible = true;
            groupBoxEmail.Visible = true;
            textBoxEmail.Visible = true;
        }
    }
}
