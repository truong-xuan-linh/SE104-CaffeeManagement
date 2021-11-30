using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;

namespace ThietKeChucNang
{
    public partial class ucCaiDat : UserControl
    {
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        public ucCaiDat()
        {
            InitializeComponent();
        }
        private void btnChonDuongDan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtImagesPath.Text = fbd.SelectedPath;
            if(txtImagesPath.Text != string.Empty)
                btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bllCaiDat.SaveImagesPath(txtImagesPath.Text + @"\");
            txtImagesPath.Clear();
            btnLuu.Enabled = false;
            MessageBox.Show("Done!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ucCaiDat_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            if (themeColor == "#ff5722")
                rdMacDinh.Checked = true;
            else if (themeColor == "#070094")
                rdXanhDaiDuong.Checked = true;
            else if (themeColor == "#059400")
                rdXanhLaMa.Checked = true;
            else
                rdHongCaTinh.Checked = true;
        }

        private void btnLuuMau_Click(object sender, EventArgs e)
        {
            string macDinh = "#ff5722";
            string xanhDaiDuong = "#070094";
            string xanhLaMa = "#059400";
            string hongCaTinh = "#940063";
            if (rdMacDinh.Checked)
                bllCaiDat.SaveThemeColor(macDinh);
            else if (rdXanhDaiDuong.Checked)
                bllCaiDat.SaveThemeColor(xanhDaiDuong);
            else if (rdXanhLaMa.Checked)
                bllCaiDat.SaveThemeColor(xanhLaMa);
            else
                bllCaiDat.SaveThemeColor(hongCaTinh);
            MessageBox.Show("Khởi động lại ứng dụng để áp dụng cài đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
