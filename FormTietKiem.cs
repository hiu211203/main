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

namespace BaiThucHanh3
{
    public partial class FormTietKiem : Form
    {
        private Panel BorderBtn;
        public int id = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
        public FormTietKiem()
        {
            InitializeComponent();
            BorderBtn = new Panel();
            BorderBtn.Size = new Size(78, 2);
            panelMenu.Controls.Add(BorderBtn);
            BorderBtn.BackColor = Color.LightSkyBlue;
            BorderBtn.Location = new Point(iconButtonTietKiem.Location.X, iconButtonTietKiem.Location.Y);
            BorderBtn.Visible = true;
            BorderBtn.BringToFront();
            comboBoxChonKyHan.SelectedIndex = 0;
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

        private void iconButtonQRcode_Click(object sender, EventArgs e)
        {
            this.Close();
            FormQRcode formqrcode = new FormQRcode();
            formqrcode.id = id;
            formqrcode.Show();
        }

        private void iconButtonSaoKe_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSaoKe formsaoke = new FormSaoKe();
            formsaoke.id = id;
            formsaoke.Show();
        }
        int taikhoannguon;
        private void FormTietKiem_Load(object sender, EventArgs e)
        {
            string sql = "select SoDu from NguoiDung where SoDienThoai = @UserID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserID", id);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                taikhoannguon = (int)result;
                labelTaiKhoanNguon.Text = string.Format("{0:#,##0}", taikhoannguon);
                comboBoxTaiKhoanNguon.Items.Add(id.ToString());
                comboBoxTaiKhoanNguon.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Sai");
            }
        }

        float kh;

        private void comboBoxChonKyHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChonKyHan.SelectedIndex)
            {
                case 0:
                    kh = 3.1f;
                    textBoxMucLaiSuat.Text = "3.1";
                    break;
                case 1:
                    kh = 3.4f;
                    textBoxMucLaiSuat.Text = "3.4";
                    break;
                case 2:
                    kh = 4.6f;
                    textBoxMucLaiSuat.Text = "4.6";
                    break;
                case 3:
                    kh = 4.75f;
                    textBoxMucLaiSuat.Text = "4.75";
                    break;
                default:
                    textBoxMucLaiSuat.Text = ""; 
                    break;
            }
        }

        private void iconButtonHoanTat_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TietKiem (IDTietKiem, SoDienThoai, KyHan, LaiSuat, SoTien, HinhThucTraLai, NgayMo) VALUES (@IDTietKiem, @SoDienThoai, @KyHan, @LaiSuat, @SoTien, @HinhThucTraLai, @NgayMo)";

            int tiengui = int.Parse(textBoxSoTienGui.Text);
            Guid newID = Guid.NewGuid();
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            string idgiaodich = newID.ToString();
            string input = comboBoxChonKyHan.SelectedItem.ToString();
            string firstCharacter = input.Substring(0, input.IndexOf(' '));
            if (taikhoannguon >= tiengui)
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@IDTietKiem", idgiaodich);
                command.Parameters.AddWithValue("@SoDienThoai", id);
                command.Parameters.AddWithValue("@KyHan", int.Parse(firstCharacter));
                command.Parameters.AddWithValue("@LaiSuat", kh);
                command.Parameters.AddWithValue("@SoTien", tiengui);
                command.Parameters.AddWithValue("@HinhThucTraLai", comboBoxHinhThucTraLai.SelectedItem.ToString());
                command.Parameters.AddWithValue("@NgayMo", formattedDate);
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        string queryGui = "UPDATE NguoiDung SET SoDu = SoDu - @Amount WHERE SoDienThoai = @NguoiGuiID";
                        using (SqlCommand commandGui = new SqlCommand(queryGui, conn))
                        {
                            commandGui.Parameters.AddWithValue("@Amount", tiengui);
                            commandGui.Parameters.AddWithValue("@NguoiGuiID", id);
                            commandGui.ExecuteNonQuery();
                        }
                        labelTaiKhoanNguon.Text = string.Format("{0:#,##0}", taikhoannguon - tiengui);
                        float lai = tiengui + (tiengui * (kh / 12 / 100) * int.Parse(firstCharacter));
                        this.Hide();
                        FormGuiTietKiemHoanTat formGuiTietKiemHoanTat = new FormGuiTietKiemHoanTat();
                        formGuiTietKiemHoanTat.idtietkiem = idgiaodich;
                        formGuiTietKiemHoanTat.kyhan = firstCharacter;
                        formGuiTietKiemHoanTat.laisuat = textBoxMucLaiSuat.Text;
                        formGuiTietKiemHoanTat.sotien = string.Format("{0:#,##0} VND", tiengui);
                        formGuiTietKiemHoanTat.httl = comboBoxHinhThucTraLai.Text;
                        formGuiTietKiemHoanTat.ngaymo = formattedDate;
                        formGuiTietKiemHoanTat.lai = string.Format("{0:#,##0} VND", Convert.ToInt32(lai));
                        formGuiTietKiemHoanTat.sodu = string.Format("{0:#,##0} VND", taikhoannguon - tiengui);
                        formGuiTietKiemHoanTat.ShowDialog();
                        textBoxMucLaiSuat.Text = "";
                        textBoxSoTienGui.Text = "";
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
    }
}
