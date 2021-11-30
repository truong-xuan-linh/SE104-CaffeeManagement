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
    public partial class ucTrangChu: UserControl
    {
        BLL_UserManagement userManagement = new BLL_UserManagement();
        BLL_Ban bllBan = new BLL_Ban();
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        public ucTrangChu()
        {
            InitializeComponent();
        }
        public void LoadTrangThaiBan()
        {
            lblBanTrong.Text = bllBan.GetSoLuongBanTrong().ToString();
            lblBanCoKhach.Text = bllBan.GetSoLuongBanCoKhach().ToString();
        }
        private void ucTrangChu_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            label2.ForeColor = label3.ForeColor = lblChucVu.ForeColor = lblTenNhanVien.ForeColor = lblNgay.ForeColor = lblThoiGian.ForeColor = lblBanTrong.ForeColor = lblBanCoKhach.ForeColor = bllCaiDat.SelectThemeColor(themeColor);
            lblNgay.Text = DateTime.Now.ToLongDateString();
            LoadTrangThaiBan();
        }
        private void timerThoiGian_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToLongTimeString();
        }
        public void GetDisplayName(string userName)
        {
            lblTenNhanVien.Text = userManagement.GetDisplayName(userName);
        }
        public void GetChucVu(string userName)
        {
            lblChucVu.Text = userManagement.GetTenLoaiTaiKhoan(userName);
        }
    }
}
