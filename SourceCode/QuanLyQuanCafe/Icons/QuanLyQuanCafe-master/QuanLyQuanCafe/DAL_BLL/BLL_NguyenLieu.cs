using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_NguyenLieu
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_NguyenLieu()
        {

        }       
        public IQueryable<NguyenLieu> LoadNguyenLieu()
        {
            return qlcf.NguyenLieus.Select(nl => nl);
        }
        public string PhatSinhMaTuDong()
        {
            string maNguyenLieu = "NL";
            List<NguyenLieu> lstNguyenLieu = qlcf.NguyenLieus.Select(nl => nl).ToList();
            NguyenLieu nguyenLieu = lstNguyenLieu.LastOrDefault();
            if(nguyenLieu == null)
            {
                maNguyenLieu += "100";
            }
            else
            {
                int k;
                k = Convert.ToInt32(nguyenLieu.MaNguyenLieu.Substring(2, 3));
                k += 1;
                maNguyenLieu += k.ToString();
            }
            return maNguyenLieu;
        }
        public void InsertNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string donViTinh)
        {
            NguyenLieu nl = new NguyenLieu();
            nl.MaNguyenLieu = maNguyenLieu;
            nl.TenNguyenLieu = tenNguyenLieu;
            nl.DonViTinh = donViTinh;
            nl.SoLuongTon = 0;

            qlcf.NguyenLieus.InsertOnSubmit(nl);
            qlcf.SubmitChanges();
        }
        public bool KiemTraKhoaNgoaiNguyenLieu(string maNguyenLieu)
        {
            CongThuc ct = qlcf.CongThucs.Where(c => c.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            ChiTietPhieuNhap ctpn = qlcf.ChiTietPhieuNhaps.Where(c => c.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if (ct == null && ctpn == null)
                return false;
            else
                return true;
        }
        public void DeleteNguyenLieu(string maNguyenLieu)
        {
            NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if(nl != null)
            {
                qlcf.NguyenLieus.DeleteOnSubmit(nl);
                qlcf.SubmitChanges();
            }
        }
        public void UpdateNguyenLieu(string maNguyenLieu, string tenNguyenLieu, string donViTinh)
        {
            NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if (nl != null)
            {
                nl.TenNguyenLieu = tenNguyenLieu;
                nl.DonViTinh = donViTinh;
                qlcf.SubmitChanges();
            }
        }
    }
}
