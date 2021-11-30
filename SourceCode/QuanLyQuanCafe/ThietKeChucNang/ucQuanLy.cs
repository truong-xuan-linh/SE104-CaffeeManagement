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
    public partial class ucQuanLy : UserControl
    {
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        public ucQuanLy()
        {
            InitializeComponent();
            
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            ucQuanLyNhanVienCF.BringToFront();
        }

        private void btnQLBan_Click(object sender, EventArgs e)
        {
            ucQuanLyBanCF.BringToFront();           
        }

        private void btnQLDoUong_Click(object sender, EventArgs e)
        {
            ucQuanLyDoUongCF.BringToFront();
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            ucQuanLyHoaDonCF.BringToFront();
        }
        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            ucQuanLyKhachHangCF.BringToFront();
        }
        private void btnQLCongThuc_Click(object sender, EventArgs e)
        {
            ucQuanLyCongThucCF.LoadDoUong();
            ucQuanLyCongThucCF.BringToFront();
        }

        private void ucQuanLy_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            btnQLBan.BackColor = btnQLNhanVien.BackColor = btnQLDoUong.BackColor = btnQLHoaDon.BackColor = btnQLCongThuc.BackColor = btnQLKhachHang.BackColor = bllCaiDat.SelectThemeColor(themeColor);
        }
    }
}
