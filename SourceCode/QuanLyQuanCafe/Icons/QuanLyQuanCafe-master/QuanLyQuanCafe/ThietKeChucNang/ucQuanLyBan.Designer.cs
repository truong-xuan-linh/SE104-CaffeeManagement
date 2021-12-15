namespace ThietKeChucNang
{
    partial class ucQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyBan));
            this.pnlQuanLyBan = new System.Windows.Forms.Panel();
            this.grcBan = new DevExpress.XtraGrid.GridControl();
            this.grvBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTenViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblViTri = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuanLyBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBan)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuanLyBan
            // 
            this.pnlQuanLyBan.Controls.Add(this.grcBan);
            this.pnlQuanLyBan.Controls.Add(this.pnlTieuDe);
            this.pnlQuanLyBan.Controls.Add(this.pnlChucNang);
            this.pnlQuanLyBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuanLyBan.Location = new System.Drawing.Point(0, 0);
            this.pnlQuanLyBan.Name = "pnlQuanLyBan";
            this.pnlQuanLyBan.Size = new System.Drawing.Size(1130, 569);
            this.pnlQuanLyBan.TabIndex = 0;
            // 
            // grcBan
            // 
            this.grcBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBan.Location = new System.Drawing.Point(0, 79);
            this.grcBan.MainView = this.grvBan;
            this.grcBan.Name = "grcBan";
            this.grcBan.Size = new System.Drawing.Size(671, 490);
            this.grcBan.TabIndex = 2;
            this.grcBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBan});
            // 
            // grvBan
            // 
            this.grvBan.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBan.Appearance.FocusedCell.Options.UseFont = true;
            this.grvBan.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBan.Appearance.FocusedRow.Options.UseFont = true;
            this.grvBan.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBan.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvBan.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBan.Appearance.Row.Options.UseFont = true;
            this.grvBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaBan,
            this.gridColumnTenBan,
            this.gridColumnTenViTri,
            this.gridColumnTrangThai});
            this.grvBan.GridControl = this.grcBan;
            this.grvBan.Name = "grvBan";
            this.grvBan.OptionsBehavior.Editable = false;
            this.grvBan.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvBan_RowCellClick);
            // 
            // gridColumnMaBan
            // 
            this.gridColumnMaBan.Caption = "Mã Bàn";
            this.gridColumnMaBan.FieldName = "MaBan";
            this.gridColumnMaBan.Name = "gridColumnMaBan";
            this.gridColumnMaBan.Visible = true;
            this.gridColumnMaBan.VisibleIndex = 0;
            // 
            // gridColumnTenBan
            // 
            this.gridColumnTenBan.Caption = "Tên Bàn";
            this.gridColumnTenBan.FieldName = "TenBan";
            this.gridColumnTenBan.Name = "gridColumnTenBan";
            this.gridColumnTenBan.Visible = true;
            this.gridColumnTenBan.VisibleIndex = 1;
            // 
            // gridColumnTenViTri
            // 
            this.gridColumnTenViTri.Caption = "Vị Trí";
            this.gridColumnTenViTri.FieldName = "TenViTri";
            this.gridColumnTenViTri.Name = "gridColumnTenViTri";
            this.gridColumnTenViTri.Visible = true;
            this.gridColumnTenViTri.VisibleIndex = 2;
            // 
            // gridColumnTrangThai
            // 
            this.gridColumnTrangThai.Caption = "Trạng thái";
            this.gridColumnTrangThai.FieldName = "TrangThai";
            this.gridColumnTrangThai.Name = "gridColumnTrangThai";
            this.gridColumnTrangThai.Visible = true;
            this.gridColumnTrangThai.VisibleIndex = 3;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTieuDe.Controls.Add(this.label4);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(671, 79);
            this.pnlTieuDe.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "DANH SÁCH BÀN";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChucNang.Controls.Add(this.lblTrangThai);
            this.pnlChucNang.Controls.Add(this.label5);
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.cboViTri);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.lblViTri);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.txtTenBan);
            this.pnlChucNang.Controls.Add(this.txtMaBan);
            this.pnlChucNang.Controls.Add(this.label3);
            this.pnlChucNang.Controls.Add(this.label2);
            this.pnlChucNang.Controls.Add(this.label1);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChucNang.Location = new System.Drawing.Point(671, 0);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(459, 569);
            this.pnlChucNang.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(160, 239);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(74, 18);
            this.lblTrangThai.TabIndex = 26;
            this.lblTrangThai.Text = "TrangThai";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Trạng thái:";
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
            this.btnLuu.Location = new System.Drawing.Point(339, 327);
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
            this.btnSua.Location = new System.Drawing.Point(233, 327);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 23;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboViTri
            // 
            this.cboViTri.BackColor = System.Drawing.SystemColors.Window;
            this.cboViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Location = new System.Drawing.Point(148, 86);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(223, 26);
            this.cboViTri.TabIndex = 6;
            this.cboViTri.SelectedIndexChanged += new System.EventHandler(this.cboViTri_SelectedIndexChanged);
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
            this.btnXoa.Location = new System.Drawing.Point(127, 327);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTri.Location = new System.Drawing.Point(77, 89);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(36, 18);
            this.lblViTri.TabIndex = 5;
            this.lblViTri.Text = "Vị trí";
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
            this.btnThem.Location = new System.Drawing.Point(21, 327);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 50);
            this.btnThem.TabIndex = 21;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenBan
            // 
            this.txtTenBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenBan.Enabled = false;
            this.txtTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Location = new System.Drawing.Point(148, 188);
            this.txtTenBan.MaxLength = 99;
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(223, 19);
            this.txtTenBan.TabIndex = 14;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaBan.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaBan.Enabled = false;
            this.txtMaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.Location = new System.Drawing.Point(148, 138);
            this.txtMaBan.MaxLength = 99;
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(223, 19);
            this.txtMaBan.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên bàn:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã bàn:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "THÔNG TIN BÀN";
            // 
            // ucQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQuanLyBan);
            this.Name = "ucQuanLyBan";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucQuanLyBan_Load);
            this.pnlQuanLyBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBan)).EndInit();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuanLyBan;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.ComboBox cboViTri;
        private System.Windows.Forms.Label lblViTri;
        private DevExpress.XtraGrid.GridControl grcBan;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenBan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenViTri;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label5;
    }
}
