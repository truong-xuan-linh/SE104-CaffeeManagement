namespace ThietKeChucNang
{
    partial class ucQuanLyNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyNguyenLieu));
            this.pnlQuanLyNguyenLieu = new System.Windows.Forms.Panel();
            this.grcNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.grvNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenNguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoLuongTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.txtMaNguyenLieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuanLyNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNguyenLieu)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuanLyNguyenLieu
            // 
            this.pnlQuanLyNguyenLieu.Controls.Add(this.grcNguyenLieu);
            this.pnlQuanLyNguyenLieu.Controls.Add(this.pnlTieuDe);
            this.pnlQuanLyNguyenLieu.Controls.Add(this.pnlChucNang);
            this.pnlQuanLyNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuanLyNguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.pnlQuanLyNguyenLieu.Name = "pnlQuanLyNguyenLieu";
            this.pnlQuanLyNguyenLieu.Size = new System.Drawing.Size(1130, 569);
            this.pnlQuanLyNguyenLieu.TabIndex = 0;
            // 
            // grcNguyenLieu
            // 
            this.grcNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcNguyenLieu.Location = new System.Drawing.Point(0, 79);
            this.grcNguyenLieu.MainView = this.grvNguyenLieu;
            this.grcNguyenLieu.Name = "grcNguyenLieu";
            this.grcNguyenLieu.Size = new System.Drawing.Size(671, 490);
            this.grcNguyenLieu.TabIndex = 9;
            this.grcNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNguyenLieu});
            // 
            // grvNguyenLieu
            // 
            this.grvNguyenLieu.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvNguyenLieu.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvNguyenLieu.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvNguyenLieu.Appearance.FocusedCell.Options.UseFont = true;
            this.grvNguyenLieu.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvNguyenLieu.Appearance.FocusedRow.Options.UseFont = true;
            this.grvNguyenLieu.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvNguyenLieu.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvNguyenLieu.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvNguyenLieu.Appearance.Row.Options.UseFont = true;
            this.grvNguyenLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaNguyenLieu,
            this.gridColumnTenNguyenLieu,
            this.gridColumnSoLuongTon,
            this.gridColumnDonViTinh});
            this.grvNguyenLieu.GridControl = this.grcNguyenLieu;
            this.grvNguyenLieu.Name = "grvNguyenLieu";
            this.grvNguyenLieu.OptionsBehavior.Editable = false;
            this.grvNguyenLieu.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvNguyenLieu_RowCellClick);
            // 
            // gridColumnMaNguyenLieu
            // 
            this.gridColumnMaNguyenLieu.Caption = "Mã Nguyên Liệu";
            this.gridColumnMaNguyenLieu.FieldName = "MaNguyenLieu";
            this.gridColumnMaNguyenLieu.Name = "gridColumnMaNguyenLieu";
            this.gridColumnMaNguyenLieu.Visible = true;
            this.gridColumnMaNguyenLieu.VisibleIndex = 0;
            // 
            // gridColumnTenNguyenLieu
            // 
            this.gridColumnTenNguyenLieu.Caption = "Tên Nguyên Liệu";
            this.gridColumnTenNguyenLieu.FieldName = "TenNguyenLieu";
            this.gridColumnTenNguyenLieu.Name = "gridColumnTenNguyenLieu";
            this.gridColumnTenNguyenLieu.Visible = true;
            this.gridColumnTenNguyenLieu.VisibleIndex = 1;
            // 
            // gridColumnSoLuongTon
            // 
            this.gridColumnSoLuongTon.Caption = "Số Lượng Tồn";
            this.gridColumnSoLuongTon.FieldName = "SoLuongTon";
            this.gridColumnSoLuongTon.Name = "gridColumnSoLuongTon";
            this.gridColumnSoLuongTon.Visible = true;
            this.gridColumnSoLuongTon.VisibleIndex = 2;
            // 
            // gridColumnDonViTinh
            // 
            this.gridColumnDonViTinh.Caption = "Đơn Vị Tính";
            this.gridColumnDonViTinh.FieldName = "DonViTinh";
            this.gridColumnDonViTinh.Name = "gridColumnDonViTinh";
            this.gridColumnDonViTinh.Visible = true;
            this.gridColumnDonViTinh.VisibleIndex = 3;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.label6);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(671, 79);
            this.pnlTieuDe.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChucNang.Controls.Add(this.lblSoLuongTon);
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.txtDonViTinh);
            this.pnlChucNang.Controls.Add(this.txtTenNguyenLieu);
            this.pnlChucNang.Controls.Add(this.txtMaNguyenLieu);
            this.pnlChucNang.Controls.Add(this.label8);
            this.pnlChucNang.Controls.Add(this.label5);
            this.pnlChucNang.Controls.Add(this.label3);
            this.pnlChucNang.Controls.Add(this.label2);
            this.pnlChucNang.Controls.Add(this.label1);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChucNang.Location = new System.Drawing.Point(671, 0);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(459, 569);
            this.pnlChucNang.TabIndex = 7;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTon.Location = new System.Drawing.Point(176, 229);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(35, 18);
            this.lblSoLuongTon.TabIndex = 21;
            this.lblSoLuongTon.Text = "SLT";
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
            this.btnLuu.Location = new System.Drawing.Point(337, 276);
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
            this.btnSua.Location = new System.Drawing.Point(231, 276);
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
            this.btnXoa.Location = new System.Drawing.Point(125, 276);
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
            this.btnThem.Location = new System.Drawing.Point(19, 276);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 17;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonViTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDonViTinh.Enabled = false;
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(179, 178);
            this.txtDonViTinh.MaxLength = 99;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(223, 19);
            this.txtDonViTinh.TabIndex = 12;
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNguyenLieu.Enabled = false;
            this.txtTenNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(179, 128);
            this.txtTenNguyenLieu.MaxLength = 99;
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(223, 19);
            this.txtTenNguyenLieu.TabIndex = 10;
            // 
            // txtMaNguyenLieu
            // 
            this.txtMaNguyenLieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaNguyenLieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNguyenLieu.Enabled = false;
            this.txtMaNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(179, 78);
            this.txtMaNguyenLieu.MaxLength = 99;
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(223, 19);
            this.txtMaNguyenLieu.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng tồn:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên nguyên liệu:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nguyên liệu:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NGUYÊN LIỆU";
            // 
            // ucQuanLyNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQuanLyNguyenLieu);
            this.Name = "ucQuanLyNguyenLieu";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucQuanLyNguyenLieu_Load);
            this.pnlQuanLyNguyenLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNguyenLieu)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyNguyenLieu;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.TextBox txtMaNguyenLieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoLuongTon;
        private DevExpress.XtraGrid.GridControl grcNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoLuongTon;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDonViTinh;
    }
}
