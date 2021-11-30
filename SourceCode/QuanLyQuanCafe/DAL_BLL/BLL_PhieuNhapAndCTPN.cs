using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_PhieuNhapAndCTPN
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_PhieuNhapAndCTPN()
        {

        }
        public IQueryable<NhaCungCap> LoadNhaCungCap()
        {
            return qlcf.NhaCungCaps.Select(ncc => ncc);
        }
        public IQueryable<NguyenLieu> LoadNguyenLieu()
        {
            return qlcf.NguyenLieus.Select(nl => nl);
        }
        public IQueryable LoadPhieuNhap()
        {
            var phieuNhaps = from pn in qlcf.PhieuNhaps
                             join nv in qlcf.NhanViens on pn.MaNhanVien equals nv.MaNhanVien
                             join ncc in qlcf.NhaCungCaps on pn.MaNCC equals ncc.MaNCC
                             select new { pn.MaPhieuNhap, nv.TenNhanVien, ncc.TenNCC, pn.NgayLap, pn.TongTien };
            return phieuNhaps;
        }
        public IQueryable LoadCTPN(string maPhieuNhap)
        {
            var ctpns = from ctpn in qlcf.ChiTietPhieuNhaps
                        join nl in qlcf.NguyenLieus on ctpn.MaNguyenLieu equals nl.MaNguyenLieu
                        where ctpn.MaPhieuNhap == maPhieuNhap
                        select new {ctpn.MaCTPN, nl.MaNguyenLieu, nl.TenNguyenLieu, ctpn.SoLuong, ctpn.DonGiaNhap, nl.DonViTinh, ctpn.ThanhTien };
            return ctpns;
        }
        public string GetMaNhanVien(string username)
        {     
            NhanVien nv = qlcf.NhanViens.Where(n => n.TenDangNhap == username).FirstOrDefault();
            return nv.MaNhanVien;         
        }
        public string GetTenNhanVien(string username)
        {
            NhanVien nv = qlcf.NhanViens.Where(tdn => tdn.TenDangNhap == username).FirstOrDefault();
            return nv.TenNhanVien;
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
        public string PhatSinhMaPhieuNhap()
        {
            string maPhieuNhap = "PN";
            List<PhieuNhap> lstPhieuNhap = qlcf.PhieuNhaps.Select(pn => pn).ToList();
            PhieuNhap phieuNhap = lstPhieuNhap.LastOrDefault();
            if(phieuNhap == null)
            {
                maPhieuNhap += "1000";
            }
            else
            {
                int k;
                k = Convert.ToInt32(phieuNhap.MaPhieuNhap.Substring(2, 4));
                k += 1;
                maPhieuNhap += k.ToString();
            }
            return maPhieuNhap;
        }
        public string PhatSinhMaCTPN(string maPhieuNhap)
        {
            string maCTPN = maPhieuNhap;
            List<ChiTietPhieuNhap> lstCTPN = qlcf.ChiTietPhieuNhaps.Where(ct => ct.MaPhieuNhap == maPhieuNhap).Select(ct => ct).ToList();
            ChiTietPhieuNhap ctpn = lstCTPN.LastOrDefault();
            if (ctpn == null)
            {
                maCTPN += "_1000";
            }
            else
            {
                int k;
                k = Convert.ToInt32(ctpn.MaCTPN.Substring(7, 4));
                k += 1;
                maCTPN += "_" + k.ToString();
            }
            return maCTPN;
        }
        public void UpdateTongTienForPhieuNhap(string maPhieuNhap)
        {
            List<ChiTietPhieuNhap> lstCTPN = qlcf.ChiTietPhieuNhaps.Where(ctpn => ctpn.MaPhieuNhap == maPhieuNhap).Select(ctpn => ctpn).ToList();
            PhieuNhap phieuNhap = qlcf.PhieuNhaps.Where(pn => pn.MaPhieuNhap == maPhieuNhap).FirstOrDefault();
            if(phieuNhap != null)
            {
                phieuNhap.TongTien = lstCTPN.Sum(ctpn => ctpn.ThanhTien);
                qlcf.SubmitChanges();
            }
        }
        public int GetTongTienPhieuNhap(string maPhieuNhap)
        {
            int tongTien = 0;
            PhieuNhap phieuNhap = qlcf.PhieuNhaps.Where(pn => pn.MaPhieuNhap == maPhieuNhap).FirstOrDefault();
            if (phieuNhap != null)
            {
                try
                {
                    tongTien = (int)phieuNhap.TongTien;
                }
                catch (Exception)
                {
                    tongTien = 0;
                }
            }
            return tongTien;
        }
        public void InsertNewPhieuNhap(string maPhieuNhap, string maNhanVien, string maNCC, DateTime ngayLap)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieuNhap = maPhieuNhap;
            pn.MaNhanVien = maNhanVien;
            pn.MaNCC = maNCC;
            pn.NgayLap = ngayLap;
            pn.TongTien = 0;

            qlcf.PhieuNhaps.InsertOnSubmit(pn);
            qlcf.SubmitChanges();
        }
        public void DeletePhieuNhap(string maPhieuNhap)
        {
            List<ChiTietPhieuNhap> lstCTPN = qlcf.ChiTietPhieuNhaps.Where(ct => ct.MaPhieuNhap == maPhieuNhap).Select(ct => ct).ToList();
            PhieuNhap phieuNhap = qlcf.PhieuNhaps.Where(pn => pn.MaPhieuNhap == maPhieuNhap).FirstOrDefault();
            if(phieuNhap != null)
            {
                foreach (var item in lstCTPN)
                {
                    qlcf.ChiTietPhieuNhaps.DeleteOnSubmit(item);
                    qlcf.SubmitChanges();
                }
                qlcf.PhieuNhaps.DeleteOnSubmit(phieuNhap);
                qlcf.SubmitChanges();
            }
        }
        public void InsertChiTietPhieuNhap(string maPhieuNhap, string maNguyenLieu, int donGiaNhap, int soLuong)
        {
            ChiTietPhieuNhap cts = qlcf.ChiTietPhieuNhaps.Where(ct => ct.MaPhieuNhap == maPhieuNhap && ct.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if(cts == null)
            {
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                ctpn.MaCTPN = PhatSinhMaCTPN(maPhieuNhap);
                ctpn.MaPhieuNhap = maPhieuNhap;
                ctpn.MaNguyenLieu = maNguyenLieu;
                ctpn.DonGiaNhap = donGiaNhap;
                ctpn.SoLuong = soLuong;
                ctpn.ThanhTien = donGiaNhap * soLuong;

                qlcf.ChiTietPhieuNhaps.InsertOnSubmit(ctpn);
                qlcf.SubmitChanges();
            }
            else
            {
                cts.DonGiaNhap = donGiaNhap;
                cts.SoLuong += soLuong;
                cts.ThanhTien = cts.SoLuong * donGiaNhap;
                qlcf.SubmitChanges();
            }
        }
        public void DeleteChiTietPhieuNhap(string maCTPN)
        {
            ChiTietPhieuNhap ctpn = qlcf.ChiTietPhieuNhaps.Where(ct => ct.MaCTPN == maCTPN).FirstOrDefault();
            if(ctpn != null)
            {
                qlcf.ChiTietPhieuNhaps.DeleteOnSubmit(ctpn);
                qlcf.SubmitChanges();
            }
        }
        public void UpdateCongSoLuongTonNguyenLieu(string maNguyenLieu, int soLuongNhap)
        {
            NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if(nl != null)
            {
                nl.SoLuongTon += soLuongNhap;
                qlcf.SubmitChanges();
            }
        }
        public void UpdateTruSoLuongTonNguyenLieu(string maNguyenLieu, int soLuongNhap)
        {
            NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == maNguyenLieu).FirstOrDefault();
            if (nl != null)
            {
                nl.SoLuongTon -= soLuongNhap;
                qlcf.SubmitChanges();
            }
        }

    }
}
