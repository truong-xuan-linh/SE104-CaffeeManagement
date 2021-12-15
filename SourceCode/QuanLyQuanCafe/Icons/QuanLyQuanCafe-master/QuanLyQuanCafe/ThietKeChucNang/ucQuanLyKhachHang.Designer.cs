namespace ThietKeChucNang
{
    partial class ucQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyKhachHang));
            this.cboLoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.lblLoaiKH = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiemTichLuy = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.grvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLoaiKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiemTichLuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlQuanLyKhachHang = new System.Windows.Forms.Panel();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).BeginInit();
            this.pnlQuanLyKhachHang.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLoaiKhachHang
            // 
            this.cboLoaiKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.cboLoaiKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiKhachHang.FormattingEnabled = true;
            this.cboLoaiKhachHang.Location = new System.Drawing.Point(178, 86);
            this.cboLoaiKhachHang.Name = "cboLoaiKhachHang";
            this.cboLoaiKhachHang.Size = new System.Drawing.Size(223, 26);
            this.cboLoaiKhachHang.TabIndex = 4;
            this.cboLoaiKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboLoaiKhachHang_SelectedIndexChanged);
            // 
            // lblLoaiKH
            // 
            this.lblLoaiKH.AutoSize = true;
            this.lblLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiKH.Location = new System.Drawing.Point(56, 89);
            this.lblLoaiKH.Name = "lblLoaiKH";
            this.lblLoaiKH.Size = new System.Drawing.Size(116, 18);
            this.lblLoaiKH.TabIndex = 3;
            this.lblLoaiKH.Text = "Loại khách hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(339, 395);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 50);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(233, 395);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 19;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(127, 395);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 18;
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
            this.btnThem.Location = new System.Drawing.Point(21, 395);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 17;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(178, 338);
            this.txtDiaChi.MaxLength = 99;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(223, 19);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoDienThoai.Enabled = false;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(178, 238);
            this.txtSoDienThoai.MaxLength = 10;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(223, 19);
            this.txtSoDienThoai.TabIndex = 11;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtDiemTichLuy
            // 
            this.txtDiemTichLuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiemTichLuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiemTichLuy.Enabled = false;
            this.txtDiemTichLuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTichLuy.Location = new System.Drawing.Point(178, 288);
            this.txtDiemTichLuy.MaxLength = 99;
            this.txtDiemTichLuy.Name = "txtDiemTichLuy";
            this.txtDiemTichLuy.Size = new System.Drawing.Size(223, 19);
            this.txtDiemTichLuy.TabIndex = 15;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(178, 188);
            this.txtHoTen.MaxLength = 99;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(223, 19);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKhachHang.Enabled = false;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.Location = new System.Drawing.Point(178, 138);
            this.txtMaKhachHang.MaxLength = 99;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(223, 19);
            this.txtMaKhachHang.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // grcKhachHang
            // 
            this.grcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcKhachHang.Location = new System.Drawing.Point(0, 79);
            this.grcKhachHang.MainView = this.grvKhachHang;
            this.grcKhachHang.Name = "grcKhachHang";
            this.grcKhachHang.Size = new System.Drawing.Size(671, 490);
            this.grcKhachHang.TabIndex = 7;
            this.grcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKhachHang});
            // 
            // grvKhachHang
            // 
            this.grvKhachHang.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvKhachHang.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvKhachHang.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvKhachHang.Appearance.FocusedCell.Options.UseFont = true;
            this.grvKhachHang.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvKhachHang.Appearance.FocusedRow.Options.UseFont = true;
            this.grvKhachHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvKhachHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvKhachHang.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvKhachHang.Appearance.Row.Options.UseFont = true;
            this.grvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaKhachHang,
            this.gridColumnTenKhachHang,
            this.gridColumnLoaiKhachHang,
            this.gridColumnSoDienThoai,
            this.gridColumnDiemTichLuy,
            this.gridColumnDiaChi});
            this.grvKhachHang.GridControl = this.grcKhachHang;
            this.grvKhachHang.Name = "grvKhachHang";
            this.grvKhachHang.OptionsBehavior.Editable = false;
            this.grvKhachHang.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvKhachHang_RowCellClick);
            // 
            // gridColumnMaKhachHang
            // 
            this.gridColumnMaKhachHang.Caption = "Mã Khách Hàng";
            this.gridColumnMaKhachHang.FieldName = "MaKhachHang";
            this.gridColumnMaKhachHang.Name = "gridColumnMaKhachHang";
            this.gridColumnMaKhachHang.Visible = true;
            this.gridColumnMaKhachHang.VisibleIndex = 0;
            // 
            // gridColumnTenKhachHang
            // 
            this.gridColumnTenKhachHang.Caption = "Họ Tên";
            this.gridColumnTenKhachHang.FieldName = "TenKhachHang";
            this.gridColumnTenKhachHang.Name = "gridColumnTenKhachHang";
            this.gridColumnTenKhachHang.Visible = true;
            this.gridColumnTenKhachHang.VisibleIndex = 1;
            // 
            // gridColumnLoaiKhachHang
            // 
            this.gridColumnLoaiKhachHang.Caption = "Loại Khách Hàng";
            this.gridColumnLoaiKhachHang.FieldName = "TenLoaiKhachHang";
            this.gridColumnLoaiKhachHang.Name = "gridColumnLoaiKhachHang";
            this.gridColumnLoaiKhachHang.Visible = true;
            this.gridColumnLoaiKhachHang.VisibleIndex = 2;
            // 
            // gridColumnSoDienThoai
            // 
            this.gridColumnSoDienThoai.Caption = "Số Điện Thoại";
            this.gridColumnSoDienThoai.FieldName = "SoDienThoai";
            this.gridColumnSoDienThoai.Name = "gridColumnSoDienThoai";
            this.gridColumnSoDienThoai.Visible = true;
            this.gridColumnSoDienThoai.VisibleIndex = 3;
            // 
            // gridColumnDiemTichLuy
            // 
            this.gridColumnDiemTichLuy.Caption = "Điểm Tích Lũy";
            this.gridColumnDiemTichLuy.FieldName = "DiemTichLuy";
            this.gridColumnDiemTichLuy.Name = "gridColumnDiemTichLuy";
            this.gridColumnDiemTichLuy.Visible = true;
            this.gridColumnDiemTichLuy.VisibleIndex = 4;
            // 
            // gridColumnDiaChi
            // 
            this.gridColumnDiaChi.Caption = "Địa Chỉ";
            this.gridColumnDiaChi.FieldName = "DiaChi";
            this.gridColumnDiaChi.Name = "gridColumnDiaChi";
            this.gridColumnDiaChi.Visible = true;
            this.gridColumnDiaChi.VisibleIndex = 5;
            // 
            // pnlQuanLyKhachHang
            // 
            this.pnlQuanLyKhachHang.Controls.Add(this.grcKhachHang);
            this.pnlQuanLyKhachHang.Controls.Add(this.pnlTieuDe);
            this.pnlQuanLyKhachHang.Controls.Add(this.pnlChucNang);
            this.pnlQuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuanLyKhachHang.Location = new System.Drawing.Point(0, 0);
            this.pnlQuanLyKhachHang.Name = "pnlQuanLyKhachHang";
            this.pnlQuanLyKhachHang.Size = new System.Drawing.Size(1130, 569);
            this.pnlQuanLyKhachHang.TabIndex = 8;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.label6);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(671, 79);
            this.pnlTieuDe.TabIndex = 5;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChucNang.Controls.Add(this.cboLoaiKhachHang);
            this.pnlChucNang.Controls.Add(this.lblLoaiKH);
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.txtDiaChi);
            this.pnlChucNang.Controls.Add(this.txtSoDienThoai);
            this.pnlChucNang.Controls.Add(this.txtDiemTichLuy);
            this.pnlChucNang.Controls.Add(this.txtHoTen);
            this.pnlChucNang.Controls.Add(this.txtMaKhachHang);
            this.pnlChucNang.Controls.Add(this.label9);
            this.pnlChucNang.Controls.Add(this.label8);
            this.pnlChucNang.Controls.Add(this.label4);
            this.pnlChucNang.Controls.Add(this.label3);
            this.pnlChucNang.Controls.Add(this.label2);
            this.pnlChucNang.Controls.Add(this.label1);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChucNang.Location = new System.Drawing.Point(671, 0);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(459, 569);
            this.pnlChucNang.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm tích lũy:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // ucQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQuanLyKhachHang);
            this.Name = "ucQuanLyKhachHang";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKhachHang)).EndInit();
            this.pnlQuanLyKhachHang.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboLoaiKhachHang;
        private System.Windows.Forms.Label lblLoaiKH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiemTichLuy;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl grcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKhachHang;
        private System.Windows.Forms.Panel pnlQuanLyKhachHang;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLoaiKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiemTichLuy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiaChi;
    }
}
