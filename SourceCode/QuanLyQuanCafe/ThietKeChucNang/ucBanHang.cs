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
using System.Security.AccessControl;
using System.Resources;
using ThietKeChucNang.Properties;
using System.Security.Cryptography.X509Certificates;

namespace ThietKeChucNang
{
    public partial class ucBanHang : UserControl
    {
        //Fields
        BLL_BanHang bllBanHang = new BLL_BanHang();
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        private string maBan;
        private string maCTHD;
        private string maDoUong;
        private string username;
        private int soLuongMua;
        private string imagesPath;
        private string themeColor;
        //------------------------------------------
        //Contructors
        public ucBanHang()
        {
            InitializeComponent();
        }
        //------------------------------------------
        //Method
        public void GetUserName(string user)
        {
            username = user;
        }
        public void LoadViTri()
        {
            cboViTri.DataSource = bllBanHang.LoadViTri();
            cboViTri.DisplayMember = "TenViTri";
            cboViTri.ValueMember = "MaViTri";
        }
        public void LoadBan(string viTri)
        {
            int width = 90;
            int height = 60;

            foreach (var item in bllBanHang.LoadBanTheoTang(viTri))
            {
                Button btnBan = new Button();
                btnBan.Width = width;
                btnBan.Height = height;
                btnBan.Cursor = Cursors.Hand;
                btnBan.FlatStyle = FlatStyle.Flat;
                btnBan.FlatAppearance.BorderSize = 0;
                btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnBan.ForeColor = Color.Gainsboro;

                btnBan.Text = item.TenBan.ToString();
                btnBan.Name = item.MaBan.ToString();

                if (item.TrangThai == "Trống")
                    btnBan.BackColor = Color.DarkGreen;
                else
                    btnBan.BackColor = Color.FromArgb(255, 87, 34);

                btnBan.Click += btnBan_Click;
                fpnlBan.Controls.Add(btnBan);
            }
        }
        
