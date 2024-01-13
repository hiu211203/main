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
    public partial class FormDanhSachTietKiem : Form
    {
        public int id = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
        public FormDanhSachTietKiem()
        {
            InitializeComponent();
        }
        int yOffset = 0;
        void add(string Mess, string Mess1, string Mess2, string Mess3, string Mess4)
        {
            UserControlDanhSachTietKiem use = new UserControlDanhSachTietKiem(Mess, Mess1, Mess2, Mess3, Mess4);
            use.Location = new Point(0, yOffset);
            yOffset += use.Height + 5; // 5 là khoảng cách giữa các UserControl
            panelThongBao.Controls.Add(use);
        }

        private void FormDanhSachTietKiem_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from TietKiem where SoDienThoai = '" + id + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string idtk = reader.GetString(5);
                string ngay = reader.GetDateTime(6).ToString();
                string[] dates = ngay.ToString().Split(' ');
                string sotien = string.Format("{0:#,##0} VND", reader.GetInt32(3));
                string kyhan = reader.GetInt32(1).ToString();
                string httl = reader.GetString(4);

                add(idtk, dates[0], httl, kyhan, sotien);
            }
            reader.Close();
        }

        private void iconPictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
