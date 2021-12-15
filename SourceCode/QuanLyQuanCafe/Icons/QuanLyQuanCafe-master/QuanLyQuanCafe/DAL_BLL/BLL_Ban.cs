using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_Ban
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_Ban()
        {

        }
        public IQueryable<ViTri> LoadViTri()
        {
            return qlcf.ViTris.Select(vt => vt);
        }
        public IQueryable<Ban> LoadBan()
        {
            return qlcf.Bans.Select(b => b);
        }
        public IQueryable LoadBanTheoTang(string diadiem)
        {
            var bans = from b in qlcf.Bans
                       join vt in qlcf.ViTris on b.MaViTri equals vt.MaViTri
                       where b.MaViTri == diadiem
                       select new { b.MaBan, b.TenBan, vt.TenViTri, b.TrangThai };
            return bans;
        }
        public int GetSoLuongBanTrong()
        {
            return qlcf.Bans.Where(b => b.TrangThai == "Trống").Select(b => b).Count();
        }
        public int GetSoLuongBanCoKhach()
        {
            return qlcf.Bans.Where(b => b.TrangThai == "Có khách").Select(b => b).Count();
        }
        public string PhatSinhMaBan(string maViTri)
        {
            string maBan = maViTri;
            List<Ban> bans = qlcf.Bans.Where(b => b.MaViTri == maViTri).Select(b => b).ToList();
            Ban ban = bans.LastOrDefault();
            if (ban == null)
            {
                maBan += "100";
            }
            else
            {
                int k;
                k = Convert.ToInt32(ban.MaBan.Substring(1, 3));
                k += 1;
                maBan += k.ToString();
            }
            return maBan;
        }
        public bool KiemTraKhoaNgoaiBan(string maBan)
        {
            HoaDon hoaDon = qlcf.HoaDons.Where(hd => hd.MaBan == maBan).FirstOrDefault();
            if (hoaDon == null)
                return false;
            else
                return true;
        }
        public void InsertBan(string maBan, string tenBan, string maViTri)
        {
            Ban ban = new Ban();
            ban.MaBan = maBan;
            ban.TenBan = tenBan;
            ban.MaViTri = maViTri;
            ban.TrangThai = "Trống";

            qlcf.Bans.InsertOnSubmit(ban);
            qlcf.SubmitChanges();
        }
        public void DeleteBan(string maBan)
        {
            Ban ban = qlcf.Bans.Where(b => b.MaBan == maBan).FirstOrDefault();
            if (ban != null)
            {
                qlcf.Bans.DeleteOnSubmit(ban);
                qlcf.SubmitChanges();
            }
        }
        public void UpdateBan(string maBan, string tenBan, string maViTri)
        {
            Ban ban = qlcf.Bans.Where(b => b.MaBan == maBan).FirstOrDefault();
            if (ban != null)
            {
                ban.TenBan = tenBan;
                qlcf.SubmitChanges();
            }
        }

    }
}
