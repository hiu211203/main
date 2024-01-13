namespace BaiThucHanh3
{
    partial class FormDanhSachTietKiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBoxBack = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelThongBao = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.iconPictureBoxBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 85);
            this.panel1.TabIndex = 1;
            // 
            // iconPictureBoxBack
            // 
            this.iconPictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconPictureBoxBack.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxBack.IconSize = 40;
            this.iconPictureBoxBack.Location = new System.Drawing.Point(21, 19);
            this.iconPictureBoxBack.Name = "iconPictureBoxBack";
            this.iconPictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBoxBack.TabIndex = 5;
            this.iconPictureBoxBack.TabStop = false;
            this.iconPictureBoxBack.Click += new System.EventHandler(this.iconPictureBoxBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản tiết kiệm";
            // 
            // panelThongBao
            // 
            this.panelThongBao.AutoScroll = true;
            this.panelThongBao.Location = new System.Drawing.Point(21, 143);
            this.panelThongBao.Name = "panelThongBao";
            this.panelThongBao.Size = new System.Drawing.Size(375, 595);
            this.panelThongBao.TabIndex = 5;
            // 
            // FormDanhSachTietKiem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(420, 800);
            this.Controls.Add(this.panelThongBao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachTietKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDanhSachTietKiem";
            this.Load += new System.EventHandler(this.FormDanhSachTietKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelThongBao;
    }
}