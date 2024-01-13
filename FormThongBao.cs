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
    public partial class FormThongBao : Form
    {
        public int id = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
        public FormThongBao()
        {
            InitializeComponent();
        }

        private void iconPictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int yOffset = 0;
        void add(string Mess, Boolean ktt, string idGD)
        {
            UserControlThongBao use = new UserControlThongBao(Mess,ktt);
            use.id = idGD;
            use.Location = new Point(0, yOffset);
            yOffset += use.Height + 5; // 5 là khoảng cách giữa các UserControl
            panelThongBao.Controls.Add(use);

        }
        string sotien;
        private void FormThongBao_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where TaiKhoanGui = '" + id + "' or TaiKhoanNhan = '" + id + "' ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string thongbao = "Số dư TK ";
                string nhan = reader.GetString(3);
                string ngay = reader.GetDateTime(2).ToString();
                string[] dates = ngay.ToString().Split(' ');
                if (reader.GetInt32(4) == id)
                {
                    string h = reader.GetInt32(5).ToString();
                    sotien = "- " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                    thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                }
                else
                {
                    string h = reader.GetInt32(4).ToString();
                    sotien = "+ " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                    thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                }
                Boolean ktt = reader.GetBoolean(6);
                string idGD = reader.GetString(0);
                add(thongbao,ktt,idGD);
            }
            reader.Close();
        }

        private void iconButtonTatCa_Click(object sender, EventArgs e)
        {
            yOffset = 0;
            panelThongBao.Controls.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where TaiKhoanGui = '" + id + "' or TaiKhoanNhan = '" + id + "' ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string thongbao = "Số dư TK ";
                string nhan = reader.GetString(3);
                string ngay = reader.GetDateTime(2).ToString();
                string[] dates = ngay.ToString().Split(' ');
                if (reader.GetInt32(4) == id)
                {
                    string h = reader.GetInt32(5).ToString();
                    sotien = "- " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                    thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                }
                else
                {
                    string h = reader.GetInt32(4).ToString();
                    sotien = "+ " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                    thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                }
                Boolean ktt = reader.GetBoolean(6);
                string idGD = reader.GetString(0);
                add(thongbao, ktt, idGD);
            }
            reader.Close();
        }

        private void iconButtonDaXem_Click(object sender, EventArgs e)
        {
            yOffset = 0;
            panelThongBao.Controls.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where TaiKhoanGui = '" + id + "' or TaiKhoanNhan = '" + id + "' ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Boolean ktt = reader.GetBoolean(6);
                if (ktt == true)
                {
                    string thongbao = "Số dư TK ";
                    string nhan = reader.GetString(3);
                    string ngay = reader.GetDateTime(2).ToString();
                    string[] dates = ngay.ToString().Split(' ');
                    if (reader.GetInt32(4) == id)
                    {
                        string h = reader.GetInt32(5).ToString();
                        sotien = "- " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                        thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                    }
                    else
                    {
                        string h = reader.GetInt32(4).ToString();
                        sotien = "+ " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                        thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                    }
                    string idGD = reader.GetString(0);
                    add(thongbao, ktt, idGD);
                }
            }
            reader.Close();
        }

        private void iconButtonChuaXem_Click(object sender, EventArgs e)
        {
            yOffset = 0;
            panelThongBao.Controls.Clear();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  * from GiaoDich where (TaiKhoanGui = '" + id + "' or TaiKhoanNhan = '" + id + "') ORDER BY NgayGiaoDich DESC";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Boolean ktt = reader.GetBoolean(6);
                if (ktt == false)
                {
                    string thongbao = "Số dư TK ";
                    string nhan = reader.GetString(3);
                    string ngay = reader.GetDateTime(2).ToString();
                    string[] dates = ngay.ToString().Split(' ');
                    if (reader.GetInt32(4) == id)
                    {
                        string h = reader.GetInt32(5).ToString();
                        sotien = "- " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                        thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                    }
                    else
                    {
                        string h = reader.GetInt32(4).ToString();
                        sotien = "+ " + string.Format("{0:#,##0} VND", reader.GetInt32(1));
                        thongbao = thongbao + id + " " + sotien + " lúc " + dates[0] + ". " + "Ref " + h + ". " + nhan;
                    }
                    string idGD = reader.GetString(0);
                    add(thongbao, ktt, idGD);
                }
            }
            reader.Close();
        }
    }
}
