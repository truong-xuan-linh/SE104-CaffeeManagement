using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_HoaDonAndCTHD
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_HoaDonAndCTHD()
        {

        }
        public IQueryable LoadHoaDon()
        {
            var hoaDons = from hd in qlcf.HoaDons
                          join nv in qlcf.NhanViens on hd.MaNhanVien equals nv.MaNhanVien
                          join b in qlcf.Bans on hd.MaBan equals b.MaBan
                          join kh in qlcf.KhachHangs on hd.MaKhachHang equals kh.MaKhachHang
                          select new { hd.MaHoaDon, b.TenBan, nv.TenNhanVien, kh.TenKhachHang, hd.NgayLap, hd.GioVao, hd.GioRa, hd.TrangThai, hd.GiamGia, hd.TongTien };
            return hoaDons;
        }
        public IQueryable LoadCTHD(string maHoaDon)
        {
            var cthds = from cthd in qlcf.ChiTietHoaDons
                        join du in qlcf.DoUongs on cthd.MaDoUong equals du.MaDoUong
                        where cthd.MaHoaDon == maHoaDon
                        select new {du.TenDoUong, cthd.SoLuong, cthd.ThanhTien };
            return cthds;
        }
    }
}
