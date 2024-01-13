using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace BaiThucHanh3
{
    public partial class FormSaoKe : Form
    {
        private System.Windows.Forms.Panel BorderBtn;
        public int id = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
        public FormSaoKe()
        {
            InitializeComponent();
            BorderBtn = new System.Windows.Forms.Panel();
            BorderBtn.Size = new Size(78, 2);
            panelMenu.Controls.Add(BorderBtn);
            BorderBtn.BackColor = Color.LightSkyBlue;
            BorderBtn.Location = new Point(iconButtonSaoKe.Location.X, iconButtonSaoKe.Location.Y);
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

        private void iconButtonTietKiem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTietKiem formtietkiem = new FormTietKiem();
            formtietkiem.id = id;
            formtietkiem.Show();
        }
        int yOffset = 0;
        void add(string Mess, string Mess1, string Mess2)
        {
            UserControlSaoKe use = new UserControlSaoKe(Mess, Mess1, Mess2);
            use.Location = new Point(0, yOffset);
            yOffset += use.Height + 5; // 5 là khoảng cách giữa các UserControl
            panelSaoKe.Controls.Add(use);

        }

        string sotien;
        private void FormSaoKe_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from GiaoDich where TaiKhoanGui = '" + id + "' or TaiKhoanNhan = '" + id + "' ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(3);
                string ngay = reader.GetDateTime(2).ToString();
                string[] dates = ngay.ToString().Split(' ');
                if (reader.GetInt32(4) == id)
                {
                    sotien = "- " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                }
                else
                {
                    sotien = "+ " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                }

                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }


        private void iconButtonTatCa_Click(object sender, EventArgs e)
        {
            yOffset = 0;
            panelSaoKe.Controls.Clear();
            DateTime Date1 = dateTimePicker1.Value;
            DateTime Date2 = dateTimePicker2.Value;
            string formattedDate1 = Date1.ToString("yyyy-MM-dd");
            string formattedDate2 = Date2.ToString("yyyy-MM-dd");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where NgayGiaoDich between '" + formattedDate1 + "' and '" + formattedDate2 + "'  and  ( TaiKhoanGui = '" + id + "' or TaiKhoanNhan = '" + id + "') ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(3);
                string ngay = reader.GetDateTime(2).ToString();
                string[] dates = ngay.ToString().Split(' ');
                if (reader.GetInt32(4) == id)
                {
                    sotien = "- " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                }
                else
                {
                    sotien = "+ " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                }

                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }

        private void iconButtonTienRa_Click(object sender, EventArgs e)
        {
            yOffset = 0;
            panelSaoKe.Controls.Clear();
            DateTime Date1 = dateTimePicker1.Value;
            DateTime Date2 = dateTimePicker2.Value;
            string formattedDate1 = Date1.ToString("yyyy-MM-dd");
            string formattedDate2 = Date2.ToString("yyyy-MM-dd");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where NgayGiaoDich between '" + formattedDate1 + "' and '" + formattedDate2 + "'  and  TaiKhoanGui = '" + id + "' ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(3);
                string ngay = reader.GetDateTime(2).ToString();
                string[] dates = ngay.ToString().Split(' ');
                sotien = "- " + string.Format("{0:#,##0} VND", reader.GetInt32(1));

                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }

        private void iconButtonTienVao_Click(object sender, EventArgs e)
        {
            yOffset = 0;
            panelSaoKe.Controls.Clear();
            DateTime Date1 = dateTimePicker1.Value;
            DateTime Date2 = dateTimePicker2.Value;
            string formattedDate1 = Date1.ToString("yyyy-MM-dd");
            string formattedDate2 = Date2.ToString("yyyy-MM-dd");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where NgayGiaoDich between '" + formattedDate1 + "' and '" + formattedDate2 + "'  and  TaiKhoanNhan = '" + id + "' ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(3);
                string ngay = reader.GetDateTime(2).ToString();
                string[] dates = ngay.ToString().Split(' ');
                sotien = "+ " + string.Format("{0:#,##0} VND", reader.GetInt32(1));

                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }

        private void iconButtonChart_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Visible = true;
            chart1.Visible = true;
            iconButtonTatCa.Visible = false;
            iconButtonTienRa.Visible = false;
            iconButtonTienVao.Visible = false;
            iconButtonChart.Visible = false;
            panelSaoKe.Visible = false;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where TaiKhoanGui = '" + id + "' or TaiKhoanNhan = '" + id + "' ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> ngays = new List<string>();
            List<int> sotiennhan = new List<int>();
            while (reader.Read())
            {
                string h = reader.GetDateTime(2).ToString();
                if (ngays.Contains(h) == true)
                {
                    int index = ngays.IndexOf(h);
                    if (reader.GetInt32(4) == id)
                    {
                        sotiennhan[index] = sotiennhan[index] - reader.GetInt32(1);
                    }
                    else
                    {
                        sotiennhan[index] = sotiennhan[index] + reader.GetInt32(1);
                    }
                }
                else
                {
                    ngays.Add(reader.GetDateTime(2).ToString());
                    if (reader.GetInt32(4) == id)
                    {
                        sotiennhan.Add(0 - reader.GetInt32(1));
                    }
                    else
                    {
                        sotiennhan.Add(reader.GetInt32(1));
                    }
                }
            }
            reader.Close();
            this.chart1.Titles.Add("Sao kê số tiền chuyển");

            // Add series.
            for (int i = 0; i < ngays.Count; i++)
            {
                Series series = this.chart1.Series.Add(ngays[i]);
                series.Points.Add(sotiennhan[i]);
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Visible = false;
            chart1.Visible = false;
            iconButtonTatCa.Visible = true;
            iconButtonTienRa.Visible = true;
            iconButtonTienVao.Visible = true;
            iconButtonChart.Visible = true;
            panelSaoKe.Visible = true;

        }
    }
}
