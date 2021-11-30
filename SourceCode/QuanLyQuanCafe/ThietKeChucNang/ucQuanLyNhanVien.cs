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
using DevExpress.XtraGrid.Views.Grid;

namespace ThietKeChucNang
{
    public partial class ucQuanLyNhanVien : UserControl
    {
        //Fields
        BLL_NhanVien bllNhanVien = new BLL_NhanVien();
        public bool flagButton;
        //Contructors
        public ucQuanLyNhanVien()
        {
            InitializeComponent();
        }
        //Method
        public void LoadNhanVien(string maLoaiTaiKhoan)
        {
            grcNhanVien.DataSource = bllNhanVien.LoadNhanVien(maLoaiTaiKhoan);
        }
        public void LoadLoaiTaiKhoan()
        {
            cboLoaiTaiKhoan.DataSource = bllNhanVien.LoadLoaiTaiKhoan();
            cboLoaiTaiKhoan.DisplayMember = "TenLoaiTaiKhoan";
            cboLoaiTaiKhoan.ValueMember = "MaLoaiTaiKhoan";
        }
        public void ClearText()
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
        }
        public void EnableControl()
        {
            txtHoTen.Enabled = txtTenDangNhap.Enabled = txtMatKhau.Enabled = txtSoDienThoai.Enabled = txtDiaChi.Enabled = true;            
            rdbNam.Enabled = rdbNu.Enabled = true;
        }
        public void DisableControl()
        {
            txtHoTen.Enabled = txtTenDangNhap.Enabled = txtMatKhau.Enabled = txtSoDienThoai.Enabled = txtDiaChi.Enabled = false;
            rdbNam.Enabled = rdbNu.Enabled = false;
        }
        public bool KiemTraNhapLieu()
        {
            if (txtHoTen.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            if (txtTenDangNhap.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }
            if (txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            if (txtSoDienThoai.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }          
            if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            return true;

        }
        //-------------
        private void ucQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadLoaiTaiKhoan();
            LoadNhanVien(cboLoaiTaiKhoan.SelectedValue.ToString());
        }     
        private void cboLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNhanVien(cboLoaiTaiKhoan.SelectedValue.ToString());
        }
        private void grvNhanVien_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            txtMaNhanVien.Text = grvNhanVien.GetRowCellValue(e.RowHandle, "MaNhanVien").ToString();
            txtHoTen.Text = grvNhanVien.GetRowCellValue(e.RowHandle, "TenNhanVien").ToString();
            txtTenDangNhap.Text = grvNhanVien.GetRowCellValue(e.RowHandle, "TenDangNhap").ToString();
            txtMatKhau.Text = grvNhanVien.GetRowCellValue(e.RowHandle, "MatKhau").ToString();
            if (grvNhanVien.GetRowCellValue(e.RowHandle, "GioiTinh").ToString() == "Nam")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
            txtSoDienThoai.Text = grvNhanVien.GetRowCellValue(e.RowHandle, "SDT").ToString();
            txtDiaChi.Text = grvNhanVien.GetRowCellValue(e.RowHandle, "DiaChi").ToString();

            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            DisableControl();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableControl();
            txtHoTen.Focus();
            txtMaNhanVien.Text = bllNhanVien.PhatSinhMaNhanVien();
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            flagButton = true;                
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bllNhanVien.KiemTraKhoaNgoaiNhanVien(txtMaNhanVien.Text))
            {
                MessageBox.Show("Nhân viên này liên quan đến hóa đơn. Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Xóa nhân viên " + txtHoTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllNhanVien.DeleteNhanVien(txtMaNhanVien.Text);
                LoadNhanVien(cboLoaiTaiKhoan.SelectedValue.ToString());
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                ClearText();
            }        
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl();
            txtTenDangNhap.Enabled = false;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            flagButton = false;
        }       
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if (flagButton)
            {
                if (KiemTraNhapLieu())
                {
                    if (bllNhanVien.KiemTraTenDangNhap(txtTenDangNhap.Text))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenDangNhap.Focus();
                        return;
                    }
                    string gioiTinh;
                    if (rdbNam.Checked)
                        gioiTinh = "Nam";
                    else
                        gioiTinh = "Nữ";
                    bllNhanVien.InsertNhanVien(txtMaNhanVien.Text, txtHoTen.Text, txtTenDangNhap.Text, txtMatKhau.Text, cboLoaiTaiKhoan.SelectedValue.ToString(), gioiTinh, txtSoDienThoai.Text, txtDiaChi.Text);
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien(cboLoaiTaiKhoan.SelectedValue.ToString());
                }
                else
                    return;
            }
            else
            {
                if (KiemTraNhapLieu())
                {
                    string gioiTinh;
                    if (rdbNam.Checked)
                        gioiTinh = "Nam";
                    else
                        gioiTinh = "Nữ";
                    bllNhanVien.UpdateNhanVien(txtMaNhanVien.Text, txtHoTen.Text, txtTenDangNhap.Text, txtMatKhau.Text, cboLoaiTaiKhoan.SelectedValue.ToString(), gioiTinh, txtSoDienThoai.Text, txtDiaChi.Text);
                    MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien(cboLoaiTaiKhoan.SelectedValue.ToString());
                }
                else
                    return;
                
            }
            btnLuu.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnThem.Visible = true;
            ClearText();
            DisableControl();
        }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                txtHoTen.Text = "Nhập họ tên";
                txtHoTen.ForeColor = Color.Gray;
            }
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "Nhập họ tên")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Black;
            }
        }
    }
}
