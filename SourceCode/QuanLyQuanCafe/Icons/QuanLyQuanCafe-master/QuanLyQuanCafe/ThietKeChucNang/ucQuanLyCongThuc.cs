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
    public partial class ucQuanLyCongThuc : UserControl
    {
        //Fields
        BLL_CongThucPhaChe bllCongThuc = new BLL_CongThucPhaChe();
        private string maDoUong;
        private string maNguyenLieu;
        //--------------------------------------------------------------
        public ucQuanLyCongThuc()
        {
            InitializeComponent();
        }
        //Method
        public void LoadNguyenLieu()
        {
            cboNguyenLieu.DataSource = bllCongThuc.LoadNguyenLieu();
            cboNguyenLieu.DisplayMember = "TenNguyenLieu";
            cboNguyenLieu.ValueMember = "MaNguyenLieu";
        }
        public void LoadDoUong()
        {
            grcDoUong.DataSource = bllCongThuc.LoadDoUong();
        }
        public void LoadCongThuc(string maDoUong)
        {
            grcCongThuc.DataSource = bllCongThuc.LoadCongThucPhaChe(maDoUong);
        }
        public void EnableControl()
        {
            btnXoa.Visible = true;
        }
        public void DisableControl()
        {
            btnXoa.Visible = false;
        }
        //--------------------------------------------------------------
        private void ucQuanLyCongThuc_Load(object sender, EventArgs e)
        {
            LoadDoUong();
            LoadNguyenLieu();
            lblDonViTinh.Text = bllCongThuc.GetDonViTinh(cboNguyenLieu.SelectedValue.ToString());
        }
        private void cboNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDonViTinh.Text = bllCongThuc.GetDonViTinh(cboNguyenLieu.SelectedValue.ToString());
        }
        private void grvDoUong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            maDoUong = grvDoUong.GetRowCellValue(e.FocusedRowHandle, "MaDoUong").ToString();
            LoadCongThuc(maDoUong);
            DisableControl();
        }
        private void grvCongThuc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            maNguyenLieu = grvCongThuc.GetRowCellValue(e.RowHandle, "MaNguyenLieu").ToString();
            EnableControl();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            if(soLuong < 1)
            {
                MessageBox.Show("Số lượng tối thiểu là 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bllCongThuc.InsertCongThuc(maDoUong, cboNguyenLieu.SelectedValue.ToString(), soLuong);
                LoadCongThuc(maDoUong);
            }
            txtSoLuong.Clear();
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            bllCongThuc.DeleteCongThuc(maDoUong, maNguyenLieu);
            LoadCongThuc(maDoUong);
            DisableControl();
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
