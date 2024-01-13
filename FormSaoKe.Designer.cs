namespace BaiThucHanh3
{
    partial class FormSaoKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panelSaoKe = new System.Windows.Forms.Panel();
            this.iconButtonTatCa = new FontAwesome.Sharp.IconButton();
            this.iconButtonTienVao = new FontAwesome.Sharp.IconButton();
            this.iconButtonTienRa = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonTietKiem = new FontAwesome.Sharp.IconButton();
            this.iconButtonSaoKe = new FontAwesome.Sharp.IconButton();
            this.iconButtonTrangChu = new FontAwesome.Sharp.IconButton();
            this.iconButtonChuyenTien = new FontAwesome.Sharp.IconButton();
            this.iconButtonQRcode = new FontAwesome.Sharp.IconButton();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.labelTren = new System.Windows.Forms.Label();
            this.iconButtonChart = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMenu.SuspendLayout();
            this.panelTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(127, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lịch sử giao dịch";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(237, 162);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 27);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // panelSaoKe
            // 
            this.panelSaoKe.AutoScroll = true;
            this.panelSaoKe.Location = new System.Drawing.Point(23, 272);
            this.panelSaoKe.Name = "panelSaoKe";
            this.panelSaoKe.Size = new System.Drawing.Size(375, 411);
            this.panelSaoKe.TabIndex = 14;
            // 
            // iconButtonTatCa
            // 
            this.iconButtonTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTatCa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonTatCa.IconColor = System.Drawing.Color.Black;
            this.iconButtonTatCa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTatCa.Location = new System.Drawing.Point(23, 217);
            this.iconButtonTatCa.Name = "iconButtonTatCa";
            this.iconButtonTatCa.Size = new System.Drawing.Size(80, 30);
            this.iconButtonTatCa.TabIndex = 17;
            this.iconButtonTatCa.Text = "Tất cả";
            this.iconButtonTatCa.UseVisualStyleBackColor = true;
            this.iconButtonTatCa.Click += new System.EventHandler(this.iconButtonTatCa_Click);
            // 
            // iconButtonTienVao
            // 
            this.iconButtonTienVao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTienVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTienVao.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonTienVao.IconColor = System.Drawing.Color.Black;
            this.iconButtonTienVao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTienVao.Location = new System.Drawing.Point(195, 217);
            this.iconButtonTienVao.Name = "iconButtonTienVao";
            this.iconButtonTienVao.Size = new System.Drawing.Size(80, 30);
            this.iconButtonTienVao.TabIndex = 16;
            this.iconButtonTienVao.Text = "Tiền vào";
            this.iconButtonTienVao.UseVisualStyleBackColor = true;
            this.iconButtonTienVao.Click += new System.EventHandler(this.iconButtonTienVao_Click);
            // 
            // iconButtonTienRa
            // 
            this.iconButtonTienRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTienRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButtonTienRa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonTienRa.IconColor = System.Drawing.Color.Black;
            this.iconButtonTienRa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTienRa.Location = new System.Drawing.Point(109, 217);
            this.iconButtonTienRa.Name = "iconButtonTienRa";
            this.iconButtonTienRa.Size = new System.Drawing.Size(80, 30);
            this.iconButtonTienRa.TabIndex = 15;
            this.iconButtonTienRa.Text = "Tiền ra";
            this.iconButtonTienRa.UseVisualStyleBackColor = true;
            this.iconButtonTienRa.Click += new System.EventHandler(this.iconButtonTienRa_Click);
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
            this.panelMenu.TabIndex = 18;
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
            this.iconButtonSaoKe.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonSaoKe.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.iconButtonSaoKe.IconColor = System.Drawing.Color.LightSkyBlue;
            this.iconButtonSaoKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaoKe.IconSize = 35;
            this.iconButtonSaoKe.Location = new System.Drawing.Point(339, 8);
            this.iconButtonSaoKe.Name = "iconButtonSaoKe";
            this.iconButtonSaoKe.Size = new System.Drawing.Size(78, 76);
            this.iconButtonSaoKe.TabIndex = 4;
            this.iconButtonSaoKe.Text = "Sao kê";
            this.iconButtonSaoKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonSaoKe.UseVisualStyleBackColor = true;
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
            this.panelTheme.TabIndex = 19;
            // 
            // labelTren
            // 
            this.labelTren.AutoSize = true;
            this.labelTren.BackColor = System.Drawing.Color.Transparent;
            this.labelTren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTren.ForeColor = System.Drawing.Color.White;
            this.labelTren.Location = new System.Drawing.Point(156, 30);
            this.labelTren.Name = "labelTren";
            this.labelTren.Size = new System.Drawing.Size(94, 29);
            this.labelTren.TabIndex = 7;
            this.labelTren.Text = "Sao kê";
            // 
            // iconButtonChart
            // 
            this.iconButtonChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChart.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButtonChart.IconColor = System.Drawing.Color.Black;
            this.iconButtonChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonChart.IconSize = 30;
            this.iconButtonChart.Location = new System.Drawing.Point(357, 217);
            this.iconButtonChart.Name = "iconButtonChart";
            this.iconButtonChart.Size = new System.Drawing.Size(41, 30);
            this.iconButtonChart.TabIndex = 20;
            this.iconButtonChart.UseVisualStyleBackColor = true;
            this.iconButtonChart.Click += new System.EventHandler(this.iconButtonChart_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 107);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox1.TabIndex = 32;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Visible = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(23, 232);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(375, 451);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // FormSaoKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(420, 800);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconButtonChart);
            this.Controls.Add(this.panelTheme);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.iconButtonTatCa);
            this.Controls.Add(this.iconButtonTienVao);
            this.Controls.Add(this.iconButtonTienRa);
            this.Controls.Add(this.panelSaoKe);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSaoKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSaoKe";
            this.Load += new System.EventHandler(this.FormSaoKe_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTheme.ResumeLayout(false);
            this.panelTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panelSaoKe;
        private FontAwesome.Sharp.IconButton iconButtonTatCa;
        private FontAwesome.Sharp.IconButton iconButtonTienVao;
        private FontAwesome.Sharp.IconButton iconButtonTienRa;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonTietKiem;
        private FontAwesome.Sharp.IconButton iconButtonSaoKe;
        private FontAwesome.Sharp.IconButton iconButtonTrangChu;
        private FontAwesome.Sharp.IconButton iconButtonChuyenTien;
        private FontAwesome.Sharp.IconButton iconButtonQRcode;
        private System.Windows.Forms.Panel panelTheme;
        private System.Windows.Forms.Label labelTren;
        private FontAwesome.Sharp.IconButton iconButtonChart;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}