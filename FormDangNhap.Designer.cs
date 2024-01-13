namespace BaiThucHanh3
{
    partial class FormDangNhap
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonTaoTaiKhoan = new FontAwesome.Sharp.IconButton();
            this.labelQuenMatKhau = new System.Windows.Forms.Label();
            this.iconButtonDangNhap = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMatKhau);
            this.groupBox2.Location = new System.Drawing.Point(58, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 57);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mật khẩu";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(6, 21);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(290, 27);
            this.textBoxMatKhau.TabIndex = 8;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTenTaiKhoan);
            this.groupBox1.Location = new System.Drawing.Point(58, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 57);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // textBoxTenTaiKhoan
            // 
            this.textBoxTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenTaiKhoan.Location = new System.Drawing.Point(7, 21);
            this.textBoxTenTaiKhoan.Name = "textBoxTenTaiKhoan";
            this.textBoxTenTaiKhoan.Size = new System.Drawing.Size(290, 27);
            this.textBoxTenTaiKhoan.TabIndex = 7;
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
            this.label1.TabIndex = 20;
            this.label1.Text = "HK Bank";
            // 
            // iconButtonTaoTaiKhoan
            // 
            this.iconButtonTaoTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonTaoTaiKhoan.FlatAppearance.BorderSize = 2;
            this.iconButtonTaoTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTaoTaiKhoan.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonTaoTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonTaoTaiKhoan.IconColor = System.Drawing.Color.Black;
            this.iconButtonTaoTaiKhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTaoTaiKhoan.Location = new System.Drawing.Point(65, 635);
            this.iconButtonTaoTaiKhoan.Name = "iconButtonTaoTaiKhoan";
            this.iconButtonTaoTaiKhoan.Size = new System.Drawing.Size(290, 35);
            this.iconButtonTaoTaiKhoan.TabIndex = 23;
            this.iconButtonTaoTaiKhoan.Text = "Tạo tài khoản mới";
            this.iconButtonTaoTaiKhoan.UseVisualStyleBackColor = false;
            this.iconButtonTaoTaiKhoan.Click += new System.EventHandler(this.iconButtonTaoTaiKhoan_Click);
            // 
            // labelQuenMatKhau
            // 
            this.labelQuenMatKhau.AutoSize = true;
            this.labelQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelQuenMatKhau.Location = new System.Drawing.Point(121, 465);
            this.labelQuenMatKhau.Name = "labelQuenMatKhau";
            this.labelQuenMatKhau.Size = new System.Drawing.Size(176, 20);
            this.labelQuenMatKhau.TabIndex = 22;
            this.labelQuenMatKhau.Text = "Bạn quên mật khẩu ư?";
            this.labelQuenMatKhau.Click += new System.EventHandler(this.labelQuenMatKhau_Click);
            // 
            // iconButtonDangNhap
            // 
            this.iconButtonDangNhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonDangNhap.FlatAppearance.BorderSize = 0;
            this.iconButtonDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonDangNhap.ForeColor = System.Drawing.Color.White;
            this.iconButtonDangNhap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDangNhap.IconColor = System.Drawing.Color.Black;
            this.iconButtonDangNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDangNhap.Location = new System.Drawing.Point(65, 408);
            this.iconButtonDangNhap.Name = "iconButtonDangNhap";
            this.iconButtonDangNhap.Size = new System.Drawing.Size(289, 35);
            this.iconButtonDangNhap.TabIndex = 21;
            this.iconButtonDangNhap.Text = "Đăng nhập";
            this.iconButtonDangNhap.UseVisualStyleBackColor = false;
            this.iconButtonDangNhap.Click += new System.EventHandler(this.iconButtonDangNhap_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonTaoTaiKhoan);
            this.Controls.Add(this.labelQuenMatKhau);
            this.Controls.Add(this.iconButtonDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(420, 800);
            this.MinimumSize = new System.Drawing.Size(420, 800);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonTaoTaiKhoan;
        private System.Windows.Forms.Label labelQuenMatKhau;
        private FontAwesome.Sharp.IconButton iconButtonDangNhap;
    }
}