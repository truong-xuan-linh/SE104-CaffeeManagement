using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ThietKeChucNang;
using DAL_BLL;
namespace GUI
{
    public partial class frmMainMenu : Form
    {

        //Fields
        BLL_CaiDat bllCaiDat = new BLL_CaiDat();
        private Button currentButton;
        private string hexcolor;
        private int typeOfAccount;
        private string userName;

        public int TypeOfAccount { get => typeOfAccount; set => typeOfAccount = value; }
        public string UserName { get => userName; set => userName = value; }

        //Contructor
        public frmMainMenu()
        {
            InitializeComponent();
        }

        //Method
        private Color SelectThemeColor(string color)
        {
            return ColorTranslator.FromHtml(color);
        }
        public void GetThemeColor()
        {
            hexcolor = bllCaiDat.GetThemeColor();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = SelectThemeColor(hexcolor);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTieuDe.Text = currentButton.Tag.ToString();
                    //ThemeColor.PrimaryColor = SelectThemeColor(hexcolor);
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(SelectThemeColor(hexcolor), -0.3);                  
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        //-------------------------------------------------------------------------------

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            GetThemeColor();
            ucWelcome ucWelcomeCF = new ucWelcome();
            ucWelcomeCF.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucWelcomeCF);
            pnlThanhTieuDe.BackColor = SelectThemeColor(hexcolor);
            pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(SelectThemeColor(hexcolor), -0.3);
            if (TypeOfAccount == 2) 
            {
                btnQuanLy.Visible = false;
                btnKhoNVL.Visible = false;
                btnThongKe.Visible = false;
            }
            else if (TypeOfAccount == 3)
            {
                btnQuanLy.Visible = false;
                btnThongKe.Visible = false;
                btnBanHang.Visible = false;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        //-------------------------------------------------------------------------
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            pnlMain.Controls.Clear();          
            ucTrangChu ucTrangChuCF = new ucTrangChu();
            ucTrangChuCF.Dock = DockStyle.Fill;
            ucTrangChuCF.GetDisplayName(UserName);
            ucTrangChuCF.GetChucVu(UserName);
            pnlMain.Controls.Add(ucTrangChuCF);
            //ucTrangChuCF.BringToFront();
                   
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            pnlMain.Controls.Clear();
            ucBanHang ucBanHangCF = new ucBanHang();
            ucBanHangCF.Dock = DockStyle.Fill;
            ucBanHangCF.GetUserName(UserName);
            pnlMain.Controls.Add(ucBanHangCF);
            //ucBanHangCF.BringToFront();

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            pnlMain.Controls.Clear();
            ucQuanLy ucQuanLyCF = new ucQuanLy();
            ucQuanLyCF.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucQuanLyCF);
            //ucQuanLyCF.BringToFront();
                 
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            pnlMain.Controls.Clear();
            ucThongKe ucThongKeCF = new ucThongKe();
            ucThongKeCF.Dock = DockStyle.Fill;
            ucThongKeCF.LoadThongKeTopPick();
            pnlMain.Controls.Add(ucThongKeCF);
            //ucThongKeCF.BringToFront();
        }
        private void btnKhoNVL_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            pnlMain.Controls.Clear();
            ucKhoNVL ucKhoNVLCF = new ucKhoNVL();
            ucKhoNVLCF.Dock = DockStyle.Fill;
            ucKhoNVLCF.GetUserName(UserName);
            ucKhoNVLCF.LoadQuanLyNguyenLieu();
            pnlMain.Controls.Add(ucKhoNVLCF);
            //ucKhoNVLCF.BringToFront();
            
        }
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            pnlMain.Controls.Clear();
            ucCaiDat ucCaiDatCF = new ucCaiDat();
            ucCaiDatCF.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucCaiDatCF);
            //ucCaiDatCF.BringToFront();

        }
        
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           
            currentButton = (Button)sender;
            currentButton.BackColor = Color.Red;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close();
            currentButton.BackColor = Color.FromArgb(51, 51, 76);
            currentButton.ForeColor = Color.Gainsboro;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn muốn đăng xuất chứ?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
        private void pnlThanhTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            pnlMain.Controls.Clear();
            ucCaiDat ucCaiDatCF = new ucCaiDat();
            ucCaiDatCF.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ucCaiDatCF);
            //ucCaiDatCF.BringToFront();
        }
    }
}
