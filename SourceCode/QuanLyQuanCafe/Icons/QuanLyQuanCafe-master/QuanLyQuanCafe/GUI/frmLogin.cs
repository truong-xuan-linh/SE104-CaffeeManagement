using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_BLL;

namespace GUI
{
    public partial class frmLogin : Form
    {
        BLL_UserManagement userManagement = new BLL_UserManagement();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Focus();
                return;
            }
            if (userManagement.Check_Config() == 0)
                ProcessLogin();
            if (userManagement.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProcessConfig();
            }
            if (userManagement.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProcessConfig();
            }
        }

        private void ProcessConfig()
        {
            frmConfig config = new frmConfig();
            config.ShowDialog();
        }

        private void ProcessLogin()
        {
            int result;
            result = userManagement.Check_User(txtUsername.Text, txtPassword.Text);
            if (result == 0) //Tài khoản không tồn tại
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 1)
            {
                MessageBox.Show("Tài khoản bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int typeOfAccount = userManagement.CheckTypeOfAccount(txtUsername.Text);
            if(typeOfAccount == 4)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            openMainForm(typeOfAccount);
                


        }
        public void ClearText()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
        public void openMainForm(int typeOfAccount)
        {           
            frmMainMenu main = new frmMainMenu();
            main.TypeOfAccount = typeOfAccount;
            main.UserName = txtUsername.Text;
            this.Hide();
            main.ShowDialog();        
            this.Show();
            ClearText();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ProcessConfig();
        }
    }
}
