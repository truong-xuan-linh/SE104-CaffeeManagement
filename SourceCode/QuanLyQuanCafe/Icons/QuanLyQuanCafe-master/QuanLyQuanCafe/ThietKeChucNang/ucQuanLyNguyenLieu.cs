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
    public partial class ucQuanLyNguyenLieu : UserControl
    {
        BLL_NguyenLieu bllNguyenLieu = new BLL_NguyenLieu();
        public bool flagButton;
        public ucQuanLyNguyenLieu()
        {
            InitializeComponent();
        }
        //Method
        public void LoadNguyenLieu()
        {
            grcNguyenLieu.DataSource = bllNguyenLieu.LoadNguyenLieu();
        }
        public void ClearText()
        {
            txtMaNguyenLieu.Clear();
            txtTenNguyenLieu.Clear();
            txtDonViTinh.Clear();
            lblSoLuongTon.Text = string.Empty;
        }
        public void DisableControl()
        {
            txtTenNguyenLieu.Enabled = false;
            txtDonViTinh.Enabled = false;          
        }
        public void EnableControl()
        {
            txtTenNguyenLieu.Enabled = true;
            txtDonViTinh.Enabled = true;
        }
        public bool KiemTraNhapLieu()
        {
            if (txtTenNguyenLieu.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNguyenLieu.Focus();
                return false;
            }           
            if (txtDonViTinh.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonViTinh.Focus();
                return false;
            }
            return true;
        }
        //----------------------------------------------------
        private void ucQuanLyNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }
        private void grvNguyenLieu_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaNguyenLieu.Text = grvNguyenLieu.GetRowCellValue(e.RowHandle, "MaNguyenLieu").ToString();
            txtTenNguyenLieu.Text = grvNguyenLieu.GetRowCellValue(e.RowHandle, "TenNguyenLieu").ToString();
            txtDonViTinh.Text = grvNguyenLieu.GetRowCellValue(e.RowHandle, "DonViTinh").ToString();
            lblSoLuongTon.Text = grvNguyenLieu.GetRowCellValue(e.RowHandle, "SoLuongTon").ToString();

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
            txtTenNguyenLieu.Focus();
            txtMaNguyenLieu.Text = bllNguyenLieu.PhatSinhMaTuDong();
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            flagButton = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bllNguyenLieu.KiemTraKhoaNgoaiNguyenLieu(txtMaNguyenLieu.Text))
            {
                MessageBox.Show("Nguyên liệu này liên quan đến phiếu nhập và công thức. Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Xóa " + txtTenNguyenLieu.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllNguyenLieu.DeleteNguyenLieu(txtMaNguyenLieu.Text);
                LoadNguyenLieu();
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                ClearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl();
            txtTenNguyenLieu.Focus();
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
                    bllNguyenLieu.InsertNguyenLieu(txtMaNguyenLieu.Text, txtTenNguyenLieu.Text, txtDonViTinh.Text);
                    MessageBox.Show("Thêm nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNguyenLieu();
                }
                else
                    return;
            }
            else
            {
                if (KiemTraNhapLieu())
                {
                    
                    bllNguyenLieu.UpdateNguyenLieu(txtMaNguyenLieu.Text, txtTenNguyenLieu.Text,  txtDonViTinh.Text);
                    MessageBox.Show("Cập nhật nguyên liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNguyenLieu();
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

       
    }
}
