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
    public partial class ucQuanLyKhachHang : UserControl
    {
        //Fields
        BLL_KhachHang bllKhachHang = new BLL_KhachHang();
        public bool flagButton;
        //-----------------------------------------------
        public ucQuanLyKhachHang()
        {
            InitializeComponent();
        }
        //Method
        public void LoadLoaiKhachHang()
        {
            cboLoaiKhachHang.DataSource = bllKhachHang.LoadLoaiKhachHang();
            cboLoaiKhachHang.DisplayMember = "TenLoaiKhachHang";
            cboLoaiKhachHang.ValueMember = "MaLoaiKhachHang";
        }
        public void LoadKhachHang(string maLoaiKhachHang)
        {
            grcKhachHang.DataSource = bllKhachHang.LoadKhachHang(maLoaiKhachHang);
        }
        public void ClearText()
        {
            txtMaKhachHang.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtDiemTichLuy.Clear();
            txtDiaChi.Clear();
        }
        public void EnableControl()
        {
            txtHoTen.Enabled = txtDiaChi.Enabled  = txtSoDienThoai.Enabled = true;
        }
        public void DisableControl()
        {
            txtHoTen.Enabled = txtDiaChi.Enabled  = txtSoDienThoai.Enabled = false;
        }
        public bool KiemTraNhapLieu()
        {
            if (txtHoTen.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
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
        public bool KiemTraTrungSDT(string soDienThoai)
        {
            if (bllKhachHang.KiemTraTrungSDT(txtSoDienThoai.Text))
                return true;
            else
                return false;
        }
        //-----------------------------------------------
        private void ucQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadLoaiKhachHang();
            LoadKhachHang(cboLoaiKhachHang.SelectedValue.ToString());
        }
        private void cboLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKhachHang(cboLoaiKhachHang.SelectedValue.ToString());
            if(cboLoaiKhachHang.SelectedValue.ToString() == "KVL")
            {
                ClearText();
                DisableControl();
            }
        }
        private void grvKhachHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaKhachHang.Text = grvKhachHang.GetRowCellValue(e.RowHandle, "MaKhachHang").ToString();
            txtHoTen.Text = grvKhachHang.GetRowCellValue(e.RowHandle, "TenKhachHang").ToString();
            txtSoDienThoai.Text = grvKhachHang.GetRowCellValue(e.RowHandle, "SoDienThoai").ToString();
            txtDiemTichLuy.Text = grvKhachHang.GetRowCellValue(e.RowHandle, "DiemTichLuy").ToString();
            txtDiaChi.Text = grvKhachHang.GetRowCellValue(e.RowHandle, "DiaChi").ToString();
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnLuu.Visible = false;
            DisableControl();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboLoaiKhachHang.SelectedValue.ToString() == "KVL")
            {
                MessageBox.Show("Dữ liệu mặc định. Không thể thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClearText();
            EnableControl();
            txtHoTen.Focus();
            txtMaKhachHang.Text = bllKhachHang.PhatSinhMaKhachHang();
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            flagButton = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(cboLoaiKhachHang.SelectedValue.ToString() == "KVL")
            {
                MessageBox.Show("Dữ liệu mặc định. Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bllKhachHang.KiemTraKhoaNgoaiKhachHang(txtMaKhachHang.Text))
            {
                MessageBox.Show("Khách hàng này liên quan đến hóa đơn. Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Xóa khách hàng " + txtHoTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllKhachHang.DeleteKhachHang(txtMaKhachHang.Text);
                LoadKhachHang(cboLoaiKhachHang.SelectedValue.ToString());
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                ClearText();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboLoaiKhachHang.SelectedValue.ToString() == "KVL")
            {
                MessageBox.Show("Dữ liệu mặc định. Không thể sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EnableControl();
            txtSoDienThoai.Enabled = false;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            flagButton = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flagButton)
            {
                if (cboLoaiKhachHang.SelectedValue.ToString() == "KVL")
                {
                    MessageBox.Show("Dữ liệu mặc định. Không thể thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (KiemTraNhapLieu())
                {                  
                    if (KiemTraTrungSDT(txtSoDienThoai.Text))
                    {
                        MessageBox.Show("Số điện thoại này đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSoDienThoai.Focus();
                        return;
                    }
                    bllKhachHang.InsertKhachHang(txtMaKhachHang.Text, txtHoTen.Text, cboLoaiKhachHang.SelectedValue.ToString(), txtSoDienThoai.Text, txtDiaChi.Text);
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang(cboLoaiKhachHang.SelectedValue.ToString());
                }
                else
                    return;
            }
            else
            {
                if (cboLoaiKhachHang.SelectedValue.ToString() == "KVL")
                {
                    MessageBox.Show("Dữ liệu mặc định. Không thể sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (KiemTraNhapLieu())
                {                   
                    bllKhachHang.UpdateKhachHang(txtMaKhachHang.Text, txtHoTen.Text, cboLoaiKhachHang.SelectedValue.ToString(), txtSoDienThoai.Text, txtDiaChi.Text);
                    MessageBox.Show("Cập nhật khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang(cboLoaiKhachHang.SelectedValue.ToString());
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

        
    }
}
