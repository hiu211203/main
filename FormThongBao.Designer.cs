namespace BaiThucHanh3
{
    partial class FormThongBao
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
            this.iconButtonDaXem = new FontAwesome.Sharp.IconButton();
            this.iconButtonChuaXem = new FontAwesome.Sharp.IconButton();
            this.iconButtonTatCa = new FontAwesome.Sharp.IconButton();
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
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(147, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông báo";
            // 
            // iconButtonDaXem
            // 
            this.iconButtonDaXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDaXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonDaXem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonDaXem.IconColor = System.Drawing.Color.Black;
            this.iconButtonDaXem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDaXem.Location = new System.Drawing.Point(117, 110);
            this.iconButtonDaXem.Name = "iconButtonDaXem";
            this.iconButtonDaXem.Size = new System.Drawing.Size(90, 30);
            this.iconButtonDaXem.TabIndex = 1;
            this.iconButtonDaXem.Text = "Đã xem";
            this.iconButtonDaXem.UseVisualStyleBackColor = true;
            this.iconButtonDaXem.Click += new System.EventHandler(this.iconButtonDaXem_Click);
            // 
            // iconButtonChuaXem
            // 
            this.iconButtonChuaXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChuaXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonChuaXem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonChuaXem.IconColor = System.Drawing.Color.Black;
            this.iconButtonChuaXem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChuaXem.Location = new System.Drawing.Point(213, 110);
            this.iconButtonChuaXem.Name = "iconButtonChuaXem";
            this.iconButtonChuaXem.Size = new System.Drawing.Size(90, 30);
            this.iconButtonChuaXem.TabIndex = 2;
            this.iconButtonChuaXem.Text = "Chưa xem";
            this.iconButtonChuaXem.UseVisualStyleBackColor = true;
            this.iconButtonChuaXem.Click += new System.EventHandler(this.iconButtonChuaXem_Click);
            // 
            // iconButtonTatCa
            // 
            this.iconButtonTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTatCa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonTatCa.IconColor = System.Drawing.Color.Black;
            this.iconButtonTatCa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTatCa.Location = new System.Drawing.Point(21, 110);
            this.iconButtonTatCa.Name = "iconButtonTatCa";
            this.iconButtonTatCa.Size = new System.Drawing.Size(90, 30);
            this.iconButtonTatCa.TabIndex = 3;
            this.iconButtonTatCa.Text = "Tất cả";
            this.iconButtonTatCa.UseVisualStyleBackColor = true;
            this.iconButtonTatCa.Click += new System.EventHandler(this.iconButtonTatCa_Click);
            // 
            // panelThongBao
            // 
            this.panelThongBao.AutoScroll = true;
            this.panelThongBao.Location = new System.Drawing.Point(21, 165);
            this.panelThongBao.Name = "panelThongBao";
            this.panelThongBao.Size = new System.Drawing.Size(375, 595);
            this.panelThongBao.TabIndex = 4;
            // 
            // FormThongBao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(420, 800);
            this.Controls.Add(this.panelThongBao);
            this.Controls.Add(this.iconButtonTatCa);
            this.Controls.Add(this.iconButtonChuaXem);
            this.Controls.Add(this.iconButtonDaXem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongBao";
            this.Load += new System.EventHandler(this.FormThongBao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonDaXem;
        private FontAwesome.Sharp.IconButton iconButtonChuaXem;
        private FontAwesome.Sharp.IconButton iconButtonTatCa;
        private System.Windows.Forms.Panel panelThongBao;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBack;
    }
}