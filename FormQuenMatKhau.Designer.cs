namespace BaiThucHanh3
{
    partial class FormQuenMatKhau
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
            this.iconButtonTroVeDangNhap = new FontAwesome.Sharp.IconButton();
            this.labelQuenMatKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonXacNhan = new FontAwesome.Sharp.IconButton();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxMatKhauMoi = new System.Windows.Forms.GroupBox();
            this.textBoxMatKhauMoi = new System.Windows.Forms.TextBox();
            this.groupBoxNhapLaiMatKhau = new System.Windows.Forms.GroupBox();
            this.textBoxNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.groupBoxEmail.SuspendLayout();
            this.groupBoxMatKhauMoi.SuspendLayout();
            this.groupBoxNhapLaiMatKhau.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButtonTroVeDangNhap
            // 
            this.iconButtonTroVeDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonTroVeDangNhap.FlatAppearance.BorderSize = 2;
            this.iconButtonTroVeDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTroVeDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTroVeDangNhap.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonTroVeDangNhap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonTroVeDangNhap.IconColor = System.Drawing.Color.Black;
            this.iconButtonTroVeDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTroVeDangNhap.Location = new System.Drawing.Point(65, 635);
            this.iconButtonTroVeDangNhap.Name = "iconButtonTroVeDangNhap";
            this.iconButtonTroVeDangNhap.Size = new System.Drawing.Size(290, 35);
            this.iconButtonTroVeDangNhap.TabIndex = 29;
            this.iconButtonTroVeDangNhap.Text = "Trở về đăng nhập";
            this.iconButtonTroVeDangNhap.UseVisualStyleBackColor = false;
            this.iconButtonTroVeDangNhap.Click += new System.EventHandler(this.iconButtonTroVeDangNhap_Click);
            // 
            // labelQuenMatKhau
            // 
            this.labelQuenMatKhau.AutoSize = true;
            this.labelQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQuenMatKhau.Location = new System.Drawing.Point(120, 646);
            this.labelQuenMatKhau.Name = "labelQuenMatKhau";
            this.labelQuenMatKhau.Size = new System.Drawing.Size(0, 20);
            this.labelQuenMatKhau.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "HK Bank";
            // 
            // iconButtonXacNhan
            // 
            this.iconButtonXacNhan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonXacNhan.FlatAppearance.BorderSize = 0;
            this.iconButtonXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonXacNhan.ForeColor = System.Drawing.Color.White;
            this.iconButtonXacNhan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonXacNhan.IconColor = System.Drawing.Color.Black;
            this.iconButtonXacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonXacNhan.Location = new System.Drawing.Point(65, 418);
            this.iconButtonXacNhan.Name = "iconButtonXacNhan";
            this.iconButtonXacNhan.Size = new System.Drawing.Size(290, 35);
            this.iconButtonXacNhan.TabIndex = 25;
            this.iconButtonXacNhan.Text = "Xác nhận";
            this.iconButtonXacNhan.UseVisualStyleBackColor = false;
            this.iconButtonXacNhan.Click += new System.EventHandler(this.iconButtonXacNhan_Click);
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.textBoxEmail);
            this.groupBoxEmail.Location = new System.Drawing.Point(58, 336);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(304, 57);
            this.groupBoxEmail.TabIndex = 30;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxEmail.Location = new System.Drawing.Point(7, 21);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 27);
            this.textBoxEmail.TabIndex = 7;
            // 
            // groupBoxMatKhauMoi
            // 
            this.groupBoxMatKhauMoi.Controls.Add(this.textBoxMatKhauMoi);
            this.groupBoxMatKhauMoi.Location = new System.Drawing.Point(58, 258);
            this.groupBoxMatKhauMoi.Name = "groupBoxMatKhauMoi";
            this.groupBoxMatKhauMoi.Size = new System.Drawing.Size(304, 57);
            this.groupBoxMatKhauMoi.TabIndex = 31;
            this.groupBoxMatKhauMoi.TabStop = false;
            this.groupBoxMatKhauMoi.Text = "Nhập mật khẩu mới";
            this.groupBoxMatKhauMoi.Visible = false;
            // 
            // textBoxMatKhauMoi
            // 
            this.textBoxMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhauMoi.Location = new System.Drawing.Point(7, 21);
            this.textBoxMatKhauMoi.Name = "textBoxMatKhauMoi";
            this.textBoxMatKhauMoi.Size = new System.Drawing.Size(290, 27);
            this.textBoxMatKhauMoi.TabIndex = 7;
            // 
            // groupBoxNhapLaiMatKhau
            // 
            this.groupBoxNhapLaiMatKhau.Controls.Add(this.textBoxNhapLaiMatKhau);
            this.groupBoxNhapLaiMatKhau.Location = new System.Drawing.Point(58, 321);
            this.groupBoxNhapLaiMatKhau.Name = "groupBoxNhapLaiMatKhau";
            this.groupBoxNhapLaiMatKhau.Size = new System.Drawing.Size(304, 57);
            this.groupBoxNhapLaiMatKhau.TabIndex = 32;
            this.groupBoxNhapLaiMatKhau.TabStop = false;
            this.groupBoxNhapLaiMatKhau.Text = "Nhập lại mật khẩu";
            this.groupBoxNhapLaiMatKhau.Visible = false;
            // 
            // textBoxNhapLaiMatKhau
            // 
            this.textBoxNhapLaiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNhapLaiMatKhau.Location = new System.Drawing.Point(7, 21);
            this.textBoxNhapLaiMatKhau.Name = "textBoxNhapLaiMatKhau";
            this.textBoxNhapLaiMatKhau.Size = new System.Drawing.Size(290, 27);
            this.textBoxNhapLaiMatKhau.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSoDienThoai);
            this.groupBox1.Location = new System.Drawing.Point(58, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 57);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số điện thoại";
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(7, 21);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(290, 27);
            this.textBoxSoDienThoai.TabIndex = 7;
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 800);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxNhapLaiMatKhau);
            this.Controls.Add(this.groupBoxMatKhauMoi);
            this.Controls.Add(this.groupBoxEmail);
            this.Controls.Add(this.iconButtonTroVeDangNhap);
            this.Controls.Add(this.labelQuenMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonXacNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(420, 800);
            this.Name = "FormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuenMatKhau";
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.groupBoxMatKhauMoi.ResumeLayout(false);
            this.groupBoxMatKhauMoi.PerformLayout();
            this.groupBoxNhapLaiMatKhau.ResumeLayout(false);
            this.groupBoxNhapLaiMatKhau.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonTroVeDangNhap;
        private System.Windows.Forms.Label labelQuenMatKhau;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonXacNhan;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxMatKhauMoi;
        private System.Windows.Forms.TextBox textBoxMatKhauMoi;
        private System.Windows.Forms.GroupBox groupBoxNhapLaiMatKhau;
        private System.Windows.Forms.TextBox textBoxNhapLaiMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
    }
}