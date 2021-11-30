using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_NhanVien
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_NhanVien()
        {

        }
        public IQueryable<LoaiTaiKhoan> LoadLoaiTaiKhoan()
        {
            return qlcf.LoaiTaiKhoans.Select(ltk => ltk);
        }
        public IQueryable LoadNhanVien(string maLoaiTaiKhoan)
        {
            var nhanViens = from nv in qlcf.NhanViens
                            join ltk in qlcf.LoaiTaiKhoans on nv.MaLoaiTaiKhoan equals ltk.MaLoaiTaiKhoan
                            where nv.MaLoaiTaiKhoan == maLoaiTaiKhoan
                            select new {nv.MaNhanVien, nv.TenNhanVien, nv.TenDangNhap, nv.MatKhau, ltk.TenLoaiTaiKhoan, nv.GioiTinh, nv.SDT, nv.DiaChi };
            return nhanViens;
        }
        public string PhatSinhMaNhanVien()
        {
            string maNhanVien = "NV";
            List<NhanVien> nhanViens = qlcf.NhanViens.Select(nv => nv).ToList();
            NhanVien nhanvien = nhanViens.LastOrDefault();
            if(nhanvien == null)
            {
                maNhanVien += "100";
            }
            else
            {
                int k;
                k = Convert.ToInt32(nhanvien.MaNhanVien.Substring(2, 3));
                k += 1;
                maNhanVien += k.ToString();
            }
            return maNhanVien;
        }
        public bool KiemTraKhoaNgoaiNhanVien(string maNhanVien)
        {
            HoaDon hoaDon = qlcf.HoaDons.Where(hd => hd.MaNhanVien == maNhanVien).FirstOrDefault();
            if (hoaDon == null)
                return false;
            else
                return true;
        }
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            NhanVien nhanVien = qlcf.NhanViens.Where(nv => nv.TenDangNhap == tenDangNhap).FirstOrDefault();
            if (nhanVien == null)
                return false;
            else
                return true;
        }
        public void InsertNhanVien(string maNhanVien, string tenNhanVien, string tenDangNhap, string matKhau, string maLoaiTaiKhoan, string gioiTinh, string sdt, string diaChi)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNhanVien = maNhanVien;
            nhanVien.TenNhanVien = tenNhanVien;
            nhanVien.TenDangNhap = tenDangNhap;
            nhanVien.MatKhau = matKhau;
            nhanVien.MaLoaiTaiKhoan = maLoaiTaiKhoan;
            nhanVien.GioiTinh = gioiTinh;
            nhanVien.SDT = sdt;
            nhanVien.DiaChi = diaChi;

            qlcf.NhanViens.InsertOnSubmit(nhanVien);
            qlcf.SubmitChanges();
        }
        public void DeleteNhanVien(string maNhanVien)
        {
            NhanVien nhanVien = qlcf.NhanViens.Where(nv => nv.MaNhanVien == maNhanVien).FirstOrDefault();
            if(nhanVien != null)
            {
                qlcf.NhanViens.DeleteOnSubmit(nhanVien);
                qlcf.SubmitChanges();
            }
        }
        public void UpdateNhanVien(string maNhanVien, string tenNhanVien, string tenDangNhap, string matKhau, string maLoaiTaiKhoan, string gioiTinh, string sdt, string diaChi)
        {
            NhanVien nhanVien = qlcf.NhanViens.Where(nv => nv.MaNhanVien == maNhanVien).FirstOrDefault();
            if (nhanVien != null)
            {
                nhanVien.TenNhanVien = tenNhanVien;
                nhanVien.TenDangNhap = tenDangNhap;
                nhanVien.MatKhau = matKhau;
                nhanVien.MaLoaiTaiKhoan = maLoaiTaiKhoan;
                nhanVien.GioiTinh = gioiTinh;
                nhanVien.SDT = sdt;
                nhanVien.DiaChi = diaChi;

                qlcf.SubmitChanges();
            }
        }

    }
}
