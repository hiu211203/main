namespace BaiThucHanh3
{
    partial class FormQRcode
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonTietKiem = new FontAwesome.Sharp.IconButton();
            this.iconButtonSaoKe = new FontAwesome.Sharp.IconButton();
            this.iconButtonTrangChu = new FontAwesome.Sharp.IconButton();
            this.iconButtonChuyenTien = new FontAwesome.Sharp.IconButton();
            this.iconButtonQRcode = new FontAwesome.Sharp.IconButton();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.labelTren = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.panelMenu.TabIndex = 8;
            // 
            // iconButtonTietKiem
            // 
            this.iconButtonTietKiem.FlatAppearance.BorderSize = 0;
            this.iconButtonTietKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTietKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTietKiem.ForeColor = System.Drawing.Color.DimGray;
            this.iconButtonTietKiem.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconButtonTietKiem.IconColor = System.Drawing.Color.DimGray;
            this.iconButtonTietKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTietKiem.IconSize = 35;
            this.iconButtonTietKiem.Location = new System.Drawing.Point(255, 8);
            this.iconButtonTietKiem.Name = "iconButtonTietKiem";
            this.iconButtonTietKiem.Size = new System.Drawing.Size(78, 76);
            this.iconButtonTietKiem.TabIndex = 2;
            this.iconButtonTietKiem.Text = "Tiết kiệm";
            this.iconButtonTietKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonTietKiem.UseVisualStyleBackColor = true;
            this.iconButtonTietKiem.Click += new System.EventHandler(this.iconButtonTietKiem_Click);
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
            this.iconButtonQRcode.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonQRcode.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.iconButtonQRcode.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonQRcode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQRcode.IconSize = 35;
            this.iconButtonQRcode.Location = new System.Drawing.Point(171, 8);
            this.iconButtonQRcode.Name = "iconButtonQRcode";
            this.iconButtonQRcode.Size = new System.Drawing.Size(78, 76);
            this.iconButtonQRcode.TabIndex = 3;
            this.iconButtonQRcode.Text = "QR code";
            this.iconButtonQRcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonQRcode.UseVisualStyleBackColor = true;
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
            this.panelTheme.TabIndex = 20;
            // 
            // labelTren
            // 
            this.labelTren.AutoSize = true;
            this.labelTren.BackColor = System.Drawing.Color.Transparent;
            this.labelTren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTren.ForeColor = System.Drawing.Color.White;
            this.labelTren.Location = new System.Drawing.Point(148, 30);
            this.labelTren.Name = "labelTren";
            this.labelTren.Size = new System.Drawing.Size(116, 29);
            this.labelTren.TabIndex = 7;
            this.labelTren.Text = "QR code";
            // 
            // FormQRcode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(420, 800);
            this.Controls.Add(this.panelTheme);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQRcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQRcode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FormQRcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTheme.ResumeLayout(false);
            this.panelTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonTietKiem;
        private FontAwesome.Sharp.IconButton iconButtonSaoKe;
        private FontAwesome.Sharp.IconButton iconButtonTrangChu;
        private FontAwesome.Sharp.IconButton iconButtonChuyenTien;
        private FontAwesome.Sharp.IconButton iconButtonQRcode;
        private System.Windows.Forms.Panel panelTheme;
        private System.Windows.Forms.Label labelTren;
    }
}