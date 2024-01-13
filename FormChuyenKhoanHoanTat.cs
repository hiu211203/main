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
    public partial class FormChuyenKhoanHoanTat : Form
    {
        public string MaGiaoDich;
        public string TenNguoiHuongThu;
        public string IDNguoiHuongThu;
        public string NoiDung;
        public string NgayGiaoDich;
        public string SoTien;
        public string SoDu;
        public FormChuyenKhoanHoanTat()
        {
            InitializeComponent();
        }

        private void iconButtonThucHienGiaoDichMoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChuyenKhoanHoanTat_Load(object sender, EventArgs e)
        {
            labelMaGiaoDich.Text = MaGiaoDich;
            labelNgayGiaoDich.Text = NgayGiaoDich;
            labelNoiDungGiaoDich.Text = NoiDung;
            labelSoTien.Text = SoTien;
            labelTaiKhoanHuongThu.Text = IDNguoiHuongThu;
            labelTenNguoiHuongThu.Text = TenNguoiHuongThu;
            labelSoDu.Text = SoDu;
        }
    }
}
