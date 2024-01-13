namespace BaiThucHanh3
{
    partial class FormTietKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconButtonHoanTat = new FontAwesome.Sharp.IconButton();
            this.groupBoxHinhThucTraLai = new System.Windows.Forms.GroupBox();
            this.comboBoxHinhThucTraLai = new System.Windows.Forms.ComboBox();
            this.groupBoxSoTienGui = new System.Windows.Forms.GroupBox();
            this.textBoxSoTienGui = new System.Windows.Forms.TextBox();
            this.groupBoxChonKyHan = new System.Windows.Forms.GroupBox();
            this.comboBoxChonKyHan = new System.Windows.Forms.ComboBox();
            this.groupBoxTaiKhoanNguon = new System.Windows.Forms.GroupBox();
            this.labelVND = new System.Windows.Forms.Label();
            this.labelTaiKhoanNguon = new System.Windows.Forms.Label();
            this.comboBoxTaiKhoanNguon = new System.Windows.Forms.ComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonTietKiem = new FontAwesome.Sharp.IconButton();
            this.iconButtonSaoKe = new FontAwesome.Sharp.IconButton();
            this.iconButtonTrangChu = new FontAwesome.Sharp.IconButton();
            this.iconButtonChuyenTien = new FontAwesome.Sharp.IconButton();
            this.iconButtonQRcode = new FontAwesome.Sharp.IconButton();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.labelTren = new System.Windows.Forms.Label();
            this.groupBoxMucLaiSuat = new System.Windows.Forms.GroupBox();
            this.textBoxMucLaiSuat = new System.Windows.Forms.TextBox();
            this.groupBoxHinhThucTraLai.SuspendLayout();
            this.groupBoxSoTienGui.SuspendLayout();
            this.groupBoxChonKyHan.SuspendLayout();
            this.groupBoxTaiKhoanNguon.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTheme.SuspendLayout();
            this.groupBoxMucLaiSuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonHoanTat
            // 
            this.iconButtonHoanTat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonHoanTat.FlatAppearance.BorderSize = 0;
            this.iconButtonHoanTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonHoanTat.ForeColor = System.Drawing.Color.White;
            this.iconButtonHoanTat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonHoanTat.IconColor = System.Drawing.Color.Black;
            this.iconButtonHoanTat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHoanTat.Location = new System.Drawing.Point(135, 640);
            this.iconButtonHoanTat.Name = "iconButtonHoanTat";
            this.iconButtonHoanTat.Size = new System.Drawing.Size(143, 30);
            this.iconButtonHoanTat.TabIndex = 31;
            this.iconButtonHoanTat.Text = "Hoàn tất";
            this.iconButtonHoanTat.UseVisualStyleBackColor = false;
            this.iconButtonHoanTat.Click += new System.EventHandler(this.iconButtonHoanTat_Click);
            // 
            // groupBoxHinhThucTraLai
            // 
            this.groupBoxHinhThucTraLai.Controls.Add(this.comboBoxHinhThucTraLai);
            this.groupBoxHinhThucTraLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxHinhThucTraLai.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxHinhThucTraLai.Location = new System.Drawing.Point(24, 541);
            this.groupBoxHinhThucTraLai.Name = "groupBoxHinhThucTraLai";
            this.groupBoxHinhThucTraLai.Size = new System.Drawing.Size(374, 65);
            this.groupBoxHinhThucTraLai.TabIndex = 27;
            this.groupBoxHinhThucTraLai.TabStop = false;
            this.groupBoxHinhThucTraLai.Text = "Hình thức trả lãi";
            // 
            // comboBoxHinhThucTraLai
            // 
            this.comboBoxHinhThucTraLai.FormattingEnabled = true;
            this.comboBoxHinhThucTraLai.Items.AddRange(new object[] {
            "Không quay vòng",
            "Tự động quay vòng gốc",
            "Tự động quay vòng gốc và lãi"});
            this.comboBoxHinhThucTraLai.Location = new System.Drawing.Point(16, 25);
            this.comboBoxHinhThucTraLai.Name = "comboBoxHinhThucTraLai";
            this.comboBoxHinhThucTraLai.Size = new System.Drawing.Size(340, 28);
            this.comboBoxHinhThucTraLai.TabIndex = 2;
            // 
            // groupBoxSoTienGui
            // 
            this.groupBoxSoTienGui.Controls.Add(this.textBoxSoTienGui);
            this.groupBoxSoTienGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxSoTienGui.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxSoTienGui.Location = new System.Drawing.Point(24, 452);
            this.groupBoxSoTienGui.Name = "groupBoxSoTienGui";
            this.groupBoxSoTienGui.Size = new System.Drawing.Size(374, 65);
            this.groupBoxSoTienGui.TabIndex = 28;
            this.groupBoxSoTienGui.TabStop = false;
            this.groupBoxSoTienGui.Text = "Số tiền";
            // 
            // textBoxSoTienGui
            // 
            this.textBoxSoTienGui.Location = new System.Drawing.Point(16, 25);
            this.textBoxSoTienGui.Name = "textBoxSoTienGui";
            this.textBoxSoTienGui.Size = new System.Drawing.Size(340, 27);
            this.textBoxSoTienGui.TabIndex = 2;
            // 
            // groupBoxChonKyHan
            // 
            this.groupBoxChonKyHan.Controls.Add(this.comboBoxChonKyHan);
            this.groupBoxChonKyHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxChonKyHan.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxChonKyHan.Location = new System.Drawing.Point(24, 279);
            this.groupBoxChonKyHan.Name = "groupBoxChonKyHan";
            this.groupBoxChonKyHan.Size = new System.Drawing.Size(374, 65);
            this.groupBoxChonKyHan.TabIndex = 30;
            this.groupBoxChonKyHan.TabStop = false;
            this.groupBoxChonKyHan.Text = "Chọn kỳ hạn gửi";
            // 
            // comboBoxChonKyHan
            // 
            this.comboBoxChonKyHan.FormattingEnabled = true;
            this.comboBoxChonKyHan.Items.AddRange(new object[] {
            "1 tháng",
            "3 tháng",
            "6 tháng",
            "12 tháng"});
            this.comboBoxChonKyHan.Location = new System.Drawing.Point(16, 25);
            this.comboBoxChonKyHan.Name = "comboBoxChonKyHan";
            this.comboBoxChonKyHan.Size = new System.Drawing.Size(340, 28);
            this.comboBoxChonKyHan.TabIndex = 1;
            this.comboBoxChonKyHan.SelectedIndexChanged += new System.EventHandler(this.comboBoxChonKyHan_SelectedIndexChanged);
            // 
            // groupBoxTaiKhoanNguon
            // 
            this.groupBoxTaiKhoanNguon.Controls.Add(this.labelVND);
            this.groupBoxTaiKhoanNguon.Controls.Add(this.labelTaiKhoanNguon);
            this.groupBoxTaiKhoanNguon.Controls.Add(this.comboBoxTaiKhoanNguon);
            this.groupBoxTaiKhoanNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxTaiKhoanNguon.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxTaiKhoanNguon.Location = new System.Drawing.Point(24, 131);
            this.groupBoxTaiKhoanNguon.Name = "groupBoxTaiKhoanNguon";
            this.groupBoxTaiKhoanNguon.Size = new System.Drawing.Size(374, 109);
            this.groupBoxTaiKhoanNguon.TabIndex = 32;
            this.groupBoxTaiKhoanNguon.TabStop = false;
            this.groupBoxTaiKhoanNguon.Text = "Tài khoản nguồn";
            // 
            // labelVND
            // 
            this.labelVND.AutoSize = true;
            this.labelVND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelVND.ForeColor = System.Drawing.Color.DimGray;
            this.labelVND.Location = new System.Drawing.Point(250, 70);
            this.labelVND.Name = "labelVND";
            this.labelVND.Size = new System.Drawing.Size(48, 22);
            this.labelVND.TabIndex = 2;
            this.labelVND.Text = "VND";
            // 
            // labelTaiKhoanNguon
            // 
            this.labelTaiKhoanNguon.AutoSize = true;
            this.labelTaiKhoanNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTaiKhoanNguon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTaiKhoanNguon.Location = new System.Drawing.Point(50, 70);
            this.labelTaiKhoanNguon.Name = "labelTaiKhoanNguon";
            this.labelTaiKhoanNguon.Size = new System.Drawing.Size(110, 22);
            this.labelTaiKhoanNguon.TabIndex = 1;
            this.labelTaiKhoanNguon.Text = "100,000,000";
            // 
            // comboBoxTaiKhoanNguon
            // 
            this.comboBoxTaiKhoanNguon.FormattingEnabled = true;
            this.comboBoxTaiKhoanNguon.Location = new System.Drawing.Point(16, 27);
            this.comboBoxTaiKhoanNguon.Name = "comboBoxTaiKhoanNguon";
            this.comboBoxTaiKhoanNguon.Size = new System.Drawing.Size(340, 28);
            this.comboBoxTaiKhoanNguon.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.iconButtonTietKiem);
            this.panelMenu.Controls.Add(this.iconButtonSaoKe);
            this.panelMenu.Controls.Add(this.iconButtonTrangChu);
            this.panelMenu.Controls.Add(this.iconButtonChuyenTien);
            this.panelMenu.Controls.Add(this.iconButtonQRcode);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 710);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(420, 90);
            this.panelMenu.TabIndex = 33;
            // 
            // iconButtonTietKiem
            // 
            this.iconButtonTietKiem.FlatAppearance.BorderSize = 0;
            this.iconButtonTietKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTietKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTietKiem.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonTietKiem.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconButtonTietKiem.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonTietKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTietKiem.IconSize = 35;
            this.iconButtonTietKiem.Location = new System.Drawing.Point(255, 8);
            this.iconButtonTietKiem.Name = "iconButtonTietKiem";
            this.iconButtonTietKiem.Size = new System.Drawing.Size(78, 76);
            this.iconButtonTietKiem.TabIndex = 2;
            this.iconButtonTietKiem.Text = "Tiết kiệm";
            this.iconButtonTietKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonTietKiem.UseVisualStyleBackColor = true;
            // 
            // iconButtonSaoKe
            // 
            this.iconButtonSaoKe.FlatAppearance.BorderSize = 0;
            this.iconButtonSaoKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSaoKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonSaoKe.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonSaoKe.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.iconButtonSaoKe.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonSaoKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaoKe.IconSize = 35;
            this.iconButtonSaoKe.Location = new System.Drawing.Point(339, 8);
            this.iconButtonSaoKe.Name = "iconButtonSaoKe";
            this.iconButtonSaoKe.Size = new System.Drawing.Size(78, 76);
            this.iconButtonSaoKe.TabIndex = 4;
            this.iconButtonSaoKe.Text = "Sao kê";
            this.iconButtonSaoKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonSaoKe.UseVisualStyleBackColor = true;
            this.iconButtonSaoKe.Click += new System.EventHandler(this.iconButtonSaoKe_Click);
            // 
            // iconButtonTrangChu
            // 
            this.iconButtonTrangChu.FlatAppearance.BorderSize = 0;
            this.iconButtonTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTrangChu.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonTrangChu.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButtonTrangChu.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTrangChu.IconSize = 35;
            this.iconButtonTrangChu.Location = new System.Drawing.Point(3, 8);
            this.iconButtonTrangChu.Name = "iconButtonTrangChu";
            this.iconButtonTrangChu.Size = new System.Drawing.Size(78, 76);
            this.iconButtonTrangChu.TabIndex = 0;
            this.iconButtonTrangChu.Text = "Trang chủ";
            this.iconButtonTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonTrangChu.UseVisualStyleBackColor = true;
            this.iconButtonTrangChu.Click += new System.EventHandler(this.iconButtonTrangChu_Click);
            // 
            // iconButtonChuyenTien
            // 
            this.iconButtonChuyenTien.FlatAppearance.BorderSize = 0;
            this.iconButtonChuyenTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChuyenTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonChuyenTien.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonChuyenTien.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.iconButtonChuyenTien.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonChuyenTien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChuyenTien.IconSize = 35;
            this.iconButtonChuyenTien.Location = new System.Drawing.Point(87, 8);
            this.iconButtonChuyenTien.Name = "iconButtonChuyenTien";
            this.iconButtonChuyenTien.Size = new System.Drawing.Size(78, 76);
            this.iconButtonChuyenTien.TabIndex = 1;
            this.iconButtonChuyenTien.Text = "Chuyển tiền";
            this.iconButtonChuyenTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonChuyenTien.UseVisualStyleBackColor = true;
            this.iconButtonChuyenTien.Click += new System.EventHandler(this.iconButtonChuyenTien_Click);
            // 
            // iconButtonQRcode
            // 
            this.iconButtonQRcode.FlatAppearance.BorderSize = 0;
            this.iconButtonQRcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQRcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonQRcode.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonQRcode.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.iconButtonQRcode.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonQRcode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQRcode.IconSize = 35;
            this.iconButtonQRcode.Location = new System.Drawing.Point(171, 8);
            this.iconButtonQRcode.Name = "iconButtonQRcode";
            this.iconButtonQRcode.Size = new System.Drawing.Size(78, 76);
            this.iconButtonQRcode.TabIndex = 3;
            this.iconButtonQRcode.Text = "QR code";
            this.iconButtonQRcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonQRcode.UseVisualStyleBackColor = true;
            this.iconButtonQRcode.Click += new System.EventHandler(this.iconButtonQRcode_Click);
            // 
            // panelTheme
            // 
            this.panelTheme.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTheme.Controls.Add(this.labelTren);
            this.panelTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTheme.Location = new System.Drawing.Point(0, 0);
            this.panelTheme.Name = "panelTheme";
            this.panelTheme.Size = new System.Drawing.Size(420, 85);
            this.panelTheme.TabIndex = 34;
            // 
            // labelTren
            // 
            this.labelTren.AutoSize = true;
            this.labelTren.BackColor = System.Drawing.Color.Transparent;
            this.labelTren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTren.ForeColor = System.Drawing.Color.White;
            this.labelTren.Location = new System.Drawing.Point(141, 30);
            this.labelTren.Name = "labelTren";
            this.labelTren.Size = new System.Drawing.Size(122, 29);
            this.labelTren.TabIndex = 7;
            this.labelTren.Text = "Tiết kiệm";
            // 
            // groupBoxMucLaiSuat
            // 
            this.groupBoxMucLaiSuat.Controls.Add(this.textBoxMucLaiSuat);
            this.groupBoxMucLaiSuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxMucLaiSuat.ForeColor = System.Drawing.Color.DimGray;
            this.groupBoxMucLaiSuat.Location = new System.Drawing.Point(23, 367);
            this.groupBoxMucLaiSuat.Name = "groupBoxMucLaiSuat";
            this.groupBoxMucLaiSuat.Size = new System.Drawing.Size(374, 65);
            this.groupBoxMucLaiSuat.TabIndex = 35;
            this.groupBoxMucLaiSuat.TabStop = false;
            this.groupBoxMucLaiSuat.Text = "Mức lãi suất (%/năm)";
            // 
            // textBoxMucLaiSuat
            // 
            this.textBoxMucLaiSuat.Enabled = false;
            this.textBoxMucLaiSuat.Location = new System.Drawing.Point(16, 25);
            this.textBoxMucLaiSuat.Name = "textBoxMucLaiSuat";
            this.textBoxMucLaiSuat.Size = new System.Drawing.Size(340, 27);
            this.textBoxMucLaiSuat.TabIndex = 2;
            // 
            // FormTietKiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(420, 800);
            this.Controls.Add(this.groupBoxMucLaiSuat);
            this.Controls.Add(this.panelTheme);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.groupBoxTaiKhoanNguon);
            this.Controls.Add(this.iconButtonHoanTat);
            this.Controls.Add(this.groupBoxHinhThucTraLai);
            this.Controls.Add(this.groupBoxSoTienGui);
            this.Controls.Add(this.groupBoxChonKyHan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTietKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTietKiem";
            this.Load += new System.EventHandler(this.FormTietKiem_Load);
            this.groupBoxHinhThucTraLai.ResumeLayout(false);
            this.groupBoxSoTienGui.ResumeLayout(false);
            this.groupBoxSoTienGui.PerformLayout();
            this.groupBoxChonKyHan.ResumeLayout(false);
            this.groupBoxTaiKhoanNguon.ResumeLayout(false);
            this.groupBoxTaiKhoanNguon.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelTheme.ResumeLayout(false);
            this.panelTheme.PerformLayout();
            this.groupBoxMucLaiSuat.ResumeLayout(false);
            this.groupBoxMucLaiSuat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonHoanTat;
        private System.Windows.Forms.GroupBox groupBoxHinhThucTraLai;
        private System.Windows.Forms.GroupBox groupBoxSoTienGui;
        private System.Windows.Forms.TextBox textBoxSoTienGui;
        private System.Windows.Forms.GroupBox groupBoxChonKyHan;
        private System.Windows.Forms.ComboBox comboBoxChonKyHan;
        private System.Windows.Forms.GroupBox groupBoxTaiKhoanNguon;
        private System.Windows.Forms.Label labelVND;
        private System.Windows.Forms.Label labelTaiKhoanNguon;
        private System.Windows.Forms.ComboBox comboBoxTaiKhoanNguon;
        private System.Windows.Forms.ComboBox comboBoxHinhThucTraLai;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonTietKiem;
        private FontAwesome.Sharp.IconButton iconButtonSaoKe;
        private FontAwesome.Sharp.IconButton iconButtonTrangChu;
        private FontAwesome.Sharp.IconButton iconButtonChuyenTien;
        private FontAwesome.Sharp.IconButton iconButtonQRcode;
        private System.Windows.Forms.Panel panelTheme;
        private System.Windows.Forms.Label labelTren;
        private System.Windows.Forms.GroupBox groupBoxMucLaiSuat;
        private System.Windows.Forms.TextBox textBoxMucLaiSuat;
    }
}