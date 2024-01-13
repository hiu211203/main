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
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiThucHanh3
{
    public partial class FormChuyenTien : Form
    {
        private Panel BorderBtn;
        public int id = 0;
        public string qrcode = string.Empty;
        public string nh = string.Empty;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
        public FormChuyenTien()
        {
            InitializeComponent();
            BorderBtn = new Panel();
            BorderBtn.Size = new Size(78, 2);
            panelMenu.Controls.Add(BorderBtn);
            BorderBtn.BackColor = Color.LightSkyBlue;
            BorderBtn.Location = new Point(iconButtonChuyenTien.Location.X, iconButtonChuyenTien.Location.Y);
            BorderBtn.Visible = true;
            BorderBtn.BringToFront();
        }

        private void iconButtonTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.id = id;
            form1.Show();
        }

        private void iconButtonQRcode_Click(object sender, EventArgs e)
        {
            this.Close();
            FormQRcode formqrcode = new FormQRcode();
            formqrcode.id = id;
            formqrcode.Show();
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
        public int taikhoannguon = 0;
        private void FormChuyenTien_Load(object sender, EventArgs e)
        {
            string sql = "select SoDu from NguoiDung where SoDienThoai = @UserID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", id);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                taikhoannguon = (int)result;
                labelTaiKhoanNguon.Text = string.Format("{0:#,##0}", result);
                comboBoxTaiKhoanNguon.Items.Add(id.ToString());
                comboBoxTaiKhoanNguon.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Sai");
            }
            if(qrcode != string.Empty)
            {
                textBoxSoTaiKhoan.Text = qrcode;
                comboBoxNganHang.SelectedItem = nh;
                string sql1;
                if (comboBoxNganHang.SelectedIndex == 0)
                {
                    sql1 = "select HoVaTen from NguoiDung where SoDienThoai = @UserID";
                }
                else
                {
                    sql1 = "select HoVaTen from NguoiDungKhac where SoDienThoai = @UserID and NganHang = @NganHang";
                }
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@UserID", int.Parse(textBoxSoTaiKhoan.Text));
                cmd1.Parameters.AddWithValue("@NganHang", comboBoxNganHang.SelectedItem.ToString());
                object result1 = cmd1.ExecuteScalar();
                if (result1 != null && result1 != DBNull.Value)
                {
                    textBoxTenTaiKhoan.Text = result1.ToString();
                }
                else
                {
                    textBoxTenTaiKhoan.Text = "";
                }
            }
        }

        private void iconButtonHoanTat_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO GiaoDich (IDGiaoDich, TienGiaoDich, NgayGiaoDich, NoiDungGiaoDich, TaiKhoanGui, TaiKhoanNhan, CheckXem) VALUES (@IDGiaoDich, @TienGiaoDich, @NgayGiaoDich, @NoiDungGiaoDich, @TaiKhoanGui, @TaiKhoanNhan, @CheckXem)";

            int tiengui = int.Parse(textBoxSoTien.Text);
            Guid newID = Guid.NewGuid();
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            string idgiaodich = newID.ToString();
            int taikhoangui = id;
            int taikhoannhan = int.Parse(textBoxSoTaiKhoan.Text);
            if (taikhoannguon >= tiengui)
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDGiaoDich", idgiaodich);
                command.Parameters.AddWithValue("@TienGiaoDich", tiengui);
                command.Parameters.AddWithValue("@NgayGiaoDich", formattedDate);
                command.Parameters.AddWithValue("@NoiDungGiaoDich", textBoxNoiDungChuyenTien.Text);
                command.Parameters.AddWithValue("@TaiKhoanGui", taikhoangui);
                command.Parameters.AddWithValue("@TaiKhoanNhan", taikhoannhan);
                command.Parameters.AddWithValue("@CheckXem", false);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Trừ số tiền từ người gửi
                        string queryGui = "UPDATE NguoiDung SET SoDu = SoDu - @Amount WHERE SoDienThoai = @NguoiGuiID";
                        using (SqlCommand commandGui = new SqlCommand(queryGui, conn))
                        {
                            commandGui.Parameters.AddWithValue("@Amount", tiengui);
                            commandGui.Parameters.AddWithValue("@NguoiGuiID", id);
                            commandGui.ExecuteNonQuery();
                        }

                        // Cộng số tiền cho người nhận
                        string queryNhan;
                        if (comboBoxNganHang.SelectedIndex == 0)
                        {
                            queryNhan = "UPDATE NguoiDung SET SoDu = SoDu + @Amount WHERE SoDienThoai = @NguoiNhanID";
                        }
                        else
                        {
                            queryNhan = "UPDATE NguoiDungKhac SET SoDu = SoDu + @Amount WHERE SoDienThoai = @NguoiNhanID";
                        }
                        using (SqlCommand commandNhan = new SqlCommand(queryNhan, conn))
                        {
                            commandNhan.Parameters.AddWithValue("@Amount", tiengui);
                            commandNhan.Parameters.AddWithValue("@NguoiNhanID", int.Parse(textBoxSoTaiKhoan.Text));
                            commandNhan.ExecuteNonQuery();
                        }
                        labelTaiKhoanNguon.Text = string.Format("{0:#,##0}", taikhoannguon - tiengui);
                        this.Hide();
                        FormChuyenKhoanHoanTat formchuyenkhoanhoantat = new FormChuyenKhoanHoanTat();
                        formchuyenkhoanhoantat.MaGiaoDich = idgiaodich;
                        formchuyenkhoanhoantat.IDNguoiHuongThu = textBoxSoTaiKhoan.Text;
                        formchuyenkhoanhoantat.TenNguoiHuongThu = textBoxTenTaiKhoan.Text;
                        formchuyenkhoanhoantat.NgayGiaoDich = formattedDate;
                        formchuyenkhoanhoantat.NoiDung = textBoxNoiDungChuyenTien.Text;
                        formchuyenkhoanhoantat.SoTien = string.Format("{0:#,##0} VND", tiengui);
                        formchuyenkhoanhoantat.SoDu = string.Format("{0:#,##0} VND", taikhoannguon - tiengui);
                        formchuyenkhoanhoantat.ShowDialog();
                        textBoxNoiDungChuyenTien.Text = "";
                        textBoxSoTaiKhoan.Text = "";
                        textBoxTenTaiKhoan.Text = "";
                        textBoxSoTien.Text = "";
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hãy kiểm tra lại thông tin điền");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản nguồn không đủ");
            }
        }

        private void textBoxSoTaiKhoan_Leave(object sender, EventArgs e)
        {
            string sdt = textBoxSoTaiKhoan.Text;
            string sql;
            if (comboBoxNganHang.SelectedIndex == 0)
            {
                sql = "select HoVaTen from NguoiDung where SoDienThoai = @UserID";
            }
            else
            {
                sql = "select HoVaTen from NguoiDungKhac where SoDienThoai = @UserID and NganHang = @NganHang";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", int.Parse(sdt));
            cmd.Parameters.AddWithValue("@NganHang", comboBoxNganHang.SelectedItem.ToString());
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                textBoxTenTaiKhoan.Text = result.ToString();
            }
            else
            {
                textBoxTenTaiKhoan.Text = "";
            }
        }
    }
}
