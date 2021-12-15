namespace ThietKeChucNang
{
    partial class ucThongKeDoanhThu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartControlDoanhThu = new DevExpress.XtraCharts.ChartControl();
            this.pnlTuyChon = new System.Windows.Forms.Panel();
            this.dptNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dptNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnThongKeTheoNgay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBangThongKe = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).BeginInit();
            this.pnlTuyChon.SuspendLayout();
            this.pnlBangThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControlDoanhThu
            // 
            this.chartControlDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlDoanhThu.Legend.Name = "Default Legend";
            this.chartControlDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.chartControlDoanhThu.Name = "chartControlDoanhThu";
            this.chartControlDoanhThu.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlDoanhThu.Size = new System.Drawing.Size(1130, 512);
            this.chartControlDoanhThu.TabIndex = 0;
            // 
            // pnlTuyChon
            // 
            this.pnlTuyChon.Controls.Add(this.dptNgayKT);
            this.pnlTuyChon.Controls.Add(this.dptNgayBD);
            this.pnlTuyChon.Controls.Add(this.btnThongKeTheoNgay);
            this.pnlTuyChon.Controls.Add(this.label3);
            this.pnlTuyChon.Controls.Add(this.label1);
            this.pnlTuyChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTuyChon.Location = new System.Drawing.Point(0, 0);
            this.pnlTuyChon.Name = "pnlTuyChon";
            this.pnlTuyChon.Size = new System.Drawing.Size(1130, 57);
            this.pnlTuyChon.TabIndex = 19;
            // 
            // dptNgayKT
            // 
            this.dptNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptNgayKT.Location = new System.Drawing.Point(245, 17);
            this.dptNgayKT.Name = "dptNgayKT";
            this.dptNgayKT.Size = new System.Drawing.Size(101, 24);
            this.dptNgayKT.TabIndex = 25;
            // 
            // dptNgayBD
            // 
            this.dptNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptNgayBD.Location = new System.Drawing.Point(73, 17);
            this.dptNgayBD.Name = "dptNgayBD";
            this.dptNgayBD.Size = new System.Drawing.Size(101, 24);
            this.dptNgayBD.TabIndex = 24;
            // 
            // btnThongKeTheoNgay
            // 
            this.btnThongKeTheoNgay.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThongKeTheoNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeTheoNgay.FlatAppearance.BorderSize = 0;
            this.btnThongKeTheoNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoNgay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongKeTheoNgay.Location = new System.Drawing.Point(352, 7);
            this.btnThongKeTheoNgay.Name = "btnThongKeTheoNgay";
            this.btnThongKeTheoNgay.Size = new System.Drawing.Size(82, 44);
            this.btnThongKeTheoNgay.TabIndex = 23;
            this.btnThongKeTheoNgay.Text = "Thống kê";
            this.btnThongKeTheoNgay.UseVisualStyleBackColor = false;
            this.btnThongKeTheoNgay.Click += new System.EventHandler(this.btnThongKeTheoNgay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "tới ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Từ ngày";
            // 
            // pnlBangThongKe
            // 
            this.pnlBangThongKe.Controls.Add(this.chartControlDoanhThu);
            this.pnlBangThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBangThongKe.Location = new System.Drawing.Point(0, 57);
            this.pnlBangThongKe.Name = "pnlBangThongKe";
            this.pnlBangThongKe.Size = new System.Drawing.Size(1130, 512);
            this.pnlBangThongKe.TabIndex = 20;
            // 
            // ucThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBangThongKe);
            this.Controls.Add(this.pnlTuyChon);
            this.Name = "ucThongKeDoanhThu";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).EndInit();
            this.pnlTuyChon.ResumeLayout(false);
            this.pnlTuyChon.PerformLayout();
            this.pnlBangThongKe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControlDoanhThu;
        private System.Windows.Forms.Panel pnlTuyChon;
        private System.Windows.Forms.Panel pnlBangThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongKeTheoNgay;
        private System.Windows.Forms.DateTimePicker dptNgayKT;
        private System.Windows.Forms.DateTimePicker dptNgayBD;
    }
}
