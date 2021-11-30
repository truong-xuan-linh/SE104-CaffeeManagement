namespace ThietKeChucNang
{
    partial class ucQuanLyDoUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyDoUong));
            this.pnlQuanLyDoUong = new System.Windows.Forms.Panel();
            this.grcDoUong = new DevExpress.XtraGrid.GridControl();
            this.grvDoUong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaDoUong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenDoUong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHinhMinhHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.picHinhMinhHoa = new System.Windows.Forms.PictureBox();
            this.txtHinhMinhHoa = new System.Windows.Forms.TextBox();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChonHinhAnh = new System.Windows.Forms.Button();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblViTri = new System.Windows.Forms.Label();
            this.txtTenDoUong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDoUong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogChonHinhAnh = new System.Windows.Forms.OpenFileDialog();
            this.pnlQuanLyDoUong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDoUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDoUong)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhMinhHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuanLyDoUong
            // 
            this.pnlQuanLyDoUong.Controls.Add(this.grcDoUong);
            this.pnlQuanLyDoUong.Controls.Add(this.pnlTieuDe);
            this.pnlQuanLyDoUong.Controls.Add(this.pnlChucNang);
            this.pnlQuanLyDoUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuanLyDoUong.Location = new System.Drawing.Point(0, 0);
            this.pnlQuanLyDoUong.Name = "pnlQuanLyDoUong";
            this.pnlQuanLyDoUong.Size = new System.Drawing.Size(1130, 569);
            this.pnlQuanLyDoUong.TabIndex = 0;
            // 
            // grcDoUong
            // 
            this.grcDoUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDoUong.Location = new System.Drawing.Point(0, 79);
            this.grcDoUong.MainView = this.grvDoUong;
            this.grcDoUong.Name = "grcDoUong";
            this.grcDoUong.Size = new System.Drawing.Size(671, 490);
            this.grcDoUong.TabIndex = 2;
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
            this.gridColumnGia,
            this.gridColumnHinhMinhHoa});
            this.grvDoUong.GridControl = this.grcDoUong;
            this.grvDoUong.Name = "grvDoUong";
            this.grvDoUong.OptionsBehavior.Editable = false;
            this.grvDoUong.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvDoUong_RowCellClick);
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
            // gridColumnHinhMinhHoa
            // 
            this.gridColumnHinhMinhHoa.Caption = "Hình Minh Họa";
            this.gridColumnHinhMinhHoa.FieldName = "HinhMinhHoa";
            this.gridColumnHinhMinhHoa.Name = "gridColumnHinhMinhHoa";
            this.gridColumnHinhMinhHoa.Visible = true;
            this.gridColumnHinhMinhHoa.VisibleIndex = 4;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.label6);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(671, 79);
            this.pnlTieuDe.TabIndex = 1;
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
            // pnlChucNang
            // 
            this.pnlChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChucNang.Controls.Add(this.picHinhMinhHoa);
            this.pnlChucNang.Controls.Add(this.txtHinhMinhHoa);
            this.pnlChucNang.Controls.Add(this.btnDanhMuc);
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.btnChonHinhAnh);
            this.pnlChucNang.Controls.Add(this.cboDanhMuc);
            this.pnlChucNang.Controls.Add(this.txtGiaBan);
            this.pnlChucNang.Controls.Add(this.lblViTri);
            this.pnlChucNang.Controls.Add(this.txtTenDoUong);
            this.pnlChucNang.Controls.Add(this.label1);
            this.pnlChucNang.Controls.Add(this.txtMaDoUong);
            this.pnlChucNang.Controls.Add(this.label5);
            this.pnlChucNang.Controls.Add(this.label2);
            this.pnlChucNang.Controls.Add(this.label4);
            this.pnlChucNang.Controls.Add(this.label3);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChucNang.Location = new System.Drawing.Point(671, 0);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(459, 569);
            this.pnlChucNang.TabIndex = 0;
            // 
            // picHinhMinhHoa
            // 
            this.picHinhMinhHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHinhMinhHoa.Location = new System.Drawing.Point(169, 322);
            this.picHinhMinhHoa.Name = "picHinhMinhHoa";
            this.picHinhMinhHoa.Size = new System.Drawing.Size(150, 150);
            this.picHinhMinhHoa.TabIndex = 27;
            this.picHinhMinhHoa.TabStop = false;
            // 
            // txtHinhMinhHoa
            // 
            this.txtHinhMinhHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHinhMinhHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHinhMinhHoa.Enabled = false;
            this.txtHinhMinhHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhMinhHoa.Location = new System.Drawing.Point(169, 288);
            this.txtHinhMinhHoa.MaxLength = 99;
            this.txtHinhMinhHoa.Name = "txtHinhMinhHoa";
            this.txtHinhMinhHoa.Size = new System.Drawing.Size(223, 19);
            this.txtHinhMinhHoa.TabIndex = 26;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDanhMuc.BackColor = System.Drawing.Color.Silver;
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Location = new System.Drawing.Point(398, 85);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(51, 28);
            this.btnDanhMuc.TabIndex = 25;
            this.btnDanhMuc.Text = "...";
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(338, 491);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 50);
            this.btnLuu.TabIndex = 24;
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
            this.btnSua.Location = new System.Drawing.Point(232, 491);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 23;
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
            this.btnXoa.Location = new System.Drawing.Point(126, 491);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 22;
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
            this.btnThem.Location = new System.Drawing.Point(20, 491);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 21;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChonHinhAnh
            // 
            this.btnChonHinhAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonHinhAnh.BackColor = System.Drawing.Color.Silver;
            this.btnChonHinhAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonHinhAnh.FlatAppearance.BorderSize = 0;
            this.btnChonHinhAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonHinhAnh.Location = new System.Drawing.Point(398, 285);
            this.btnChonHinhAnh.Name = "btnChonHinhAnh";
            this.btnChonHinhAnh.Size = new System.Drawing.Size(51, 28);
            this.btnChonHinhAnh.TabIndex = 20;
            this.btnChonHinhAnh.Text = "...";
            this.btnChonHinhAnh.UseVisualStyleBackColor = false;
            this.btnChonHinhAnh.Click += new System.EventHandler(this.btnChonHinhAnh_Click);
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.BackColor = System.Drawing.SystemColors.Window;
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(169, 86);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(223, 26);
            this.cboDanhMuc.TabIndex = 6;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(169, 238);
            this.txtGiaBan.MaxLength = 7;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(223, 19);
            this.txtGiaBan.TabIndex = 19;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTri.Location = new System.Drawing.Point(56, 89);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(76, 18);
            this.lblViTri.TabIndex = 5;
            this.lblViTri.Text = "Danh mục";
            // 
            // txtTenDoUong
            // 
            this.txtTenDoUong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDoUong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDoUong.Enabled = false;
            this.txtTenDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoUong.Location = new System.Drawing.Point(169, 188);
            this.txtTenDoUong.MaxLength = 99;
            this.txtTenDoUong.Name = "txtTenDoUong";
            this.txtTenDoUong.Size = new System.Drawing.Size(223, 19);
            this.txtTenDoUong.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN ĐỒ UỐNG";
            // 
            // txtMaDoUong
            // 
            this.txtMaDoUong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaDoUong.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaDoUong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDoUong.Enabled = false;
            this.txtMaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoUong.Location = new System.Drawing.Point(169, 138);
            this.txtMaDoUong.MaxLength = 99;
            this.txtMaDoUong.Name = "txtMaDoUong";
            this.txtMaDoUong.Size = new System.Drawing.Size(223, 19);
            this.txtMaDoUong.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hình minh họa:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã đồ uống:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên đồ uống:";
            // 
            // ucQuanLyDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQuanLyDoUong);
            this.Name = "ucQuanLyDoUong";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucQuanLyDoUong_Load);
            this.pnlQuanLyDoUong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDoUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDoUong)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhMinhHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyDoUong;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl grcDoUong;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenDoUong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHinhMinhHoa;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtTenDoUong;
        private System.Windows.Forms.TextBox txtMaDoUong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChonHinhAnh;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHinhMinhHoa;
        private System.Windows.Forms.PictureBox picHinhMinhHoa;
        private System.Windows.Forms.OpenFileDialog openFileDialogChonHinhAnh;
    }
}
