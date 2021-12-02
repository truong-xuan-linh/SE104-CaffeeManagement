namespace ThietKeChucNang
{
    partial class ucKhoNVL
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
            this.fpnlDanhMucQuanLy = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlKhoNVL = new System.Windows.Forms.Panel();
            this.btnQLNguyenLieu = new System.Windows.Forms.Button();
            this.btnQLPhieuNhap = new System.Windows.Forms.Button();
            this.fpnlDanhMucQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlDanhMucQuanLy
            // 
            this.fpnlDanhMucQuanLy.BackColor = System.Drawing.SystemColors.Control;
            this.fpnlDanhMucQuanLy.Controls.Add(this.btnQLNguyenLieu);
            this.fpnlDanhMucQuanLy.Controls.Add(this.btnQLPhieuNhap);
            this.fpnlDanhMucQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpnlDanhMucQuanLy.Location = new System.Drawing.Point(0, 0);
            this.fpnlDanhMucQuanLy.Name = "fpnlDanhMucQuanLy";
            this.fpnlDanhMucQuanLy.Size = new System.Drawing.Size(1130, 80);
            this.fpnlDanhMucQuanLy.TabIndex = 1;
            // 
            // pnlKhoNVL
            // 
            this.pnlKhoNVL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKhoNVL.Location = new System.Drawing.Point(0, 80);
            this.pnlKhoNVL.Name = "pnlKhoNVL";
            this.pnlKhoNVL.Size = new System.Drawing.Size(1130, 569);
            this.pnlKhoNVL.TabIndex = 2;
            // 
            // btnQLNguyenLieu
            // 
            this.btnQLNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnQLNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNguyenLieu.FlatAppearance.BorderSize = 0;
            this.btnQLNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNguyenLieu.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLNguyenLieu.Image = global::ThietKeChucNang.Properties.Resources.outline_format_list_bulleted_white_24dp;
            this.btnQLNguyenLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNguyenLieu.Location = new System.Drawing.Point(3, 3);
            this.btnQLNguyenLieu.Name = "btnQLNguyenLieu";
            this.btnQLNguyenLieu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNguyenLieu.Size = new System.Drawing.Size(174, 77);
            this.btnQLNguyenLieu.TabIndex = 1;
            this.btnQLNguyenLieu.Text = "Nguyên Liệu";
            this.btnQLNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNguyenLieu.UseVisualStyleBackColor = false;
            this.btnQLNguyenLieu.Click += new System.EventHandler(this.btnQLNguyenLieu_Click);
            // 
            // btnQLPhieuNhap
            // 
            this.btnQLPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnQLPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnQLPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhieuNhap.ForeColor = System.Drawing.Color.Transparent;
            this.btnQLPhieuNhap.Image = global::ThietKeChucNang.Properties.Resources.outline_sticky_note_2_white_24dp;
            this.btnQLPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhieuNhap.Location = new System.Drawing.Point(183, 3);
            this.btnQLPhieuNhap.Name = "btnQLPhieuNhap";
            this.btnQLPhieuNhap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLPhieuNhap.Size = new System.Drawing.Size(174, 77);
            this.btnQLPhieuNhap.TabIndex = 2;
            this.btnQLPhieuNhap.Text = "  Phiếu Nhập";
            this.btnQLPhieuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLPhieuNhap.UseVisualStyleBackColor = false;
            this.btnQLPhieuNhap.Click += new System.EventHandler(this.btnQLPhieuNhap_Click);
            // 
            // ucKhoNVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlKhoNVL);
            this.Controls.Add(this.fpnlDanhMucQuanLy);
            this.Name = "ucKhoNVL";
            this.Size = new System.Drawing.Size(1130, 649);
            this.Load += new System.EventHandler(this.ucKhoNVL_Load);
            this.fpnlDanhMucQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlDanhMucQuanLy;
        private System.Windows.Forms.Button btnQLNguyenLieu;
        private System.Windows.Forms.Button btnQLPhieuNhap;
        private System.Windows.Forms.Panel pnlKhoNVL;
    }
}
