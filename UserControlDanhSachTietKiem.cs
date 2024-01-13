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
    public partial class UserControlDanhSachTietKiem : UserControl
    {
        public UserControlDanhSachTietKiem(string label1Text, string label2Text, string label3Text, string label4Text, string label5Text)
        {
            InitializeComponent();
            label1.Text = "ID TK: "+label1Text;
            label2.Text = "Ngày gửi: "+label2Text;
            label3.Text = "HTTL: "+label3Text;
            label4.Text = "Kỳ hạn: "+label4Text;
            label6.Text = label5Text;
        }
    }
}
