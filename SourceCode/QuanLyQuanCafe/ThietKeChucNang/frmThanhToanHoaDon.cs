using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;
namespace ThietKeChucNang
{
    public partial class frmThanhToanHoaDon : Form
    {
        //Fields
        BLL_BanHang bllBanHang = new BLL_BanHang();
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        private string maHoaDon;
        private string tenBan;
        private string username;
        private string gioVao;
        private string tongTien;
        private string maKhachHang = "KH100";
        private int tienThanhToan;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string Username { get => username; set => username = value; }
        public string GioVao { get => gioVao; set => gioVao = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }


        //----------------------------------------------------------------------
        public frmThanhToanHoaDon()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlThanhTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txtSoDienThoai_Click(object sender, EventArgs e)
        {
            txtSoDienThoai.Clear();
        }
        private void frmThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            label8.ForeColor = label10.ForeColor = label11.ForeColor = label9.ForeColor = label13.ForeColor = label12.ForeColor = label14.ForeColor = label5.ForeColor = label3.ForeColor = btnApDungGiamGIa.BackColor = btnThanhToan.BackColor = pnlThanhTieuDe.BackColor = bllCaiDat.SelectThemeColor(themeColor);
            lblMaHoaDon.Text = MaHoaDon;
            lblBan.Text = TenBan;
            lblGioVao.Text = GioVao;
            lblGioRa.Text = DateTime.Now.ToLongTimeString();
            lblTenNhanVien.Text = bllBanHang.GetTenNhanVien(Username);
            lblKhachHang.Text = string.Empty;
            lblTongTien.Text = TongTien;
            lblTienThanhToan.Text = TongTien;

            grcChiTietHoaDon.DataSource = bllBanHang.LoadChiTietHoaDon(MaHoaDon);
            grvChiTietHoaDon.Columns[0].Visible = false;
        }
        private void chkKhongPhaiThanhVien_CheckedChanged(object sender, EventArgs e)
        {
            lblKhachHang.Text = string.Empty;
            txtSoDienThoai.Clear();
            if (chkKhongPhaiThanhVien.Checked)
                txtSoDienThoai.Enabled = false;
            else
                txtSoDienThoai.Enabled = true;
        }
        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnApDungGiamGIa_Click(object sender, EventArgs e)
        {
            if (txtGiamGia.Text != string.Empty)
            {
                int temp = bllBanHang.GetTongTienHoaDon(MaHoaDon) - Convert.ToInt32(txtGiamGia.Text);
                if(temp <= 0)
                {
                    MessageBox.Show("Tiền giảm giá không được lớn hơn tổng tiền hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tienThanhToan = temp;
                    lblTienThanhToan.Text = tienThanhToan + " VNĐ";
                }                   
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            maKhachHang = bllBanHang.GetMaKhachHang(txtSoDienThoai.Text);
            string tenKhachHang = bllBanHang.GetTenKhachHang(txtSoDienThoai.Text);
            if (maKhachHang == string.Empty)
            {
                maKhachHang = "KH100";
                MessageBox.Show("Không tìm thấy khách hàng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblKhachHang.Text = tenKhachHang;
            }
            txtSoDienThoai.Clear();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maNhanVien = bllBanHang.GetMaNhanVien(Username);
            int giamGia = 0;
            if (txtGiamGia.Text != string.Empty)
            {
                giamGia = Convert.ToInt32(txtGiamGia.Text);
            }
            bllBanHang.UpdateHoaDon(lblMaHoaDon.Text, maNhanVien, maKhachHang, giamGia, DateTime.Now);
            bllBanHang.CongDiemTichLuyKhachHang(maKhachHang, 1);
            MessageBox.Show("Đã thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
