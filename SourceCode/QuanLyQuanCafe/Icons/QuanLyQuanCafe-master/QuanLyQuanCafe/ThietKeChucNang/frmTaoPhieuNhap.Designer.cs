namespace ThietKeChucNang
{
    partial class frmTaoPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoPhieuNhap));
            this.pnlThanhTieuDe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaPhieuNhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.groupControlPhieuNhap = new DevExpress.XtraEditors.GroupControl();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.groupControlCTPN = new DevExpress.XtraEditors.GroupControl();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnXoaCTPN = new System.Windows.Forms.Button();
            this.btnThemCTPN = new System.Windows.Forms.Button();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.grcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.grvChiTietPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaCTPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDonGiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoLuongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlThanhTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPhieuNhap)).BeginInit();
            this.groupControlPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCTPN)).BeginInit();
            this.groupControlCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlThanhTieuDe
            // 
            this.pnlThanhTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.pnlThanhTieuDe.Controls.Add(this.label1);
            this.pnlThanhTieuDe.Controls.Add(this.btnClose);
            this.pnlThanhTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThanhTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlThanhTieuDe.Name = "pnlThanhTieuDe";
            this.pnlThanhTieuDe.Size = new System.Drawing.Size(1066, 37);
            this.pnlThanhTieuDe.TabIndex = 1;
            this.pnlThanhTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlThanhTieuDe_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(423, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phiếu nhập nguyên liệu";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1026, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaPhieuNhap.AutoSize = true;
            this.lblMaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(276, 38);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(42, 18);
            this.lblMaPhieuNhap.TabIndex = 25;
            this.lblMaPhieuNhap.Text = "MPN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nhân viên:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(276, 88);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(37, 18);
            this.lblNhanVien.TabIndex = 29;
            this.lblNhanVien.Text = "TNV";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.SystemColors.Window;
            this.cboNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(692, 85);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(199, 26);
            this.cboNhaCungCap.TabIndex = 31;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(586, 123);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 50);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "   Tạo phiếu nhập";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(276, 138);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(26, 18);
            this.lblTongTien.TabIndex = 34;
            this.lblTongTien.Text = "TT";
            // 
            // groupControlPhieuNhap
            // 
            this.groupControlPhieuNhap.Controls.Add(this.lblNgayLap);
            this.groupControlPhieuNhap.Controls.Add(this.btnThem);
            this.groupControlPhieuNhap.Controls.Add(this.label2);
            this.groupControlPhieuNhap.Controls.Add(this.lblTongTien);
            this.groupControlPhieuNhap.Controls.Add(this.lblMaPhieuNhap);
            this.groupControlPhieuNhap.Controls.Add(this.label6);
            this.groupControlPhieuNhap.Controls.Add(this.label3);
            this.groupControlPhieuNhap.Controls.Add(this.cboNhaCungCap);
            this.groupControlPhieuNhap.Controls.Add(this.label4);
            this.groupControlPhieuNhap.Controls.Add(this.label5);
            this.groupControlPhieuNhap.Controls.Add(this.lblNhanVien);
            this.groupControlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlPhieuNhap.Location = new System.Drawing.Point(0, 37);
            this.groupControlPhieuNhap.Name = "groupControlPhieuNhap";
            this.groupControlPhieuNhap.Size = new System.Drawing.Size(1066, 220);
            this.groupControlPhieuNhap.TabIndex = 35;
            this.groupControlPhieuNhap.Text = "Phiếu Nhập";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(689, 38);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(27, 18);
            this.lblNgayLap.TabIndex = 35;
            this.lblNgayLap.Text = "NL";
            // 
            // groupControlCTPN
            // 
            this.groupControlCTPN.Controls.Add(this.lblDonViTinh);
            this.groupControlCTPN.Controls.Add(this.label10);
            this.groupControlCTPN.Controls.Add(this.btnHoanThanh);
            this.groupControlCTPN.Controls.Add(this.btnXoaCTPN);
            this.groupControlCTPN.Controls.Add(this.btnThemCTPN);
            this.groupControlCTPN.Controls.Add(this.txtSoLuongNhap);
            this.groupControlCTPN.Controls.Add(this.label9);
            this.groupControlCTPN.Controls.Add(this.txtDonGiaNhap);
            this.groupControlCTPN.Controls.Add(this.grcChiTietPhieuNhap);
            this.groupControlCTPN.Controls.Add(this.cboNguyenLieu);
            this.groupControlCTPN.Controls.Add(this.label8);
            this.groupControlCTPN.Controls.Add(this.label7);
            this.groupControlCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCTPN.Location = new System.Drawing.Point(0, 257);
            this.groupControlCTPN.Name = "groupControlCTPN";
            this.groupControlCTPN.Size = new System.Drawing.Size(1066, 307);
            this.groupControlCTPN.TabIndex = 36;
            this.groupControlCTPN.Text = "Chi Tiết Phiếu Nhập";
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Location = new System.Drawing.Point(296, 203);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(37, 18);
            this.lblDonViTinh.TabIndex = 44;
            this.lblDonViTinh.Text = "DVT";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "VNĐ";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnHoanThanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoanThanh.FlatAppearance.BorderSize = 0;
            this.btnHoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHoanThanh.Location = new System.Drawing.Point(12, 252);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(441, 50);
            this.btnHoanThanh.TabIndex = 42;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnXoaCTPN
            // 
            this.btnXoaCTPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaCTPN.BackColor = System.Drawing.Color.DarkRed;
            this.btnXoaCTPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCTPN.FlatAppearance.BorderSize = 0;
            this.btnXoaCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCTPN.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoaCTPN.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCTPN.Image")));
            this.btnXoaCTPN.Location = new System.Drawing.Point(360, 177);
            this.btnXoaCTPN.Name = "btnXoaCTPN";
            this.btnXoaCTPN.Size = new System.Drawing.Size(93, 50);
            this.btnXoaCTPN.TabIndex = 41;
            this.btnXoaCTPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaCTPN.UseVisualStyleBackColor = false;
            this.btnXoaCTPN.Visible = false;
            this.btnXoaCTPN.Click += new System.EventHandler(this.btnXoaCTPN_Click);
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemCTPN.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThemCTPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCTPN.FlatAppearance.BorderSize = 0;
            this.btnThemCTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTPN.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThemCTPN.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTPN.Image")));
            this.btnThemCTPN.Location = new System.Drawing.Point(360, 121);
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.Size = new System.Drawing.Size(93, 50);
            this.btnThemCTPN.TabIndex = 35;
            this.btnThemCTPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCTPN.UseVisualStyleBackColor = false;
            this.btnThemCTPN.Click += new System.EventHandler(this.btnThemCTPN_Click);
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuongNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuongNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(136, 202);
            this.txtSoLuongNhap.MaxLength = 4;
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(154, 19);
            this.txtSoLuongNhap.TabIndex = 40;
            this.txtSoLuongNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaNhap_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Số lượng nhập:";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGiaNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGiaNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaNhap.Location = new System.Drawing.Point(136, 152);
            this.txtDonGiaNhap.MaxLength = 8;
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(154, 19);
            this.txtDonGiaNhap.TabIndex = 38;
            this.txtDonGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaNhap_KeyPress);
            // 
            // grcChiTietPhieuNhap
            // 
            this.grcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.grcChiTietPhieuNhap.Location = new System.Drawing.Point(470, 23);
            this.grcChiTietPhieuNhap.MainView = this.grvChiTietPhieuNhap;
            this.grcChiTietPhieuNhap.Name = "grcChiTietPhieuNhap";
            this.grcChiTietPhieuNhap.Size = new System.Drawing.Size(594, 282);
            this.grcChiTietPhieuNhap.TabIndex = 1;
            this.grcChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChiTietPhieuNhap});
            // 
            // grvChiTietPhieuNhap
            // 
            this.grvChiTietPhieuNhap.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.grvChiTietPhieuNhap.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietPhieuNhap.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvChiTietPhieuNhap.Appearance.FocusedRow.Options.UseFont = true;
            this.grvChiTietPhieuNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietPhieuNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvChiTietPhieuNhap.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietPhieuNhap.Appearance.Row.Options.UseFont = true;
            this.grvChiTietPhieuNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaCTPN,
            this.gridColumnMaNguyenLieu,
            this.gridColumnTenNguyenLieu,
            this.gridColumnDonGiaNhap,
            this.gridColumnSoLuongNhap,
            this.gridColumnDonViTinh,
            this.gridColumnThanhTien});
            this.grvChiTietPhieuNhap.GridControl = this.grcChiTietPhieuNhap;
            this.grvChiTietPhieuNhap.Name = "grvChiTietPhieuNhap";
            this.grvChiTietPhieuNhap.OptionsBehavior.Editable = false;
            this.grvChiTietPhieuNhap.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvChiTietPhieuNhap_RowCellClick);
            // 
            // gridColumnMaCTPN
            // 
            this.gridColumnMaCTPN.Caption = "Mã CTPN";
            this.gridColumnMaCTPN.FieldName = "MaCTPN";
            this.gridColumnMaCTPN.Name = "gridColumnMaCTPN";
            // 
            // gridColumnMaNguyenLieu
            // 
            this.gridColumnMaNguyenLieu.Caption = "Mã NL";
            this.gridColumnMaNguyenLieu.FieldName = "MaNguyenLieu";
            this.gridColumnMaNguyenLieu.Name = "gridColumnMaNguyenLieu";
            // 
            // gridColumnTenNguyenLieu
            // 
            this.gridColumnTenNguyenLieu.Caption = "Tên Nguyên Liệu";
            this.gridColumnTenNguyenLieu.FieldName = "TenNguyenLieu";
            this.gridColumnTenNguyenLieu.Name = "gridColumnTenNguyenLieu";
            this.gridColumnTenNguyenLieu.Visible = true;
            this.gridColumnTenNguyenLieu.VisibleIndex = 0;
            // 
            // gridColumnDonGiaNhap
            // 
            this.gridColumnDonGiaNhap.Caption = "Đơn Giá Nhập";
            this.gridColumnDonGiaNhap.FieldName = "DonGiaNhap";
            this.gridColumnDonGiaNhap.Name = "gridColumnDonGiaNhap";
            this.gridColumnDonGiaNhap.Visible = true;
            this.gridColumnDonGiaNhap.VisibleIndex = 1;
            // 
            // gridColumnSoLuongNhap
            // 
            this.gridColumnSoLuongNhap.Caption = "Số Lượng Nhập";
            this.gridColumnSoLuongNhap.FieldName = "SoLuong";
            this.gridColumnSoLuongNhap.Name = "gridColumnSoLuongNhap";
            this.gridColumnSoLuongNhap.Visible = true;
            this.gridColumnSoLuongNhap.VisibleIndex = 2;
            // 
            // gridColumnDonViTinh
            // 
            this.gridColumnDonViTinh.Caption = "Đơn Vị Tính";
            this.gridColumnDonViTinh.FieldName = "DonViTinh";
            this.gridColumnDonViTinh.Name = "gridColumnDonViTinh";
            this.gridColumnDonViTinh.Visible = true;
            this.gridColumnDonViTinh.VisibleIndex = 3;
            // 
            // gridColumnThanhTien
            // 
            this.gridColumnThanhTien.Caption = "Thành Tiền";
            this.gridColumnThanhTien.FieldName = "ThanhTien";
            this.gridColumnThanhTien.Name = "gridColumnThanhTien";
            this.gridColumnThanhTien.Visible = true;
            this.gridColumnThanhTien.VisibleIndex = 4;
            // 
            // cboNguyenLieu
            // 
            this.cboNguyenLieu.BackColor = System.Drawing.SystemColors.Window;
            this.cboNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguyenLieu.FormattingEnabled = true;
            this.cboNguyenLieu.Location = new System.Drawing.Point(136, 100);
            this.cboNguyenLieu.Name = "cboNguyenLieu";
            this.cboNguyenLieu.Size = new System.Drawing.Size(154, 26);
            this.cboNguyenLieu.TabIndex = 36;
            this.cboNguyenLieu.SelectedIndexChanged += new System.EventHandler(this.cboNguyenLieu_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Đơn giá nhập:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Nguyên liệu:";
            // 
            // frmTaoPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 564);
            this.Controls.Add(this.groupControlCTPN);
            this.Controls.Add(this.groupControlPhieuNhap);
            this.Controls.Add(this.pnlThanhTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaoPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu nhập nguyên liệu";
            this.Load += new System.EventHandler(this.frmTaoPhieuNhap_Load);
            this.pnlThanhTieuDe.ResumeLayout(false);
            this.pnlThanhTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPhieuNhap)).EndInit();
            this.groupControlPhieuNhap.ResumeLayout(false);
            this.groupControlPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCTPN)).EndInit();
            this.groupControlCTPN.ResumeLayout(false);
            this.groupControlCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThanhTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongTien;
        private DevExpress.XtraEditors.GroupControl groupControlPhieuNhap;
        private DevExpress.XtraEditors.GroupControl groupControlCTPN;
        private DevExpress.XtraGrid.GridControl grcChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChiTietPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDonGiaNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoLuongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThanhTien;
        private System.Windows.Forms.ComboBox cboNguyenLieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoaCTPN;
        private System.Windows.Forms.Button btnThemCTPN;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Label lblNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDonViTinh;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label label10;
    }
}