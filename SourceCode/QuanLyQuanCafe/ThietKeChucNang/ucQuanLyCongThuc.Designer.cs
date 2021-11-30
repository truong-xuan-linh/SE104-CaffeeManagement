namespace ThietKeChucNang
{
    partial class ucQuanLyCongThuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyCongThuc));
            this.pnlQuanLyCongThuc = new System.Windows.Forms.Panel();
            this.grcDoUong = new DevExpress.XtraGrid.GridControl();
            this.grvDoUong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaDoUong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenDoUong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCongThuc = new System.Windows.Forms.Panel();
            this.grcCongThuc = new DevExpress.XtraGrid.GridControl();
            this.grvCongThuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaDoUong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMaNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTieuDe2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuanLyCongThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDoUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDoUong)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.pnlCongThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCongThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCongThuc)).BeginInit();
            this.pnlChucNang.SuspendLayout();
            this.pnlTieuDe2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuanLyCongThuc
            // 
            this.pnlQuanLyCongThuc.Controls.Add(this.grcDoUong);
            this.pnlQuanLyCongThuc.Controls.Add(this.pnlTieuDe);
            this.pnlQuanLyCongThuc.Controls.Add(this.pnlCongThuc);
            this.pnlQuanLyCongThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuanLyCongThuc.Location = new System.Drawing.Point(0, 0);
            this.pnlQuanLyCongThuc.Name = "pnlQuanLyCongThuc";
            this.pnlQuanLyCongThuc.Size = new System.Drawing.Size(1130, 569);
            this.pnlQuanLyCongThuc.TabIndex = 0;
            // 
            // grcDoUong
            // 
            this.grcDoUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDoUong.Location = new System.Drawing.Point(0, 79);
            this.grcDoUong.MainView = this.grvDoUong;
            this.grcDoUong.Name = "grcDoUong";
            this.grcDoUong.Size = new System.Drawing.Size(671, 490);
            this.grcDoUong.TabIndex = 3;
            this.grcDoUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDoUong});
            // 
            // grvDoUong
            // 
            this.grvDoUong.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvDoUong.Appearance.FocusedRow.Options.UseFont = true;
            this.grvDoUong.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvDoUong.Appearance.Row.Options.UseFont = true;
            this.grvDoUong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaDoUong,
            this.gridColumnTenDoUong,
            this.gridColumnTenDanhMuc,
            this.gridColumnGia});
            this.grvDoUong.GridControl = this.grcDoUong;
            this.grvDoUong.Name = "grvDoUong";
            this.grvDoUong.OptionsBehavior.Editable = false;
            this.grvDoUong.OptionsCustomization.AllowGroup = false;
            this.grvDoUong.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvDoUong_FocusedRowChanged);
            // 
            // gridColumnMaDoUong
            // 
            this.gridColumnMaDoUong.Caption = "Mã Đồ Uống";
            this.gridColumnMaDoUong.FieldName = "MaDoUong";
            this.gridColumnMaDoUong.Name = "gridColumnMaDoUong";
            this.gridColumnMaDoUong.Visible = true;
            this.gridColumnMaDoUong.VisibleIndex = 0;
            // 
            // gridColumnTenDoUong
            // 
            this.gridColumnTenDoUong.Caption = "Tên Đồ Uống";
            this.gridColumnTenDoUong.FieldName = "TenDoUong";
            this.gridColumnTenDoUong.Name = "gridColumnTenDoUong";
            this.gridColumnTenDoUong.Visible = true;
            this.gridColumnTenDoUong.VisibleIndex = 1;
            // 
            // gridColumnTenDanhMuc
            // 
            this.gridColumnTenDanhMuc.Caption = "Danh Mục";
            this.gridColumnTenDanhMuc.FieldName = "TenDanhMuc";
            this.gridColumnTenDanhMuc.Name = "gridColumnTenDanhMuc";
            this.gridColumnTenDanhMuc.Visible = true;
            this.gridColumnTenDanhMuc.VisibleIndex = 3;
            // 
            // gridColumnGia
            // 
            this.gridColumnGia.Caption = "Giá Bán";
            this.gridColumnGia.FieldName = "Gia";
            this.gridColumnGia.Name = "gridColumnGia";
            this.gridColumnGia.Visible = true;
            this.gridColumnGia.VisibleIndex = 2;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.label6);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(671, 79);
            this.pnlTieuDe.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "DANH SÁCH ĐỒ UỐNG";
            // 
            // pnlCongThuc
            // 
            this.pnlCongThuc.Controls.Add(this.grcCongThuc);
            this.pnlCongThuc.Controls.Add(this.pnlChucNang);
            this.pnlCongThuc.Controls.Add(this.pnlTieuDe2);
            this.pnlCongThuc.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCongThuc.Location = new System.Drawing.Point(671, 0);
            this.pnlCongThuc.Name = "pnlCongThuc";
            this.pnlCongThuc.Size = new System.Drawing.Size(459, 569);
            this.pnlCongThuc.TabIndex = 0;
            // 
            // grcCongThuc
            // 
            this.grcCongThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcCongThuc.Location = new System.Drawing.Point(0, 79);
            this.grcCongThuc.MainView = this.grvCongThuc;
            this.grcCongThuc.Name = "grcCongThuc";
            this.grcCongThuc.Size = new System.Drawing.Size(459, 301);
            this.grcCongThuc.TabIndex = 5;
            this.grcCongThuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCongThuc});
            // 
            // grvCongThuc
            // 
            this.grvCongThuc.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvCongThuc.Appearance.FocusedRow.Options.UseFont = true;
            this.grvCongThuc.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvCongThuc.Appearance.Row.Options.UseFont = true;
            this.grvCongThuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaDoUong1,
            this.gridColumnMaNguyenLieu,
            this.gridColumnTenNguyenLieu,
            this.gridColumnSoLuong,
            this.gridColumnDonViTinh});
            this.grvCongThuc.GridControl = this.grcCongThuc;
            this.grvCongThuc.Name = "grvCongThuc";
            this.grvCongThuc.OptionsBehavior.Editable = false;
            this.grvCongThuc.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvCongThuc_RowCellClick);
            // 
            // gridColumnMaDoUong1
            // 
            this.gridColumnMaDoUong1.Caption = "Mã Đồ Uống";
            this.gridColumnMaDoUong1.FieldName = "MaDoUong";
            this.gridColumnMaDoUong1.Name = "gridColumnMaDoUong1";
            // 
            // gridColumnMaNguyenLieu
            // 
            this.gridColumnMaNguyenLieu.Caption = "Mã Nguyên Liệu";
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
            // gridColumnSoLuong
            // 
            this.gridColumnSoLuong.Caption = "Số Lượng";
            this.gridColumnSoLuong.FieldName = "SoLuong";
            this.gridColumnSoLuong.Name = "gridColumnSoLuong";
            this.gridColumnSoLuong.Visible = true;
            this.gridColumnSoLuong.VisibleIndex = 1;
            // 
            // gridColumnDonViTinh
            // 
            this.gridColumnDonViTinh.Caption = "Đơn Vị Tính";
            this.gridColumnDonViTinh.FieldName = "DonViTinh";
            this.gridColumnDonViTinh.Name = "gridColumnDonViTinh";
            this.gridColumnDonViTinh.Visible = true;
            this.gridColumnDonViTinh.VisibleIndex = 2;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.lblDonViTinh);
            this.pnlChucNang.Controls.Add(this.txtSoLuong);
            this.pnlChucNang.Controls.Add(this.label2);
            this.pnlChucNang.Controls.Add(this.cboNguyenLieu);
            this.pnlChucNang.Controls.Add(this.label3);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 380);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(459, 189);
            this.pnlChucNang.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(237, 113);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(131, 113);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 24;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Location = new System.Drawing.Point(187, 54);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(37, 18);
            this.lblDonViTinh.TabIndex = 23;
            this.lblDonViTinh.Text = "DVT";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(135, 53);
            this.txtSoLuong.MaxLength = 3;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(46, 19);
            this.txtSoLuong.TabIndex = 22;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số lượng:";
            // 
            // cboNguyenLieu
            // 
            this.cboNguyenLieu.BackColor = System.Drawing.SystemColors.Window;
            this.cboNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNguyenLieu.FormattingEnabled = true;
            this.cboNguyenLieu.Location = new System.Drawing.Point(135, 9);
            this.cboNguyenLieu.Name = "cboNguyenLieu";
            this.cboNguyenLieu.Size = new System.Drawing.Size(156, 26);
            this.cboNguyenLieu.TabIndex = 20;
            this.cboNguyenLieu.SelectedIndexChanged += new System.EventHandler(this.cboNguyenLieu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên nguyên liệu:";
            // 
            // pnlTieuDe2
            // 
            this.pnlTieuDe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe2.Controls.Add(this.label1);
            this.pnlTieuDe2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe2.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe2.Name = "pnlTieuDe2";
            this.pnlTieuDe2.Size = new System.Drawing.Size(459, 79);
            this.pnlTieuDe2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÔNG THỨC PHA CHẾ";
            // 
            // ucQuanLyCongThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQuanLyCongThuc);
            this.Name = "ucQuanLyCongThuc";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucQuanLyCongThuc_Load);
            this.pnlQuanLyCongThuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDoUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDoUong)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.pnlCongThuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcCongThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCongThuc)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            this.pnlTieuDe2.ResumeLayout(false);
            this.pnlTieuDe2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyCongThuc;
        private System.Windows.Forms.Panel pnlCongThuc;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl grcDoUong;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGia;
        private System.Windows.Forms.Panel pnlTieuDe2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grcCongThuc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCongThuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDonViTinh;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNguyenLieu;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaDoUong1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaNguyenLieu;
    }
}
