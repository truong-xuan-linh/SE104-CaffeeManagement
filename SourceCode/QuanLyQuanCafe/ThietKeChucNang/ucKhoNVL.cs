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
    public partial class ucKhoNVL : UserControl
    {
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        private string username;
        public ucKhoNVL()
        {
            InitializeComponent();
        }
        public void GetUserName(string user)
        {
            username = user;
        }
        public void LoadQuanLyNguyenLieu()
        {
            pnlKhoNVL.Controls.Clear();
            ucQuanLyNguyenLieu ucQuanLyNguyenLieuCF = new ucQuanLyNguyenLieu();
            ucQuanLyNguyenLieuCF.Dock = DockStyle.Fill;
            pnlKhoNVL.Controls.Add(ucQuanLyNguyenLieuCF);
        }
        private void btnQLNguyenLieu_Click(object sender, EventArgs e)
        {
            LoadQuanLyNguyenLieu();
        }
        private void btnQLPhieuNhap_Click(object sender, EventArgs e)
        {
            pnlKhoNVL.Controls.Clear();
            ucQuanLyPhieuNhap ucQuanLyPhieuNhapCF = new ucQuanLyPhieuNhap();
            ucQuanLyPhieuNhapCF.Dock = DockStyle.Fill;
            ucQuanLyPhieuNhapCF.GetUserName(username);
            pnlKhoNVL.Controls.Add(ucQuanLyPhieuNhapCF);
        }

        private void ucKhoNVL_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            btnQLNguyenLieu.BackColor = btnQLPhieuNhap.BackColor = bllCaiDat.SelectThemeColor(themeColor);
        }
    }
}
