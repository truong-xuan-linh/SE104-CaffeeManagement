namespace ThietKeChucNang
{
    partial class ucThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThongKe));
            this.fpnlDanhMucQuanLy = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTopPick = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.fpnlDanhMucQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlDanhMucQuanLy
            // 
            this.fpnlDanhMucQuanLy.BackColor = System.Drawing.SystemColors.Control;
            this.fpnlDanhMucQuanLy.Controls.Add(this.btnTopPick);
            this.fpnlDanhMucQuanLy.Controls.Add(this.btnDoanhThu);
            this.fpnlDanhMucQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpnlDanhMucQuanLy.Location = new System.Drawing.Point(0, 0);
            this.fpnlDanhMucQuanLy.Name = "fpnlDanhMucQuanLy";
            this.fpnlDanhMucQuanLy.Size = new System.Drawing.Size(1130, 80);
            this.fpnlDanhMucQuanLy.TabIndex = 1;
            // 
            // btnTopPick
            // 
            this.btnTopPick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnTopPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopPick.FlatAppearance.BorderSize = 0;
            this.btnTopPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopPick.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTopPick.Image = ((System.Drawing.Image)(resources.GetObject("btnTopPick.Image")));
            this.btnTopPick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopPick.Location = new System.Drawing.Point(3, 3);
            this.btnTopPick.Name = "btnTopPick";
            this.btnTopPick.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTopPick.Size = new System.Drawing.Size(150, 77);
            this.btnTopPick.TabIndex = 1;
            this.btnTopPick.Text = "  Top pick";
            this.btnTopPick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopPick.UseVisualStyleBackColor = false;
            this.btnTopPick.Click += new System.EventHandler(this.btnTopPick_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.Image")));
            this.btnDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.Location = new System.Drawing.Point(159, 3);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDoanhThu.Size = new System.Drawing.Size(150, 77);
            this.btnDoanhThu.TabIndex = 2;
            this.btnDoanhThu.Text = "  Doanh thu";
            this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongKe.Location = new System.Drawing.Point(0, 80);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(1130, 569);
            this.pnlThongKe.TabIndex = 2;
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlThongKe);
            this.Controls.Add(this.fpnlDanhMucQuanLy);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1130, 649);
            this.Load += new System.EventHandler(this.ucThongKe_Load);
            this.fpnlDanhMucQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlDanhMucQuanLy;
        private System.Windows.Forms.Button btnTopPick;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel pnlThongKe;
    }
}
