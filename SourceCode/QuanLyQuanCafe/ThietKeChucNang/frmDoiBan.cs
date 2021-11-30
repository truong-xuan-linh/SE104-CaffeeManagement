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
    public partial class frmDoiBan : Form
    {
        BLL_BanHang bllBanHang;
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        string maHoaDon;
        string maBan;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public BLL_BanHang BllBanHang { get => bllBanHang; set => bllBanHang = value; }

        public frmDoiBan()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void LoadBan(string viTri)
        {
            int width = 90;
            int height = 60;

            foreach (var item in BllBanHang.LoadBanTheoTang(viTri))
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

        private void btnBan_Click(object sender, EventArgs e)
        {
            Button btnBan = sender as Button;
            maBan = btnBan.Name.ToString();
            lblTenBan.Text = btnBan.Text;
            if (btnBan.BackColor == Color.DarkGreen)
            {
                btnDoiBan.Visible = true;
            }
            else
                btnDoiBan.Visible = false;
        }

        private void frmDoiBan_Load(object sender, EventArgs e)
        {
            string themeColor = bllCaiDat.GetThemeColor();
            pnlThanhTieuDe.BackColor = pnlLeft.BackColor = pnlRight.BackColor = pnlBottom.BackColor = lblTenBan.ForeColor = btnDoiBan.BackColor = bllCaiDat.SelectThemeColor(themeColor);
            cboViTri.DataSource = BllBanHang.LoadViTri();
            cboViTri.DisplayMember = "TenViTri";
            cboViTri.ValueMember = "MaViTri";
            LoadBan(cboViTri.SelectedValue.ToString());
        }

        private void cboViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            fpnlBan.Controls.Clear();
            LoadBan(cboViTri.SelectedValue.ToString());
        }

        private void btnDoiBan_Click(object sender, EventArgs e)
        {       
            BllBanHang.MoBan(maBan);
            BllBanHang.DoiBan(MaHoaDon, maBan);        
            MessageBox.Show("Đã đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            this.Close();
        }

        private void pnlThanhTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
