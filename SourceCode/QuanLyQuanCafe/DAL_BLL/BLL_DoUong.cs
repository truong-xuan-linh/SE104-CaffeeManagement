using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_DoUong
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_DoUong()
        {

        }
        public IQueryable<DanhMucDoUong> LoadDanhMucDoUong()
        {
            return qlcf.DanhMucDoUongs.Select(dm => dm);
        }
        public IQueryable LoadDoUong(string maDanhMuc)
        {
            var doUongs = from du in qlcf.DoUongs
                          join dm in qlcf.DanhMucDoUongs on du.MaDanhMuc equals dm.MaDanhMuc
                          where du.MaDanhMuc == maDanhMuc
                          select new { du.MaDoUong, du.TenDoUong, dm.TenDanhMuc, du.Gia, du.HinhMinhHoa };
            return doUongs;
        }
        public string PhatSinhMaDoUong(string maDanhMuc)
        {
            string maDoUong = maDanhMuc;
            List<DoUong> doUongs = qlcf.DoUongs.Where(du => du.MaDanhMuc == maDanhMuc).Select(du => du).ToList();
            DoUong doUong = doUongs.LastOrDefault();
            if (doUong == null)
            {
                maDoUong += "100";
            }
            else
            {
                int k;
                k = Convert.ToInt32(doUong.MaDoUong.Substring(2, 3));
                k += 1;
                maDoUong += k.ToString();
            }
            return maDoUong;
        }
        public void InsertDoUong(string maDoUong, string tenDoUong, string maDanhMuc, int giaBan, string hinhMinhHoa)
        {
            DoUong doUong = new DoUong();
            doUong.MaDoUong = maDoUong;
            doUong.TenDoUong = tenDoUong;
            doUong.MaDanhMuc = maDanhMuc;
            doUong.Gia = giaBan;
            doUong.HinhMinhHoa = hinhMinhHoa;

            qlcf.DoUongs.InsertOnSubmit(doUong);
            qlcf.SubmitChanges();
        }
        public bool KiemTraKhoaNgoaiDoUong(string maDoUong)
        {
            ChiTietHoaDon cthd = qlcf.ChiTietHoaDons.Where(ct => ct.MaDoUong == maDoUong).FirstOrDefault();
            if (cthd == null)
                return false;
            else
                return true;
        }
        public void DeleteDoUong(string maDoUong)
        {
            List<CongThuc> cts = qlcf.CongThucs.Where(ct => ct.MaDoUong == maDoUong).ToList();
            DoUong doUong = qlcf.DoUongs.Where(du => du.MaDoUong == maDoUong).FirstOrDefault();
            if(doUong != null)
            {
                if(cts != null)
                {
                    foreach (var item in cts)
                    {
                        qlcf.CongThucs.DeleteOnSubmit(item);
                        qlcf.SubmitChanges();
                    }
                }
                qlcf.DoUongs.DeleteOnSubmit(doUong);
                qlcf.SubmitChanges();
            }
        }
        public void UpdateDoUong(string maDoUong, string tenDoUong, string maDanhMuc, int giaBan, string hinhMinhHoa)
        {
            DoUong doUong = qlcf.DoUongs.Where(du => du.MaDoUong == maDoUong).FirstOrDefault();
            if (doUong != null)
            {
                doUong.TenDoUong = tenDoUong;
                doUong.MaDanhMuc = maDanhMuc;
                doUong.Gia = giaBan;
                doUong.HinhMinhHoa = hinhMinhHoa;
                qlcf.SubmitChanges();
            }
        }
    }
}
