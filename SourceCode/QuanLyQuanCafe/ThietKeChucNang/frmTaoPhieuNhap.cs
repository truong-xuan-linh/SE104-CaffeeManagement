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
    public partial class frmTaoPhieuNhap : Form
    {
        //Fields
        BLL_PhieuNhapAndCTPN bllpnctpn = new BLL_PhieuNhapAndCTPN();
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        private string username;
        private string maNhanVien;
        private string maCTPN;
        private string maNguyenLieu;
        int soLuongNhap;

        public string Username { get => username; set => username = value; }
        //-------------------------------------------------------------------
        public frmTaoPhieuNhap()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Method
        public void LoadNhaCungCap()
        {
            cboNhaCungCap.DataSource = bllpnctpn.LoadNhaCungCap();
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
        }
        public void LoadNguyenLieu()
        {
            cboNguyenLieu.DataSource = bllpnctpn.LoadNguyenLieu();
            cboNguyenLieu.DisplayMember = "TenNguyenLieu";
            cboNguyenLieu.ValueMember = "MaNguyenLieu";
        }
        public void LoadChiTietPhieuNhap()
        {
            grcChiTietPhieuNhap.DataSource = bllpnctpn.LoadCTPN(lblMaPhieuNhap.Text);
        }
        public bool KiemTraNhapLieu()
        {
            if (txtDonGiaNhap.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaNhap.Focus();
                return false;
            }
            if (txtSoLuongNhap.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongNhap.Focus();
                return false;
            }
            if (Convert.ToInt32(txtDonGiaNhap.Text) < 1)
            {
                MessageBox.Show("Đơn giá tối thiểu là 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaNhap.Focus();
                return false;
            }
            if (Convert.ToInt32(txtSoLuongNhap.Text) < 1)
            {
                MessageBox.Show("Số lượng tối thiểu là 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongNhap.Focus();
                return false;
            }           
            return true;
        }
        public void ClearText()
        {
            txtDonGiaNhap.Clear();
            txtSoLuongNhap.Clear();
        }
        //------------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thao tác này sẽ hủy phiếu nhập đang tạo!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bllpnctpn.DeletePhieuNhap(lblMaPhieuNhap.Text);
                this.Close();
            }
           
        }

        private void pnlThanhTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmTaoPhieuNhap_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            pnlThanhTieuDe.BackColor = btnHoanThanh.BackColor = bllCaiDat.SelectThemeColor(themeColor);
            groupControlCTPN.Enabled = false;
            LoadNhaCungCap();
            LoadNguyenLieu();
            maNhanVien = bllpnctpn.GetMaNhanVien(Username);
            lblNhanVien.Text = bllpnctpn.GetTenNhanVien(Username);
            lblMaPhieuNhap.Text = bllpnctpn.PhatSinhMaPhieuNhap();
            lblTongTien.Text = string.Empty;
            lblNgayLap.Text = DateTime.Now.ToLongDateString();
            lblDonViTinh.Text = bllpnctpn.GetDonViTinh(cboNguyenLieu.SelectedValue.ToString());
        }
        private void grvChiTietPhieuNhap_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            btnXoaCTPN.Visible = true;
            maCTPN = grvChiTietPhieuNhap.GetRowCellValue(e.RowHandle, "MaCTPN").ToString();
            maNguyenLieu = grvChiTietPhieuNhap.GetRowCellValue(e.RowHandle, "MaNguyenLieu").ToString();
            soLuongNhap = Convert.ToInt32(grvChiTietPhieuNhap.GetRowCellValue(e.RowHandle, "SoLuong").ToString());
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            cboNhaCungCap.Enabled = false;
            btnThem.Enabled = false;
            groupControlCTPN.Enabled = true;
            bllpnctpn.InsertNewPhieuNhap(lblMaPhieuNhap.Text, maNhanVien, cboNhaCungCap.SelectedValue.ToString(), DateTime.Now);
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            if (KiemTraNhapLieu())
            {
                bllpnctpn.InsertChiTietPhieuNhap(lblMaPhieuNhap.Text, cboNguyenLieu.SelectedValue.ToString(), Convert.ToInt32(txtDonGiaNhap.Text), Convert.ToInt32(txtSoLuongNhap.Text));
                bllpnctpn.UpdateCongSoLuongTonNguyenLieu(cboNguyenLieu.SelectedValue.ToString(), Convert.ToInt32(txtSoLuongNhap.Text));
                bllpnctpn.UpdateTongTienForPhieuNhap(lblMaPhieuNhap.Text);
                lblTongTien.Text = bllpnctpn.GetTongTienPhieuNhap(lblMaPhieuNhap.Text).ToString() + " VNĐ";

                LoadChiTietPhieuNhap();
                ClearText();               
            }

        }
        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            bllpnctpn.DeleteChiTietPhieuNhap(maCTPN);
            bllpnctpn.UpdateTruSoLuongTonNguyenLieu(maNguyenLieu, soLuongNhap);
            bllpnctpn.UpdateTongTienForPhieuNhap(lblMaPhieuNhap.Text);
            lblTongTien.Text = bllpnctpn.GetTongTienPhieuNhap(lblMaPhieuNhap.Text).ToString() + " VNĐ";
            LoadChiTietPhieuNhap();
            btnXoaCTPN.Visible = false;
        }

        private void cboNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDonViTinh.Text = bllpnctpn.GetDonViTinh(cboNguyenLieu.SelectedValue.ToString());
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (grvChiTietPhieuNhap.FocusedRowHandle < 0)
            {
                MessageBox.Show("Phiếu nhập trống, vui lòng thêm nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
