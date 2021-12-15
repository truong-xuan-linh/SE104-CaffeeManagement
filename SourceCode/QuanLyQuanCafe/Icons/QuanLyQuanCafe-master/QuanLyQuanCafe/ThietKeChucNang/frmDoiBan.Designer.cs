namespace ThietKeChucNang
{
    partial class frmDoiBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiBan));
            this.cboViTri = new System.Windows.Forms.ComboBox();
            this.lblViTri = new System.Windows.Forms.Label();
            this.fpnlBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDoiBan = new System.Windows.Forms.Button();
            this.pnlThanhTieuDe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.pnlThanhTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboViTri
            // 
            this.cboViTri.BackColor = System.Drawing.SystemColors.Window;
            this.cboViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboViTri.FormattingEnabled = true;
            this.cboViTri.Location = new System.Drawing.Point(87, 54);
            this.cboViTri.Name = "cboViTri";
            this.cboViTri.Size = new System.Drawing.Size(215, 24);
            this.cboViTri.TabIndex = 4;
            this.cboViTri.SelectedIndexChanged += new System.EventHandler(this.cboViTri_SelectedIndexChanged);
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViTri.Location = new System.Drawing.Point(36, 57);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(45, 16);
            this.lblViTri.TabIndex = 3;
            this.lblViTri.Text = "Vị Trí: ";
            // 
            // fpnlBan
            // 
            this.fpnlBan.AutoScroll = true;
            this.fpnlBan.Location = new System.Drawing.Point(35, 93);
            this.fpnlBan.Name = "fpnlBan";
            this.fpnlBan.Size = new System.Drawing.Size(679, 332);
            this.fpnlBan.TabIndex = 5;
            // 
            // btnDoiBan
            // 
            this.btnDoiBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoiBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnDoiBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiBan.FlatAppearance.BorderSize = 0;
            this.btnDoiBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiBan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoiBan.Location = new System.Drawing.Point(639, 431);
            this.btnDoiBan.Name = "btnDoiBan";
            this.btnDoiBan.Size = new System.Drawing.Size(75, 45);
            this.btnDoiBan.TabIndex = 13;
            this.btnDoiBan.Text = "Đổi";
            this.btnDoiBan.UseVisualStyleBackColor = false;
            this.btnDoiBan.Visible = false;
            this.btnDoiBan.Click += new System.EventHandler(this.btnDoiBan_Click);
            // 
            // pnlThanhTieuDe
            // 
            this.pnlThanhTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.pnlThanhTieuDe.Controls.Add(this.label1);
            this.pnlThanhTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThanhTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlThanhTieuDe.Name = "pnlThanhTieuDe";
            this.pnlThanhTieuDe.Size = new System.Drawing.Size(750, 37);
            this.pnlThanhTieuDe.TabIndex = 14;
            this.pnlThanhTieuDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlThanhTieuDe_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đổi bàn";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 37);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1, 451);
            this.pnlLeft.TabIndex = 15;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(749, 37);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1, 451);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(1, 487);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(748, 1);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblTenBan
            // 
            this.lblTenBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.lblTenBan.Location = new System.Drawing.Point(473, 51);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(89, 24);
            this.lblTenBan.TabIndex = 16;
            this.lblTenBan.Text = "Tên Bàn";
            // 
            // frmDoiBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlThanhTieuDe);
            this.Controls.Add(this.btnDoiBan);
            this.Controls.Add(this.fpnlBan);
            this.Controls.Add(this.cboViTri);
            this.Controls.Add(this.lblViTri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi bàn";
            this.Load += new System.EventHandler(this.frmDoiBan_Load);
            this.pnlThanhTieuDe.ResumeLayout(false);
            this.pnlThanhTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboViTri;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.FlowLayoutPanel fpnlBan;
        private System.Windows.Forms.Button btnDoiBan;
        private System.Windows.Forms.Panel pnlThanhTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTenBan;
    }
}