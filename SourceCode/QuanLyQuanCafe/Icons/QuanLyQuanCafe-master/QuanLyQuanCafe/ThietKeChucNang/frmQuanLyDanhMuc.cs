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
    public partial class frmQuanLyDanhMuc : Form
    {
        //Fields
        BLL_DanhMucDoUong bllDanhMucDoUong = new BLL_DanhMucDoUong();
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        bool flagButton;
        //--------------------------------------
        //Contructors
        public frmQuanLyDanhMuc()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //---------------------------------------------
        //Method
        public void LoadDanhMuc()
        {
            cboDanhMuc.DataSource = bllDanhMucDoUong.LoadDanhMucDoUong();
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";
        }
        public void ClearText()
        {
            txtTenDanhMuc.Clear();
            txtMaDanhMuc.Clear();
        }
        public void DisableControl()
        {
            txtMaDanhMuc.Enabled = false;
            txtTenDanhMuc.Enabled = false;
        }
        public void EnableControl()
        {
            txtMaDanhMuc.Enabled = true;
            txtTenDanhMuc.Enabled = true;
        }
        public bool KiemTraNhapLieu()
        {
            if (txtMaDanhMuc.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên đồ uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDanhMuc.Focus();
                return false;
            }
            if (txtTenDanhMuc.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên đồ uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return false;
            }
            return true;
        }
        //----------------------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlThanhTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            pnlThanhTieuDe.BackColor = bllCaiDat.SelectThemeColor(themeColor);
            LoadDanhMuc();
            txtMaDanhMuc.Text = cboDanhMuc.SelectedValue.ToString();
            txtTenDanhMuc.Text = cboDanhMuc.Text;
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaDanhMuc.Text = cboDanhMuc.SelectedValue.ToString();
            txtTenDanhMuc.Text = cboDanhMuc.Text;

            DisableControl();
            btnXoa.Visible = true;
            btnSua.Visible = true;
            btnLuu.Visible = false;
            btnThem.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearText();
            EnableControl();

            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            flagButton = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bllDanhMucDoUong.KiemTraTonTaiDoUong(txtMaDanhMuc.Text))
            {
                MessageBox.Show("Đã tồn tại đồ uống trong danh mục " + txtTenDanhMuc.Text + ". Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Xóa danh mục " + txtTenDanhMuc.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bllDanhMucDoUong.DeleteDanhMucDoUong(txtMaDanhMuc.Text);
                MessageBox.Show("Đã xóa danh mục " + txtTenDanhMuc.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMuc();
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                ClearText();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl();
            txtMaDanhMuc.Enabled = false;
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
                    if (bllDanhMucDoUong.KiemTraKhoaChinhDanhMucDoUong(txtMaDanhMuc.Text))
                    {
                        MessageBox.Show("Mã danh mục đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        bllDanhMucDoUong.InsertDanhMucDoUong(txtMaDanhMuc.Text, txtTenDanhMuc.Text);
                        MessageBox.Show("Thêm danh mục đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhMuc();
                    }
                }
                else
                    return;
            }
            else
            {
                if (KiemTraNhapLieu())
                {
                    bllDanhMucDoUong.UpdateDanhMucDoUong(txtMaDanhMuc.Text, txtTenDanhMuc.Text);
                    MessageBox.Show("Cập nhật danh mục đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhMuc();
                }
                else
                    return;
            }
            btnLuu.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnThem.Visible = true;
            DisableControl();
            LoadDanhMuc();
        }
    }
}
