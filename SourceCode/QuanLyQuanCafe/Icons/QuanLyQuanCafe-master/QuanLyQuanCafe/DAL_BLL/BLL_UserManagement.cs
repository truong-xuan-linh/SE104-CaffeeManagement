using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;

namespace DAL_BLL
{
    public class BLL_UserManagement
    {
        public BLL_UserManagement()
        {

        }
        QLCFDataContext qlcf = new QLCFDataContext();    
        public int Check_Config()
        {
            if (Properties.Settings.Default.dbQLQCFConn == string.Empty)
            {
                return 1; //Chuỗi cấu hình không tồn tại
            }
            SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.dbQLQCFConn);
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                    sqlConn.Open();
                return 0; //Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch (Exception)
            {
                return 2; //Chuỗi cấu hình không phù hợp
            }
        }
        public int Check_User(string strUsername, string strPassword)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("SELECT * FROM NhanVien WHERE TenDangNhap = '" + strUsername + "' AND MatKhau = '" + strPassword + "'", Properties.Settings.Default.dbQLQCFConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0; //User không tồn tại
            //else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            //{
            //    return 1; //Không hoạt động
            //}
            return 2; //Đăng nhập thành công
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable GetDBName(string strServer, string strUsername, string strPassword)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NAME FROM sys.Databases", "Data Source=" + strServer + ";Initial Catalog=master;User ID=" + strUsername + ";Password=" + strPassword + "");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfig(string strServer, string strUsername, string strPassword, string strDBName)
        {         
            DAL_BLL.Properties.Settings.Default.dbQLQCFConn = "Data Source=" + strServer + ";Initial Catalog=" + strDBName + ";User ID=" + strUsername + ";Password=" + strPassword + "";
            //DAL_BLL.Properties.Settings.Default.dbQuanLyQuanCafeConnectionString = "Data Source=" + strServer + ";Initial Catalog=" + strDBName + ";User ID=" + strUsername + ";Password=" + strPassword + "";
            DAL_BLL.Properties.Settings.Default.Save();
        }
        public void SaveLinqConfig(string strServer, string strUsername, string strPassword, string strDBName)
        {
            string connectionString = "Data Source=" + strServer + ";Initial Catalog=" + strDBName + ";User ID=" + strUsername + ";Password=" + strPassword + "";           
            
        }
        public int CheckTypeOfAccount(string tenDangNhap)
        {
            NhanVien nv = qlcf.NhanViens.Where(tdn => tdn.TenDangNhap == tenDangNhap).FirstOrDefault();
            if (nv.MaLoaiTaiKhoan == "1")
                return 1;
            else if (nv.MaLoaiTaiKhoan == "2")
                return 2;
            else if (nv.MaLoaiTaiKhoan == "3")
                return 3;
            else
                return 4;
        }
        public string GetDisplayName(string tenDangNhap)
        {
            NhanVien nv = qlcf.NhanViens.Where(tdn => tdn.TenDangNhap == tenDangNhap).FirstOrDefault();
            return nv.TenNhanVien.ToString();
        }
        public string GetMaNhanVien(string tenDangNhap)
        {
            NhanVien nv = qlcf.NhanViens.Where(tdn => tdn.TenDangNhap == tenDangNhap).FirstOrDefault();
            return nv.MaNhanVien.ToString();
        }
        public string GetTenLoaiTaiKhoan(string tenDangNhap)
        {

            NhanVien nv = qlcf.NhanViens.Where(tdn => tdn.TenDangNhap == tenDangNhap).FirstOrDefault();
            string maLoaiTaiKhoan = nv.MaLoaiTaiKhoan;

            LoaiTaiKhoan ltk = qlcf.LoaiTaiKhoans.Where(mltk => mltk.MaLoaiTaiKhoan == maLoaiTaiKhoan).FirstOrDefault();
            return ltk.TenLoaiTaiKhoan.ToString();
        }
        
    }
}