        public void LoadDanhMucDoUong()
        {

            int width = 180;
            int height = 60;

            foreach (var item in bllBanHang.LoadDanhMucDoUong())
            {
                Button btnDanhMuc = new Button();
                btnDanhMuc.Width = width;
                btnDanhMuc.Height = height;
                btnDanhMuc.Cursor = Cursors.Hand;

                btnDanhMuc.BackColor = bllCaiDat.SelectThemeColor(themeColor);
                btnDanhMuc.Dock = DockStyle.Top;
                btnDanhMuc.FlatStyle = FlatStyle.Flat;
                btnDanhMuc.FlatAppearance.BorderSize = 0;
                btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDanhMuc.ForeColor = Color.Gainsboro;

                btnDanhMuc.Text = item.TenDanhMuc.ToString();
                btnDanhMuc.Name = item.MaDanhMuc.ToString();

                pnlDanhMuc.Controls.Add(btnDanhMuc);

                btnDanhMuc.Click += btnDanhMuc_Click;
            }
        }
        public void LoadDoUong(string maDanhMuc)
        {
            var ResourceManager = new System.Resources.ResourceManager("ThietKeChucNang.Properties.Resources", typeof(Resources).Assembly);

            foreach (var item in bllBanHang.LoadDoUong(maDanhMuc))
            {
                Panel pnlDoUongItem = new Panel();
                pnlDoUongItem.Width = 150;
                pnlDoUongItem.Height = 250;

                Label lblGiaBan = new Label();
                lblGiaBan.Text = item.Gia.ToString() + " VNĐ";
                lblGiaBan.ForeColor = Color.Red;
                lblGiaBan.Dock = DockStyle.Top;
                lblGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                Label lblTenDoUong = new Label();
                lblTenDoUong.Text = item.TenDoUong.ToString();
                lblTenDoUong.Dock = DockStyle.Top;
                lblTenDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //Label lblMaDoUong = new Label();
                //lblMaDoUong.Text = item.MaDoUong.ToString();
                //lblMaDoUong.ForeColor = Color.BlueViolet;
                //lblMaDoUong.Dock = DockStyle.Top;
                //lblMaDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                PictureBox picDoUongItem = new PictureBox();
                picDoUongItem.Width = 150;
                picDoUongItem.Height = 150;
                picDoUongItem.BackColor = Color.FromArgb(255, 87, 34);
                picDoUongItem.Dock = DockStyle.Top;
                picDoUongItem.SizeMode = PictureBoxSizeMode.StretchImage;
                //object obj = ResourceManager.GetObject(item.HinhMinhHoa.ToString());
                //picDoUongItem.BackgroundImage = ((System.Drawing.Bitmap)(obj));
                try
                {
                    //string path = @"D:\ThucHanh\PhatTrienPhanMem\QuanLyQuanCafe\Images\DoUong\";
                    picDoUongItem.Image = Image.FromFile(imagesPath + item.HinhMinhHoa.ToString());
                }
                catch (Exception)
                {
                    picDoUongItem.Image = null;
                    
                }
                Button btnAddToBill = new Button();
                btnAddToBill.Width = 150;
                btnAddToBill.Height = 35;
                btnAddToBill.BackColor = Color.Green;
                btnAddToBill.Text = "+";
                btnAddToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnAddToBill.TextAlign = ContentAlignment.MiddleCenter;
                btnAddToBill.FlatStyle = FlatStyle.Flat;
                btnAddToBill.FlatAppearance.BorderSize = 0;
                btnAddToBill.Cursor = Cursors.Hand;
                btnAddToBill.Dock = DockStyle.Top;
                btnAddToBill.Name = item.MaDoUong.ToString();
                btnAddToBill.Tag = item.Gia.ToString();
                btnAddToBill.Click += BtnAddToBill_Click;


                pnlDoUongItem.Controls.Add(btnAddToBill);
                pnlDoUongItem.Controls.Add(lblGiaBan);
                pnlDoUongItem.Controls.Add(lblTenDoUong);
                //pnlDoUongItem.Controls.Add(lblMaDoUong);
                pnlDoUongItem.Controls.Add(picDoUongItem);


                fpnlDoUong.Controls.Add(pnlDoUongItem);
            }
        }
        public void LoadChiTietHoaDon(string maHoaDon)
        {           
            grcChiTietHoaDon.DataSource = bllBanHang.LoadChiTietHoaDon(maHoaDon);
        }
        public void UpdateTongTienForHoaDon(string maHoaDon)
        {
            bllBanHang.UpdateTongTienForHoaDon(maHoaDon);       
        }
        public string GetGioVao(string maHoaDon)
        {
            string gioVao = bllBanHang.GetNgayGioVao(maHoaDon).ToString();
            return gioVao.Substring(0, 8);
        }
        public string GetTongTien(string maHoaDon)
        {
            return bllBanHang.GetTongTienHoaDon(maHoaDon).ToString() + " VNĐ";
        }
        public void ClearPanelDanhMuc()
        {
            pnlDanhMuc.Controls.Clear();
        }
        public void ClearControl()
        {
            lblMaHoaDon.Text = "";
            lblGioVao.Text = "";
            lblTongTien.Text = "0 VNĐ";        
        }
        //------------------------------------------
        private void ucBanHang_Load(object sender, EventArgs e)
        {
            themeColor = bllCaiDat.GetThemeColor();
            label1.ForeColor = label2.ForeColor = label4.ForeColor = label6.ForeColor = lblTenBan.ForeColor = bllCaiDat.SelectThemeColor(themeColor);
            btnMoBan.BackColor = btnDongBan.BackColor = btnThanhToan.BackColor = btnDoiBan.BackColor = bllCaiDat.SelectThemeColor(themeColor);
            LoadViTri();
            LoadDanhMucDoUong();
            LoadBan(cboViTri.SelectedValue.ToString());
            imagesPath = bllCaiDat.GetImagesPath();
            lblMaHoaDon.Text = "";
            lblGioVao.Text = "";
            lblTrangThai.Text = "";
            btnMoBan.Visible = btnDongBan.Visible = false;
        }
        private void cboViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            fpnlBan.Controls.Clear();
            LoadBan(cboViTri.SelectedValue.ToString());

        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            Button btnBan = sender as Button;
            lblTenBan.Text = btnBan.Text;
            maBan = btnBan.Name.ToString();
            lblMaHoaDon.Text = bllBanHang.GetMaHoaDonOfBan(maBan);
            lblTongTien.Text = GetTongTien(lblMaHoaDon.Text);
            if (lblMaHoaDon.Text != "")
            {
                LoadChiTietHoaDon(lblMaHoaDon.Text);
                lblGioVao.Text = GetGioVao(lblMaHoaDon.Text);
            }
            else
            {
                grcChiTietHoaDon.DataSource = null;
                lblGioVao.Text = "";
            }

