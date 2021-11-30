namespace ThietKeChucNang
{
    partial class ucThongKeTopPick
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
            this.chartControlTopPick = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlTopPick)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControlTopPick
            // 
            this.chartControlTopPick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlTopPick.Legend.Name = "Default Legend";
            this.chartControlTopPick.Location = new System.Drawing.Point(0, 0);
            this.chartControlTopPick.Name = "chartControlTopPick";
            this.chartControlTopPick.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControlTopPick.Size = new System.Drawing.Size(1130, 569);
            this.chartControlTopPick.TabIndex = 0;
            // 
            // ucThongKeTopPick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControlTopPick);
            this.Name = "ucThongKeTopPick";
            this.Size = new System.Drawing.Size(1130, 569);
            this.Load += new System.EventHandler(this.ucThongKeTopPick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControlTopPick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControlTopPick;
    }
}
