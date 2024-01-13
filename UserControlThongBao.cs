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
    public partial class UserControlThongBao : UserControl
    {
        public string id;
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-B8F38DK3\SQLEXPRESS;Initial Catalog=NganHang;Integrated Security=True");
        public UserControlThongBao(string Mess, Boolean ktt)
        {
            InitializeComponent();
            textBox1.Text = Mess;
            if (ktt == true) 
            {
                textBox1.ForeColor = Color.DimGray;
            }
            else
            {
                textBox1.ForeColor = Color.Orange;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryGui = "UPDATE GiaoDich SET CheckXem = @Amount WHERE IDGiaoDich = @NguoiGuiID";
            using (SqlCommand commandGui = new SqlCommand(queryGui, conn))
            {
                commandGui.Parameters.AddWithValue("@Amount", true);
                commandGui.Parameters.AddWithValue("@NguoiGuiID", id);
                commandGui.ExecuteNonQuery();
            }
            textBox1.ForeColor = Color.DimGray;
        }
    }
}
