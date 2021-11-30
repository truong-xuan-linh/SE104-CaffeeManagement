using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_ThongKe
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_ThongKe()
        {

        }
        public IQueryable LoadThongKeTopPick()
        {
            var thongKes = from cthd in qlcf.ChiTietHoaDons
                           group new { cthd.DoUong, cthd } by new { cthd.DoUong.TenDoUong } into g
                           select new { g.Key.TenDoUong, SoLuong = g.Sum(p => p.cthd.SoLuong) };
            return thongKes.Take(15);
        }
        public IQueryable LoadThongKeDoanhThu(int thang, int nam)
        {
            var doanhThus = from hd in qlcf.HoaDons
                            where hd.NgayLap.Value.Month == thang && hd.NgayLap.Value.Year == nam
                            group hd by new { hd.NgayLap } into g
                            select new { g.Key.NgayLap, DoanhThu = g.Sum(p => p.TongTien) };
            return doanhThus;
        }
        public IQueryable LoadThongKeDoanhThuTheoNgay(DateTime ngayBD, DateTime ngayKT)
        {
            var doanhThus = from hd in qlcf.HoaDons
                            where hd.NgayLap.Value >= ngayBD && hd.NgayLap.Value <= ngayKT
                            group hd by new { hd.NgayLap } into g
                            select new { g.Key.NgayLap, DoanhThu = g.Sum(p => p.TongTien) };
            return doanhThus;
        }
    }
}
