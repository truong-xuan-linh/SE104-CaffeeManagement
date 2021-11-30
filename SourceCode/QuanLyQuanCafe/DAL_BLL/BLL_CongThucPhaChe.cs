using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_CongThucPhaChe
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_CongThucPhaChe()
        {

        }
        public IQueryable<NguyenLieu> LoadNguyenLieu()
        {
            return qlcf.NguyenLieus.Select(nl => nl);
        }
        public IQueryable LoadDoUong()
        {
            var doUongs = from du in qlcf.DoUongs
                          join dm in qlcf.DanhMucDoUongs on du.MaDanhMuc equals dm.MaDanhMuc                        
                          select new { du.MaDoUong, du.TenDoUong, dm.TenDanhMuc, du.Gia };
            return doUongs;
        }
        public IQueryable LoadCongThucPhaChe(string maDoUong)
        {
            var congThucs = from ct in qlcf.CongThucs
                            join du in qlcf.DoUongs on ct.MaDoUong equals du.MaDoUong
                            join nl in qlcf.NguyenLieus on ct.MaNguyenLieu equals nl.MaNguyenLieu
                            where ct.MaDoUong == maDoUong
                            select new { ct.MaDoUong, ct.MaNguyenLieu, nl.TenNguyenLieu, ct.SoLuong, nl.DonViTinh };
            return congThucs;
        }
        public string GetDonViTinh(string maNguyenLieu)
        {
            NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if(nl != null)
            {
                return nl.DonViTinh;
            }
            return string.Empty;
        }
        public void InsertCongThuc(string maDoUong, string maNguyenLieu, int soLuong)
        {
            CongThuc cts = qlcf.CongThucs.Where(c => c.MaDoUong == maDoUong && c.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if(cts == null)
            {
                CongThuc ct = new CongThuc();
                ct.MaDoUong = maDoUong;
                ct.MaNguyenLieu = maNguyenLieu;
                ct.SoLuong = soLuong;
                qlcf.CongThucs.InsertOnSubmit(ct);
                qlcf.SubmitChanges();
            }
            else
            {
                cts.SoLuong += soLuong;
                qlcf.SubmitChanges();
            }
        }
        public void DeleteCongThuc(string maDoUong, string maNguyenLieu)
        {
            CongThuc cts = qlcf.CongThucs.Where(c => c.MaDoUong == maDoUong && c.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if (cts != null)
            {               
                qlcf.CongThucs.DeleteOnSubmit(cts);
                qlcf.SubmitChanges();
            }
        }
    }
}
