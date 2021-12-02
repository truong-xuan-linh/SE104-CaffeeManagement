namespace ThietKeChucNang
{
    partial class ucTrangChu
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblBanCoKhach = new System.Windows.Forms.Label();
            this.lblBanTrong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.timerThoiGian = new System.Windows.Forms.Timer(this.components);
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.pnlTrangThai = new System.Windows.Forms.Panel();
            this.pnlTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bàn có khách:";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblTenNhanVien.Location = new System.Drawing.Point(97, 326);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(192, 33);
            this.lblTenNhanVien.TabIndex = 7;
            this.lblTenNhanVien.Text = "TenNhanVien";
            // 
            // lblBanCoKhach
            // 
            this.lblBanCoKhach.AutoSize = true;
            this.lblBanCoKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblBanCoKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanCoKhach.ForeColor = System.Drawing.Color.White;
            this.lblBanCoKhach.Location = new System.Drawing.Point(314, 565);
            this.lblBanCoKhach.Name = "lblBanCoKhach";
            this.lblBanCoKhach.Size = new System.Drawing.Size(185, 33);
            this.lblBanCoKhach.TabIndex = 6;
            this.lblBanCoKhach.Text = "BanCoKhach";
            // 
            // lblBanTrong
            // 
            this.lblBanTrong.AutoSize = true;
            this.lblBanTrong.BackColor = System.Drawing.Color.Transparent;
            this.lblBanTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanTrong.ForeColor = System.Drawing.Color.White;
            this.lblBanTrong.Location = new System.Drawing.Point(314, 529);
            this.lblBanTrong.Name = "lblBanTrong";
            this.lblBanTrong.Size = new System.Drawing.Size(142, 33);
            this.lblBanTrong.TabIndex = 5;
            this.lblBanTrong.Text = "BanTrong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bàn trống:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(96, 279);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(124, 33);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "ChucVu";
            // 
            // timerThoiGian
            // 
            this.timerThoiGian.Enabled = true;
            this.timerThoiGian.Interval = 1000;
            this.timerThoiGian.Tick += new System.EventHandler(this.timerThoiGian_Tick);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.White;
            this.lblThoiGian.Location = new System.Drawing.Point(95, 65);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(59, 31);
            this.lblThoiGian.TabIndex = 1;
            this.lblThoiGian.Text = "Giờ";
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.White;
            this.lblNgay.Location = new System.Drawing.Point(95, 29);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(66, 25);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // pnlTrangThai
            // 
            this.pnlTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.pnlTrangThai.Controls.Add(this.lblNgay);
            this.pnlTrangThai.Controls.Add(this.lblThoiGian);
            this.pnlTrangThai.Location = new System.Drawing.Point(0, 0);
            this.pnlTrangThai.Name = "pnlTrangThai";
            this.pnlTrangThai.Size = new System.Drawing.Size(1130, 106);
            this.pnlTrangThai.TabIndex = 0;
            // 
            // ucTrangChu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ThietKeChucNang.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlTrangThai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblBanCoKhach);
            this.Controls.Add(this.lblBanTrong);
            this.Controls.Add(this.label2);
            this.Name = "ucTrangChu";
            this.Size = new System.Drawing.Size(1130, 649);
            this.Load += new System.EventHandler(this.ucTrangChu_Load);
            this.pnlTrangThai.ResumeLayout(false);
            this.pnlTrangThai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerThoiGian;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblBanCoKhach;
        private System.Windows.Forms.Label lblBanTrong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Panel pnlTrangThai;
    }
}
