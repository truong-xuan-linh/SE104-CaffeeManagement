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
    public partial class ucQuanLyBan : UserControl
    {
        //Fields
        BLL_Ban bllBan = new BLL_Ban();
        public bool flagButton;
        //------------------------------------------
        //Contructor
        public ucQuanLyBan()
        {
            InitializeComponent();
        }
        //------------------------------------------
        //Method
        public void LoadViTri()
        {
            cboViTri.DataSource = bllBan.LoadViTri();
            cboViTri.DisplayMember = "TenViTri";
            cboViTri.ValueMember = "MaViTri";
        }
        public void LoadBan(string maViTri)
        {
            grcBan.DataSource = bllBan.LoadBanTheoTang(maViTri);
        }
        public void ClearText()
        {
            txtMaBan.Clear();
            txtTenBan.Clear();
            lblTrangThai.Text = "";
        }
        public void DisableControl()
        {
            txtTenBan.Enabled = false;
        }
        public void EnableControl()
        {
            txtTenBan.Enabled = true;
        }
        public bool KiemTraNhapLieu()
        {
            if(txtTenBan.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBan.Focus();
                return false;
            }
            return true;
        }
        //------------------------------------------
        private void ucQuanLyBan_Load(object sender, EventArgs e)
        {
            LoadViTri();
            LoadBan(cboViTri.SelectedValue.ToString());
        }

        private void cboViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBan(cboViTri.SelectedValue.ToString());
            ClearText();
            DisableControl();
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnLuu.Visible = false;
            btnThem.Visible = true;
        }
        private void grvBan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaBan.Text = grvBan.GetRowCellValue(e.RowHandle, "MaBan").ToString();
            txtTenBan.Text = grvBan.GetRowCellValue(e.RowHandle, "TenBan").ToString();
            lblTrangThai.Text = grvBan.GetRowCellValue(e.RowHandle, "TrangThai").ToString();

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
            txtTenBan.Focus();
            txtMaBan.Text = bllBan.PhatSinhMaBan(cboViTri.SelectedValue.ToString());
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            flagButton = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bllBan.KiemTraKhoaNgoaiBan(txtMaBan.Text))
            {
                MessageBox.Show("Bàn này liên quan đến hóa đơn. Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(lblTrangThai.Text == "Có khách")
            {
                MessageBox.Show("Bàn đang có khách. Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Xóa bàn " + txtTenBan.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllBan.DeleteBan(txtMaBan.Text);
                LoadBan(cboViTri.SelectedValue.ToString());
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                ClearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lblTrangThai.Text == "Có khách")
            {
                MessageBox.Show("Bàn đang có khách. Không thể sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EnableControl();
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
                    bllBan.InsertBan(txtMaBan.Text, txtTenBan.Text, cboViTri.SelectedValue.ToString());
                    MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBan(cboViTri.SelectedValue.ToString());
                }
                else
                    return;
            }
            else
            {
                if (KiemTraNhapLieu())
                {
                    bllBan.UpdateBan(txtMaBan.Text, txtTenBan.Text, cboViTri.SelectedValue.ToString());
                    MessageBox.Show("Cập nhật bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBan(cboViTri.SelectedValue.ToString());
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
