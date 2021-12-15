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
    public partial class ucThongKe : UserControl
    {
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        public ucThongKe()
        {
            InitializeComponent();
        }
        public void LoadThongKeTopPick()
        {
            pnlThongKe.Controls.Clear();
            ucThongKeTopPick ucThongKeTopPickCF = new ucThongKeTopPick();
            ucThongKeTopPickCF.Dock = DockStyle.Fill;
            pnlThongKe.Controls.Add(ucThongKeTopPickCF);
            ucThongKeTopPickCF.BringToFront();
        }
        private void btnTopPick_Click(object sender, EventArgs e)
        {
            LoadThongKeTopPick();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            ucThongKeDoanhThu ucThongKeDoanhThuCF = new ucThongKeDoanhThu();
            ucThongKeDoanhThuCF.Dock = DockStyle.Fill;
            pnlThongKe.Controls.Add(ucThongKeDoanhThuCF);
            ucThongKeDoanhThuCF.BringToFront();
        }

        private void ucThongKe_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            btnTopPick.BackColor = btnDoanhThu.BackColor = bllCaiDat.SelectThemeColor(themeColor);
        }
    }
}
