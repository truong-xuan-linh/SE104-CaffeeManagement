namespace ThietKeChucNang
{
    partial class ucQuanLyPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyPhieuNhap));
            this.label6 = new System.Windows.Forms.Label();
            this.pnlThanhTieuDe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grvChiTietPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTenNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDonGiaNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.pnlChiTietHoaDon = new System.Windows.Forms.Panel();
            this.grvPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaPhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.btnXuatFileExcel = new System.Windows.Forms.Button();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnTaoPhieuNhap = new System.Windows.Forms.Button();
            this.pnlQuanLyPhieuNhap = new System.Windows.Forms.Panel();
            this.pnlDSPhieuNhap = new System.Windows.Forms.Panel();
            this.pnlThanhTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietPhieuNhap)).BeginInit();
            this.pnlChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuNhap)).BeginInit();
            this.pnlChucNang.SuspendLayout();
            this.pnlQuanLyPhieuNhap.SuspendLayout();
            this.pnlDSPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // pnlThanhTieuDe
            // 
            this.pnlThanhTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThanhTieuDe.Controls.Add(this.label1);
            this.pnlThanhTieuDe.Controls.Add(this.label6);
            this.pnlThanhTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThanhTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlThanhTieuDe.Name = "pnlThanhTieuDe";
            this.pnlThanhTieuDe.Size = new System.Drawing.Size(1130, 79);
            this.pnlThanhTieuDe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(774, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // grvChiTietPhieuNhap
            // 
            this.grvChiTietPhieuNhap.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietPhieuNhap.Appearance.FocusedRow.Options.UseFont = true;
            this.grvChiTietPhieuNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietPhieuNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvChiTietPhieuNhap.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvChiTietPhieuNhap.Appearance.Row.Options.UseFont = true;
            this.grvChiTietPhieuNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTenNguyenLieu,
            this.gridColumnSoLuong,
            this.gridColumnDonViTinh,
            this.gridColumnDonGiaNhap,
            this.gridColumnThanhTien});
            this.grvChiTietPhieuNhap.GridControl = this.grcChiTietPhieuNhap;
            this.grvChiTietPhieuNhap.Name = "grvChiTietPhieuNhap";
            this.grvChiTietPhieuNhap.OptionsBehavior.Editable = false;
            // 
            // gridColumnTenNguyenLieu
            // 
            this.gridColumnTenNguyenLieu.Caption = "Tên Nguyên Liệu";
            this.gridColumnTenNguyenLieu.FieldName = "TenNguyenLieu";
            this.gridColumnTenNguyenLieu.Name = "gridColumnTenNguyenLieu";
            this.gridColumnTenNguyenLieu.Visible = true;
            this.gridColumnTenNguyenLieu.VisibleIndex = 0;
            this.gridColumnTenNguyenLieu.Width = 128;
            // 
            // gridColumnSoLuong
            // 
            this.gridColumnSoLuong.Caption = "Số Lượng";
            this.gridColumnSoLuong.FieldName = "SoLuong";
            this.gridColumnSoLuong.Name = "gridColumnSoLuong";
            this.gridColumnSoLuong.Visible = true;
            this.gridColumnSoLuong.VisibleIndex = 1;
            this.gridColumnSoLuong.Width = 101;
            // 
            // gridColumnDonViTinh
            // 
            this.gridColumnDonViTinh.Caption = "Đơn Vị Tính";
            this.gridColumnDonViTinh.FieldName = "DonViTinh";
            this.gridColumnDonViTinh.Name = "gridColumnDonViTinh";
            this.gridColumnDonViTinh.Visible = true;
            this.gridColumnDonViTinh.VisibleIndex = 2;
            this.gridColumnDonViTinh.Width = 101;
            // 
            // gridColumnDonGiaNhap
            // 
            this.gridColumnDonGiaNhap.Caption = "Đơn Giá Nhập";
            this.gridColumnDonGiaNhap.FieldName = "DonGiaNhap";
            this.gridColumnDonGiaNhap.Name = "gridColumnDonGiaNhap";
            this.gridColumnDonGiaNhap.Visible = true;
            this.gridColumnDonGiaNhap.VisibleIndex = 3;
            // 
            // gridColumnThanhTien
            // 
            this.gridColumnThanhTien.Caption = "Thành Tiền";
            this.gridColumnThanhTien.FieldName = "ThanhTien";
            this.gridColumnThanhTien.Name = "gridColumnThanhTien";
            this.gridColumnThanhTien.Visible = true;
            this.gridColumnThanhTien.VisibleIndex = 4;
            this.gridColumnThanhTien.Width = 104;
            // 
            // grcChiTietPhieuNhap
            // 
            this.grcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcChiTietPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.grcChiTietPhieuNhap.MainView = this.grvChiTietPhieuNhap;
            this.grcChiTietPhieuNhap.Name = "grcChiTietPhieuNhap";
            this.grcChiTietPhieuNhap.Size = new System.Drawing.Size(459, 490);
            this.grcChiTietPhieuNhap.TabIndex = 0;
            this.grcChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChiTietPhieuNhap});
            // 
            // pnlChiTietHoaDon
            // 
            this.pnlChiTietHoaDon.Controls.Add(this.grcChiTietPhieuNhap);
            this.pnlChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChiTietHoaDon.Location = new System.Drawing.Point(671, 79);
            this.pnlChiTietHoaDon.Name = "pnlChiTietHoaDon";
            this.pnlChiTietHoaDon.Size = new System.Drawing.Size(459, 490);
            this.pnlChiTietHoaDon.TabIndex = 2;
            // 
            // grvPhieuNhap
            // 
            this.grvPhieuNhap.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvPhieuNhap.Appearance.FocusedRow.Options.UseFont = true;
            this.grvPhieuNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvPhieuNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvPhieuNhap.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvPhieuNhap.Appearance.Row.Options.UseFont = true;
            this.grvPhieuNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaPhieuNhap,
            this.gridColumnTenNhanVien,
            this.gridColumnTenNCC,
            this.gridColumnNgayLap,
            this.gridColumnTongTien});
            this.grvPhieuNhap.GridControl = this.grcPhieuNhap;
            this.grvPhieuNhap.Name = "grvPhieuNhap";
            this.grvPhieuNhap.OptionsBehavior.Editable = false;
            this.grvPhieuNhap.OptionsCustomization.AllowGroup = false;
            this.grvPhieuNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvPhieuNhap_FocusedRowChanged);
            // 
            // gridColumnMaPhieuNhap
            // 
            this.gridColumnMaPhieuNhap.Caption = "Mã Phiếu Nhập";
            this.gridColumnMaPhieuNhap.FieldName = "MaPhieuNhap";
            this.gridColumnMaPhieuNhap.Name = "gridColumnMaPhieuNhap";
            this.gridColumnMaPhieuNhap.Visible = true;
            this.gridColumnMaPhieuNhap.VisibleIndex = 0;
            // 
            // gridColumnTenNhanVien
            // 
            this.gridColumnTenNhanVien.Caption = "Nhân Viên Lập";
            this.gridColumnTenNhanVien.FieldName = "TenNhanVien";
            this.gridColumnTenNhanVien.Name = "gridColumnTenNhanVien";
            this.gridColumnTenNhanVien.Visible = true;
            this.gridColumnTenNhanVien.VisibleIndex = 2;
            // 
            // gridColumnTenNCC
            // 
            this.gridColumnTenNCC.Caption = "Nhà Cung Cấp";
            this.gridColumnTenNCC.FieldName = "TenNCC";
            this.gridColumnTenNCC.Name = "gridColumnTenNCC";
            this.gridColumnTenNCC.Visible = true;
            this.gridColumnTenNCC.VisibleIndex = 1;
            // 
            // gridColumnNgayLap
            // 
            this.gridColumnNgayLap.Caption = "Ngày Lập";
            this.gridColumnNgayLap.FieldName = "NgayLap";
            this.gridColumnNgayLap.Name = "gridColumnNgayLap";
            this.gridColumnNgayLap.Visible = true;
            this.gridColumnNgayLap.VisibleIndex = 3;
            // 
            // gridColumnTongTien
            // 
            this.gridColumnTongTien.Caption = "Tổng Tiền";
            this.gridColumnTongTien.FieldName = "TongTien";
            this.gridColumnTongTien.Name = "gridColumnTongTien";
            this.gridColumnTongTien.Visible = true;
            this.gridColumnTongTien.VisibleIndex = 4;
            // 
            // grcPhieuNhap
            // 
            this.grcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.grcPhieuNhap.MainView = this.grvPhieuNhap;
            this.grcPhieuNhap.Name = "grcPhieuNhap";
            this.grcPhieuNhap.Size = new System.Drawing.Size(671, 433);
            this.grcPhieuNhap.TabIndex = 3;
            this.grcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhieuNhap});
            // 
            // btnXuatFileExcel
            // 
            this.btnXuatFileExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatFileExcel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnXuatFileExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatFileExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatFileExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFileExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileExcel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXuatFileExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFileExcel.Image")));
            this.btnXuatFileExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFileExcel.Location = new System.Drawing.Point(510, 3);
            this.btnXuatFileExcel.Name = "btnXuatFileExcel";
            this.btnXuatFileExcel.Size = new System.Drawing.Size(157, 50);
            this.btnXuatFileExcel.TabIndex = 20;
            this.btnXuatFileExcel.Text = "   Xuất file Excel";
            this.btnXuatFileExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatFileExcel.UseVisualStyleBackColor = false;
            this.btnXuatFileExcel.Click += new System.EventHandler(this.btnXuatFileExcel_Click);
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChucNang.Controls.Add(this.btnTaoPhieuNhap);
            this.pnlChucNang.Controls.Add(this.btnXuatFileExcel);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 512);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(671, 57);
            this.pnlChucNang.TabIndex = 4;
            // 
            // btnTaoPhieuNhap
            // 
            this.btnTaoPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoPhieuNhap.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTaoPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnTaoPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoPhieuNhap.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaoPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoPhieuNhap.Image")));
            this.btnTaoPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(340, 3);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(164, 50);
            this.btnTaoPhieuNhap.TabIndex = 21;
            this.btnTaoPhieuNhap.Text = "   Tạo phiếu nhập";
            this.btnTaoPhieuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoPhieuNhap.UseVisualStyleBackColor = false;
            this.btnTaoPhieuNhap.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
            // 
            // pnlQuanLyPhieuNhap
            // 
            this.pnlQuanLyPhieuNhap.Controls.Add(this.pnlDSPhieuNhap);
            this.pnlQuanLyPhieuNhap.Controls.Add(this.pnlChucNang);
            this.pnlQuanLyPhieuNhap.Controls.Add(this.pnlChiTietHoaDon);
            this.pnlQuanLyPhieuNhap.Controls.Add(this.pnlThanhTieuDe);
            this.pnlQuanLyPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuanLyPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlQuanLyPhieuNhap.Name = "pnlQuanLyPhieuNhap";
            this.pnlQuanLyPhieuNhap.Size = new System.Drawing.Size(1130, 569);
            this.pnlQuanLyPhieuNhap.TabIndex = 1;
            // 
            // pnlDSPhieuNhap
            // 
            this.pnlDSPhieuNhap.Controls.Add(this.grcPhieuNhap);
            this.pnlDSPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDSPhieuNhap.Location = new System.Drawing.Point(0, 79);
            this.pnlDSPhieuNhap.Name = "pnlDSPhieuNhap";
            this.pnlDSPhieuNhap.Size = new System.Drawing.Size(671, 433);
            this.pnlDSPhieuNhap.TabIndex = 5;
            // 
            // ucQuanLyPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQuanLyPhieuNhap);
            this.Name = "ucQuanLyPhieuNhap";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucQuanLyPhieuNhap_Load);
            this.pnlThanhTieuDe.ResumeLayout(false);
            this.pnlThanhTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcChiTietPhieuNhap)).EndInit();
            this.pnlChiTietHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuNhap)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlQuanLyPhieuNhap.ResumeLayout(false);
            this.pnlDSPhieuNhap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlThanhTieuDe;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChiTietPhieuNhap;
        private DevExpress.XtraGrid.GridControl grcChiTietPhieuNhap;
        private System.Windows.Forms.Panel pnlChiTietHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhieuNhap;
        private DevExpress.XtraGrid.GridControl grcPhieuNhap;
        private System.Windows.Forms.Button btnXuatFileExcel;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Panel pnlQuanLyPhieuNhap;
        private System.Windows.Forms.Button btnTaoPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDonGiaNhap;
        private System.Windows.Forms.Panel pnlDSPhieuNhap;
    }
}
