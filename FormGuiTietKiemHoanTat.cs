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
    public partial class FormGuiTietKiemHoanTat : Form
    {
        public string kyhan;
        public string laisuat;
        public string sotien;
        public string httl;
        public string idtietkiem;
        public string ngaymo;
        public string lai;
        public string sodu;

        public FormGuiTietKiemHoanTat()
        {
            InitializeComponent();
        }

        private void FormGuiTietKiemHoanTat_Load(object sender, EventArgs e)
        {
            labelHinhThucTraLai.Text = httl;
            labelKyHanGui.Text = kyhan + " tháng";
            labelMaTietKiem.Text = idtietkiem;
            labelMucLaiSuat.Text = laisuat + "%/năm";
            labelNgayGiaoDich.Text = ngaymo;
            labelSoTien.Text = sotien;
            labelLaiDuDoan.Text = lai;
            labelSoDu.Text = sodu;
        }

        private void iconButtonThucHienGiaoDichMoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
