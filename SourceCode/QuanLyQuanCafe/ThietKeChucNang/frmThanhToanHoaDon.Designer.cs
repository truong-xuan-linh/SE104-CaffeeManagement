namespace ThietKeChucNang
{
    partial class frmThanhToanHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToanHoaDon));
            this.pnlThanhTieuDe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTienThanhToan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.lblGioRa = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.chkKhongPhaiThanhVien = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnApDungGiamGIa = new System.Windows.Forms.Button();
            this.grcChiTietHoaDon = new DevExpress.XtraGrid.GridControl();
            this.grvChiTietHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaCTHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenDoUong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlThanhTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThanhTieuDe
            // 
            this.pnlThanhTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.pnlThanhTieuDe.Controls.Add(this.label1);
            this.pnlThanhTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThanhTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlThanhTieuDe.Name = "pnlThanhTieuDe";
            this.pnlThanhTieuDe.Size = new System.Drawing.Size(450, 37);
            this.pnlThanhTieuDe.TabIndex = 1;
            this.pnlThanhTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlThanhTieuDe_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thanh toán hóa đơn";
            // 
            // lblTienThanhToan
            // 
            this.lblTienThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTienThanhToan.AutoSize = true;
            this.lblTienThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThanhToan.Location = new System.Drawing.Point(244, 637);
            this.lblTienThanhToan.Name = "lblTienThanhToan";
            this.lblTienThanhToan.Size = new System.Drawing.Size(15, 16);
            this.lblTienThanhToan.TabIndex = 13;
            this.lblTienThanhToan.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(116, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tiền thanh toán: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(116, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Giảm giá:";
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(151, 53);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(142, 38);
            this.lblLogo.TabIndex = 16;
            this.lblLogo.Text = "Fog Coffee";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "34 Đặng Văn Bi, P.Bình Thọ, Q.Thủ Đức";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "0979510945";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "PHIẾU THANH TOÁN";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label8.Location = new System.Drawing.Point(42, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã hóa đơn:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(130, 180);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(78, 16);
            this.lblMaHoaDon.TabIndex = 21;
            this.lblMaHoaDon.Text = "MaHoaDon";
            // 
            // lblBan
            // 
            this.lblBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBan.AutoSize = true;
            this.lblBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBan.Location = new System.Drawing.Point(130, 210);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(32, 16);
            this.lblBan.TabIndex = 22;
            this.lblBan.Text = "Ban";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label10.Location = new System.Drawing.Point(42, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Bàn:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label9.Location = new System.Drawing.Point(226, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Thu ngân:";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(299, 210);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(91, 16);
            this.lblTenNhanVien.TabIndex = 25;
            this.lblTenNhanVien.Text = "TenNhanVien";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label11.Location = new System.Drawing.Point(42, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Giờ vào:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label12.Location = new System.Drawing.Point(226, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Giờ ra:";
            // 
            // lblGioVao
            // 
            this.lblGioVao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioVao.Location = new System.Drawing.Point(130, 240);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(54, 16);
            this.lblGioVao.TabIndex = 28;
            this.lblGioVao.Text = "GioVao";
            // 
            // lblGioRa
            // 
            this.lblGioRa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGioRa.AutoSize = true;
            this.lblGioRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioRa.Location = new System.Drawing.Point(299, 240);
            this.lblGioRa.Name = "lblGioRa";
            this.lblGioRa.Size = new System.Drawing.Size(47, 16);
            this.lblGioRa.TabIndex = 29;
            this.lblGioRa.Text = "GioRa";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label13.Location = new System.Drawing.Point(42, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 31;
            this.label13.Text = "Khách hàng:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(130, 270);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(78, 16);
            this.lblKhachHang.TabIndex = 32;
            this.lblKhachHang.Text = "KhachHang";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(133, 294);
            this.txtSoDienThoai.MaxLength = 10;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(127, 17);
            this.txtSoDienThoai.TabIndex = 33;
            this.txtSoDienThoai.Text = "Nhập SDT";
            this.txtSoDienThoai.Click += new System.EventHandler(this.txtSoDienThoai_Click);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Info;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTimKiem.Location = new System.Drawing.Point(257, 292);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(24, 24);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // chkKhongPhaiThanhVien
            // 
            this.chkKhongPhaiThanhVien.AutoSize = true;
            this.chkKhongPhaiThanhVien.Location = new System.Drawing.Point(133, 319);
            this.chkKhongPhaiThanhVien.Name = "chkKhongPhaiThanhVien";
            this.chkKhongPhaiThanhVien.Size = new System.Drawing.Size(146, 17);
            this.chkKhongPhaiThanhVien.TabIndex = 35;
            this.chkKhongPhaiThanhVien.Text = "Chưa đăng ký thành viên";
            this.chkKhongPhaiThanhVien.UseVisualStyleBackColor = true;
            this.chkKhongPhaiThanhVien.CheckedChanged += new System.EventHandler(this.chkKhongPhaiThanhVien_CheckedChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThanhToan.Location = new System.Drawing.Point(119, 665);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(204, 45);
            this.btnThanhToan.TabIndex = 36;
            this.btnThanhToan.Text = "Xác Nhận Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(244, 581);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(15, 16);
            this.lblTongTien.TabIndex = 38;
            this.lblTongTien.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.label14.Location = new System.Drawing.Point(116, 581);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Tổng tiền: ";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(247, 605);
            this.txtGiamGia.MaxLength = 5;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(85, 17);
            this.txtGiamGia.TabIndex = 39;
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // btnApDungGiamGIa
            // 
            this.btnApDungGiamGIa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnApDungGiamGIa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.btnApDungGiamGIa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApDungGiamGIa.FlatAppearance.BorderSize = 0;
            this.btnApDungGiamGIa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApDungGiamGIa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDungGiamGIa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnApDungGiamGIa.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnApDungGiamGIa.Location = new System.Drawing.Point(338, 603);
            this.btnApDungGiamGIa.Name = "btnApDungGiamGIa";
            this.btnApDungGiamGIa.Size = new System.Drawing.Size(80, 24);
            this.btnApDungGiamGIa.TabIndex = 40;
            this.btnApDungGiamGIa.Text = "Áp dụng";
            this.btnApDungGiamGIa.UseVisualStyleBackColor = false;
            this.btnApDungGiamGIa.Click += new System.EventHandler(this.btnApDungGiamGIa_Click);
            // 
            // grcChiTietHoaDon
            // 
            this.grcChiTietHoaDon.Location = new System.Drawing.Point(12, 342);
            this.grcChiTietHoaDon.MainView = this.grvChiTietHoaDon;
            this.grcChiTietHoaDon.Name = "grcChiTietHoaDon";
            this.grcChiTietHoaDon.Size = new System.Drawing.Size(426, 236);
            this.grcChiTietHoaDon.TabIndex = 41;
            this.grcChiTietHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChiTietHoaDon});
            // 
            // grvChiTietHoaDon
            // 
            this.grvChiTietHoaDon.Appearance.Empty.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.Empty.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietHoaDon.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.FocusedRow.Options.UseFont = true;
            this.grvChiTietHoaDon.Appearance.FooterPanel.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.GroupFooter.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.GroupPanel.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.GroupRow.BackColor2 = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.HeaderPanel.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.Preview.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.Preview.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.Row.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietHoaDon.Appearance.Row.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Appearance.Row.Options.UseFont = true;
            this.grvChiTietHoaDon.Appearance.TopNewRow.BackColor = System.Drawing.SystemColors.Info;
            this.grvChiTietHoaDon.Appearance.TopNewRow.Options.UseBackColor = true;
            this.grvChiTietHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaCTHD,
            this.gridColumnTenDoUong,
            this.gridColumnGiaBan,
            this.gridColumnSoLuong,
            this.gridColumnThanhTien});
            this.grvChiTietHoaDon.GridControl = this.grcChiTietHoaDon;
            this.grvChiTietHoaDon.Name = "grvChiTietHoaDon";
            this.grvChiTietHoaDon.OptionsBehavior.Editable = false;
            this.grvChiTietHoaDon.OptionsView.ShowGroupPanel = false;
            this.grvChiTietHoaDon.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.grvChiTietHoaDon.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumnMaCTHD
            // 
            this.gridColumnMaCTHD.Caption = "Mã CTHD";
            this.gridColumnMaCTHD.FieldName = "MaCTHD";
            this.gridColumnMaCTHD.Name = "gridColumnMaCTHD";
            this.gridColumnMaCTHD.Visible = true;
            this.gridColumnMaCTHD.VisibleIndex = 0;
            this.gridColumnMaCTHD.Width = 20;
            // 
            // gridColumnTenDoUong
            // 
            this.gridColumnTenDoUong.Caption = "Tên đồ uống";
            this.gridColumnTenDoUong.FieldName = "TenDoUong";
            this.gridColumnTenDoUong.Name = "gridColumnTenDoUong";
            this.gridColumnTenDoUong.Visible = true;
            this.gridColumnTenDoUong.VisibleIndex = 1;
            this.gridColumnTenDoUong.Width = 65;
            // 
            // gridColumnGiaBan
            // 
            this.gridColumnGiaBan.Caption = "Giá bán";
            this.gridColumnGiaBan.FieldName = "Gia";
            this.gridColumnGiaBan.Name = "gridColumnGiaBan";
            this.gridColumnGiaBan.Visible = true;
            this.gridColumnGiaBan.VisibleIndex = 2;
            this.gridColumnGiaBan.Width = 62;
            // 
            // gridColumnSoLuong
            // 
            this.gridColumnSoLuong.Caption = "Số lượng";
            this.gridColumnSoLuong.FieldName = "SoLuong";
            this.gridColumnSoLuong.Name = "gridColumnSoLuong";
            this.gridColumnSoLuong.Visible = true;
            this.gridColumnSoLuong.VisibleIndex = 3;
            this.gridColumnSoLuong.Width = 49;
            // 
            // gridColumnThanhTien
            // 
            this.gridColumnThanhTien.Caption = "Thành tiền";
            this.gridColumnThanhTien.FieldName = "ThanhTien";
            this.gridColumnThanhTien.Name = "gridColumnThanhTien";
            this.gridColumnThanhTien.Visible = true;
            this.gridColumnThanhTien.VisibleIndex = 4;
            this.gridColumnThanhTien.Width = 76;
            // 
            // frmThanhToanHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(450, 725);
            this.Controls.Add(this.grcChiTietHoaDon);
            this.Controls.Add(this.btnApDungGiamGIa);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.chkKhongPhaiThanhVien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblGioRa);
            this.Controls.Add(this.lblGioVao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBan);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblTienThanhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlThanhTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThanhToanHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán hóa đơn";
            this.Load += new System.EventHandler(this.frmThanhToanHoaDon_Load);
            this.pnlThanhTieuDe.ResumeLayout(false);
            this.pnlThanhTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlThanhTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTienThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.Label lblGioRa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox chkKhongPhaiThanhVien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnApDungGiamGIa;
        private DevExpress.XtraGrid.GridControl grcChiTietHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChiTietHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaCTHD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThanhTien;
    }
}