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
using System.IO;

namespace ThietKeChucNang
{
    public partial class ucQuanLyDoUong : UserControl
    {
        //Fields
        BLL_DoUong bllDoUong = new BLL_DoUong();
        public bool flagButton;
        //---------------------------------------------------
        //Contructors       
        public ucQuanLyDoUong()
        {
            InitializeComponent();
        }
        //---------------------------------------------------
        //Method
        public void LoadDanhMucDoUong()
        {
            cboDanhMuc.DataSource = bllDoUong.LoadDanhMucDoUong();
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";
        }
        public void LoadDoUong(string maDanhMuc)
        {
            grcDoUong.DataSource = bllDoUong.LoadDoUong(maDanhMuc);
        }
        public void ClearText()
        {
            txtMaDoUong.Clear();
            txtTenDoUong.Clear();
            txtGiaBan.Clear();
            txtHinhMinhHoa.Clear();
            picHinhMinhHoa.Image = null;
        }
        public void DisableControl()
        {
            txtTenDoUong.Enabled = false;
            txtGiaBan.Enabled = false;
            btnChonHinhAnh.Enabled = false;
        }
        public void EnableControl()
        {
            txtTenDoUong.Enabled = true;
            txtGiaBan.Enabled = true;
            btnChonHinhAnh.Enabled = true;
        }
        public bool KiemTraNhapLieu()
        {
            if (txtTenDoUong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên đồ uống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDoUong.Focus();
                return false;
            }
            if (txtGiaBan.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập giá bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return false;
            }
            if (txtHinhMinhHoa.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn hình minh họa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonHinhAnh.Focus();
                return false;
            }
            return true;
        }
        public void LoadHinhMinhHoa(string fileName)
        {
            try
            {
                string path = @"D:\ThucHanh\PhatTrienPhanMem\QuanLyQuanCafe\Images\DoUong\";
                picHinhMinhHoa.Image = Image.FromFile(path + fileName);
                picHinhMinhHoa.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                return;
            }
        }
        //---------------------------------------------------
        private void ucQuanLyDoUong_Load(object sender, EventArgs e)
        {
            LoadDanhMucDoUong();
            LoadDoUong(cboDanhMuc.SelectedValue.ToString());     
        }
        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoUong(cboDanhMuc.SelectedValue.ToString());
            ClearText();
            DisableControl();
            btnXoa.Visible = false;
            btnSua.Visible = false;
            btnLuu.Visible = false;
            btnThem.Visible = true;
        }
        private void grvDoUong_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaDoUong.Text = grvDoUong.GetRowCellValue(e.RowHandle, "MaDoUong").ToString();
            txtTenDoUong.Text = grvDoUong.GetRowCellValue(e.RowHandle, "TenDoUong").ToString();
            txtGiaBan.Text = grvDoUong.GetRowCellValue(e.RowHandle, "Gia").ToString();
            txtHinhMinhHoa.Text = grvDoUong.GetRowCellValue(e.RowHandle, "HinhMinhHoa").ToString();

            LoadHinhMinhHoa(txtHinhMinhHoa.Text);

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
            txtTenDoUong.Focus();
            txtMaDoUong.Text = bllDoUong.PhatSinhMaDoUong(cboDanhMuc.SelectedValue.ToString());
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            flagButton = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bllDoUong.KiemTraKhoaNgoaiDoUong(txtMaDoUong.Text))
            {
                MessageBox.Show("Đồ uống này liên quan đến hóa đơn. Không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Xóa " + txtTenDoUong.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllDoUong.DeleteDoUong(txtMaDoUong.Text);
                LoadDoUong(cboDanhMuc.SelectedValue.ToString());
                btnXoa.Visible = false;
                btnSua.Visible = false;
                btnLuu.Visible = false;
                ClearText();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl();
            txtTenDoUong.Focus();
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
                    if(Convert.ToInt32(txtGiaBan.Text) < 1000)
                    {
                        MessageBox.Show("Đơn giá tối thiểu là 1000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    bllDoUong.InsertDoUong(txtMaDoUong.Text, txtTenDoUong.Text, cboDanhMuc.SelectedValue.ToString(), Convert.ToInt32(txtGiaBan.Text), txtHinhMinhHoa.Text);
                    MessageBox.Show("Thêm đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDoUong(cboDanhMuc.SelectedValue.ToString());
                }
                else
                    return;
            }
            else
            {
                if (KiemTraNhapLieu())
                {
                    if (Convert.ToInt32(txtGiaBan.Text) < 1000)
                    {
                        MessageBox.Show("Đơn giá tối thiểu là 1000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    bllDoUong.UpdateDoUong(txtMaDoUong.Text, txtTenDoUong.Text, cboDanhMuc.SelectedValue.ToString(), Convert.ToInt32(txtGiaBan.Text), txtHinhMinhHoa.Text);
                    MessageBox.Show("Cập nhật đồ uống thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDoUong(cboDanhMuc.SelectedValue.ToString());
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
        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnChonHinhAnh_Click(object sender, EventArgs e)
        {
            openFileDialogChonHinhAnh.ShowDialog();
            txtHinhMinhHoa.Text = openFileDialogChonHinhAnh.SafeFileName;
            LoadHinhMinhHoa(txtHinhMinhHoa.Text);
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            frmQuanLyDanhMuc frmDanhMuc = new frmQuanLyDanhMuc();
            frmDanhMuc.ShowDialog();
            LoadDanhMucDoUong();
        }

        
    }
}