            if (btnBan.BackColor == Color.DarkGreen)
            {
                lblTrangThai.Text = "Trống";
                btnMoBan.Visible = true;
                btnDongBan.Visible = false;
                btnThanhToan.Enabled = false;
                btnDoiBan.Visible = false;
            }
            else
            {
                if (grvChiTietHoaDon.FocusedRowHandle < 0)
                {
                    btnDongBan.Visible = true;
                }
                else
                {
                    btnDongBan.Visible = false;
                }
                lblTrangThai.Text = "Có khách";
                btnMoBan.Visible = false;             
                btnThanhToan.Enabled = true;
                btnDoiBan.Visible = true;
            }
            
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            fpnlDoUong.Controls.Clear();
            Button btnDanhMuc = sender as Button;
            LoadDoUong(btnDanhMuc.Name.ToString());
        }
        private void btnMoBan_Click(object sender, EventArgs e)
        {
            btnMoBan.Visible = false;
            btnDongBan.Visible = true;         
            btnThanhToan.Enabled = true;
            bllBanHang.MoBan(maBan);
            bllBanHang.InsertNewHoaDon(maBan, DateTime.Now, DateTime.Now);
            lblMaHoaDon.Text = bllBanHang.GetMaHoaDonOfBan(maBan);
            lblGioVao.Text = GetGioVao(lblMaHoaDon.Text);
            //LoadChiTietHoaDon(lblMaHoaDon.Text);
            fpnlBan.Controls.Clear();
            LoadBan(cboViTri.SelectedValue.ToString());
            lblTrangThai.Text = "Có khách";
        }
        private void btnDongBan_Click(object sender, EventArgs e)
        {
            btnDongBan.Visible = false;
            btnMoBan.Visible = true;
            btnDoiBan.Visible = false;
            btnThanhToan.Enabled = false;
            bllBanHang.DongBan(maBan);
            bllBanHang.DeleteHoaDon(lblMaHoaDon.Text);
            lblMaHoaDon.Text = string.Empty;
            lblGioVao.Text = string.Empty;
            fpnlBan.Controls.Clear();
            LoadBan(cboViTri.SelectedValue.ToString());
            lblTrangThai.Text = "Trống";
        }
        private void BtnAddToBill_Click(object sender, EventArgs e)
        {
            Button btnAddToBill = sender as Button;
            if(lblMaHoaDon.Text != "")
            {
                if (bllBanHang.KiemTraSoLuongTonNguyenLieu(btnAddToBill.Name))
                {
                    MessageBox.Show("Không đủ nguyên liệu để làm món này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bllBanHang.InsertChiTietHoaDon(lblMaHoaDon.Text, btnAddToBill.Name.ToString());
                bllBanHang.UpdateTruSoLuongNguyenLieu(btnAddToBill.Name);
                UpdateTongTienForHoaDon(lblMaHoaDon.Text);
                lblTongTien.Text = GetTongTien(lblMaHoaDon.Text);
                LoadChiTietHoaDon(lblMaHoaDon.Text);
                btnDongBan.Visible = false;
            }
            else
            {
                MessageBox.Show("Bạn chưa mở bàn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(grvChiTietHoaDon.FocusedRowHandle < 0)
            {
                MessageBox.Show("Hóa đơn trống, vui lòng thêm món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmThanhToanHoaDon frmTTHD = new frmThanhToanHoaDon();
            frmTTHD.MaHoaDon = lblMaHoaDon.Text;
            frmTTHD.TenBan = lblTenBan.Text;
            frmTTHD.Username = username;
            frmTTHD.GioVao = lblGioVao.Text;
            frmTTHD.TongTien = lblTongTien.Text;
            frmTTHD.ShowDialog();

            btnThanhToan.Enabled = false;
            bllBanHang.DongBan(maBan);
            grcChiTietHoaDon.DataSource = null;
            ClearControl();
            fpnlBan.Controls.Clear();
            LoadBan(cboViTri.SelectedValue.ToString());
            lblTrangThai.Text = "Trống";
        }
        private void btnXoaItemCTHD_Click(object sender, EventArgs e)
        {
            btnXoaItemCTHD.Enabled = false;
            bllBanHang.DeleteChiTietHoaDon(maCTHD);
            bllBanHang.UpdateCongSoLuongNguyenLieu(maDoUong, soLuongMua);
            UpdateTongTienForHoaDon(lblMaHoaDon.Text);
            lblTongTien.Text = GetTongTien(lblMaHoaDon.Text);
            LoadChiTietHoaDon(lblMaHoaDon.Text);
            if (grvChiTietHoaDon.FocusedRowHandle < 0)
            {
                btnDongBan.Visible = true;
            }
        }
        private void grvChiTietHoaDon_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            btnXoaItemCTHD.Enabled = true;
            maCTHD = grvChiTietHoaDon.GetRowCellValue(e.RowHandle, "MaCTHD").ToString();
            maDoUong = grvChiTietHoaDon.GetRowCellValue(e.RowHandle, "MaDoUong").ToString();
            soLuongMua = Convert.ToInt32(grvChiTietHoaDon.GetRowCellValue(e.RowHandle, "SoLuong").ToString());

        }

        private void btnDoiBan_Click(object sender, EventArgs e)
        {           
            frmDoiBan db = new frmDoiBan();
            db.MaHoaDon = lblMaHoaDon.Text;
            db.BllBanHang = bllBanHang;
            db.ShowDialog();
            bllBanHang.DongBan(maBan);
            fpnlBan.Controls.Clear();
            LoadBan(cboViTri.SelectedValue.ToString());
            
        }
    }
}
