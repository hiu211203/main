using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh3
{
    public partial class UserControlSaoKe : UserControl
    {
        public UserControlSaoKe(string label1Text, string label2Text, string label3Text)
        {
            InitializeComponent();
            label1.Text = label1Text;
            label2.Text = label2Text;
            label3.Text = label3Text;
            char firstChar = label3Text[0];
            if (firstChar == '-' )
            {
                label3.ForeColor = Color.Red;
            }
            else if ( firstChar == '+' )
            {
                label3.ForeColor = Color.Green;
            }
        }
    }
}
