using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_KhachHang
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_KhachHang()
        {

        }
        public IQueryable<LoaiKhachHang> LoadLoaiKhachHang()
        {
            return qlcf.LoaiKhachHangs.Select(lkh => lkh);
        }
        public IQueryable LoadKhachHang(string maLoaiKhachHang)
        {
            var khachHangs = from kh in qlcf.KhachHangs
                             join lkh in qlcf.LoaiKhachHangs on kh.MaLoaiKhachHang equals lkh.MaLoaiKhachHang
                             where kh.MaLoaiKhachHang == maLoaiKhachHang
                             select new { kh.MaKhachHang, kh.TenKhachHang, lkh.TenLoaiKhachHang, kh.SoDienThoai, kh.DiemTichLuy, kh.DiaChi };
            return khachHangs;
        }
        public string PhatSinhMaKhachHang()
        {
            string maKhachHang = "KH";
            List<KhachHang> lstKhachHang = qlcf.KhachHangs.Select(kh => kh).ToList();
            KhachHang khachHang = lstKhachHang.LastOrDefault();
            if(khachHang == null)
            {
                maKhachHang += "100";
            }
            else
            {
                int k;
                k = Convert.ToInt32(khachHang.MaKhachHang.Substring(2, 3));
                k += 1;
                maKhachHang += k.ToString();
            }
            return maKhachHang;
        }
        public bool KiemTraKhoaNgoaiKhachHang(string maKhachHang)
        {
            HoaDon hoaDon = qlcf.HoaDons.Where(hd => hd.MaKhachHang == maKhachHang).FirstOrDefault();
            if (hoaDon == null)
                return false;
            else
                return true;
        }
        public bool KiemTraTrungSDT(string soDienThoai)
        {
            KhachHang kh = qlcf.KhachHangs.Where(k => k.SoDienThoai == soDienThoai).FirstOrDefault();
            if (kh == null)
                return false;
            else
                return true;
        }
        public void InsertKhachHang(string maKhachHang, string tenKhachHang, string maLoaiKhachHang, string soDienThoai, string diaChi)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = maKhachHang;
            kh.TenKhachHang = tenKhachHang;
            kh.MaLoaiKhachHang = maLoaiKhachHang;
            kh.DiemTichLuy = 0;
            kh.SoDienThoai = soDienThoai;
            kh.DiaChi = diaChi;

            qlcf.KhachHangs.InsertOnSubmit(kh);
            qlcf.SubmitChanges();
        }
        public void DeleteKhachHang(string maKhachHang)
        {
            KhachHang kh = qlcf.KhachHangs.Where(k => k.MaKhachHang == maKhachHang).FirstOrDefault();
            if(kh != null)
            {
                qlcf.KhachHangs.DeleteOnSubmit(kh);
                qlcf.SubmitChanges();
            }
        }
        public void UpdateKhachHang(string maKhachHang, string tenKhachHang, string maLoaiKhachHang, string soDienThoai, string diaChi)
        {
            KhachHang kh = qlcf.KhachHangs.Where(k => k.MaKhachHang == maKhachHang).FirstOrDefault();
            if (kh != null)
            {
                kh.TenKhachHang = tenKhachHang;
                kh.MaLoaiKhachHang = maLoaiKhachHang;
                kh.SoDienThoai = soDienThoai;
                kh.DiaChi = diaChi;
                qlcf.SubmitChanges();
            }
        }
    }
}
