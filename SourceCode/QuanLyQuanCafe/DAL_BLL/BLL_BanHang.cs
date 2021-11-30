using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_BanHang
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_BanHang()
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
        public IQueryable<Ban> LoadBanTheoTang(string diadiem)
        {
            return qlcf.Bans.Where(d => d.MaViTri == diadiem).Select(b => b);
        }
        public IQueryable<DanhMucDoUong> LoadDanhMucDoUong()
        {
            return qlcf.DanhMucDoUongs.Select(dm => dm);
        }
        public IQueryable<DoUong> LoadDoUong(string maDanhMuc)
        {
            return qlcf.DoUongs.Where(dm => dm.MaDanhMuc == maDanhMuc).Select(du => du);
        }
        public IQueryable LoadChiTietHoaDon(string maHoaDon)
        {
            var cthds = from cthd in qlcf.ChiTietHoaDons
                        join du in qlcf.DoUongs on cthd.MaDoUong equals du.MaDoUong
                        where cthd.MaHoaDon == maHoaDon
                        select new { cthd.MaCTHD, cthd.MaDoUong, du.TenDoUong, du.Gia, cthd.SoLuong, cthd.ThanhTien };

            return cthds;
        }
        public void MoBan(string maBan)
        {
            Ban ban = qlcf.Bans.Where(mb => mb.MaBan == maBan).FirstOrDefault();
            if (ban != null)
            {
                ban.TrangThai = "Có khách";
                qlcf.SubmitChanges();
            }
        }
        public void DongBan(string maBan)
        {
            Ban ban = qlcf.Bans.Where(mb => mb.MaBan == maBan).FirstOrDefault();
            if (ban != null)
            {
                ban.TrangThai = "Trống";
                qlcf.SubmitChanges();
            }
        }
        public string PhatSinhMaHoaDon()
        {
            string maHoaDon = "HD";
            //string ngay = DateTime.Now.ToShortDateString();

            List<HoaDon> lstHoaDon = qlcf.HoaDons.Select(h => h).ToList();
            HoaDon hd = lstHoaDon.LastOrDefault();
            if (hd == null)
            {
                maHoaDon += "1000";
            }
            else
            {
                int k;
                k = Convert.ToInt32(hd.MaHoaDon.Substring(2, 4));
                k += 1;
                maHoaDon += k.ToString();
            }
            return maHoaDon;
        }
        public string PhatSinhMaCTHD(string maHoaDon)
        {
            string maCTHD = maHoaDon;
            List<ChiTietHoaDon> cthds = qlcf.ChiTietHoaDons.Where(ct => ct.MaHoaDon == maHoaDon).Select(ct => ct).ToList();
            ChiTietHoaDon cthd = cthds.LastOrDefault();
            if (cthd == null)
            {
                maCTHD += "_1000";
            }
            else
            {
                int k;
                k = Convert.ToInt32(cthd.MaCTHD.Substring(7, 4));
                k += 1;
                maCTHD += "_" + k.ToString();
            }
            return maCTHD;
        }
        public string GetMaHoaDonOfBan(string maBan)
        {
            string maHoaDon = "";
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaBan == maBan && h.TrangThai == "Chưa thanh toán").FirstOrDefault();
            if (hd != null)
            {
                maHoaDon = hd.MaHoaDon;
            }

            return maHoaDon;
        }
        public void InsertNewHoaDon(string maBan, DateTime ngayLap, DateTime gioVao)
        {
            TimeSpan gv = gioVao.TimeOfDay;
            HoaDon hd = new HoaDon();
            hd.MaHoaDon = PhatSinhMaHoaDon();
            hd.MaBan = maBan;
            hd.MaKhachHang = "KH100";
            hd.NgayLap = ngayLap;
            hd.GioVao = gv;
            hd.TrangThai = "Chưa thanh toán";
            hd.TongTien = 0;

            qlcf.HoaDons.InsertOnSubmit(hd);
            qlcf.SubmitChanges();
        }
        public void DeleteHoaDon(string maHoaDon)
        {
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaHoaDon == maHoaDon).FirstOrDefault();
            if(hd != null)
            {
                qlcf.HoaDons.DeleteOnSubmit(hd);
                qlcf.SubmitChanges();
            }
        }
        public void UpdateTongTienForHoaDon(string maHoaDon)
        {
            List<ChiTietHoaDon> cthds = qlcf.ChiTietHoaDons.Where(ct => ct.MaHoaDon == maHoaDon).Select(ct => ct).ToList();
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaHoaDon == maHoaDon).FirstOrDefault();
            if (hd != null)
            {
                hd.TongTien = cthds.Sum(ct => ct.ThanhTien);
                qlcf.SubmitChanges();
            }
        }
        public int GetTongTienHoaDon(string maHoaDon)
        {
            int tongTien = 0;
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaHoaDon == maHoaDon).FirstOrDefault();
            if (hd != null)
            {
                try
                {
                    tongTien = (int)hd.TongTien;
                }
                catch (Exception)
                {
                    tongTien = 0;
                }
            }
            return tongTien;
        }
        public string GetMaNhanVien(string username)
        {
            string maNhanVien = "";
            NhanVien nv = qlcf.NhanViens.Where(n => n.TenDangNhap == username).FirstOrDefault();
            if(nv != null)
            {
                maNhanVien = nv.MaNhanVien;
            }
            return maNhanVien;
        }
        public string GetTenNhanVien(string username)
        {
            NhanVien nv = qlcf.NhanViens.Where(tdn => tdn.TenDangNhap == username).FirstOrDefault();
            return nv.TenNhanVien;
        }
        public string GetMaKhachHang(string sdt)
        {
            KhachHang khachHang = qlcf.KhachHangs.Where(kh => kh.SoDienThoai == sdt).FirstOrDefault();
            if (khachHang != null)
            {
                return khachHang.MaKhachHang;
            }
            else
                return string.Empty;
        }
        public string GetTenKhachHang(string sdt)
        {
            KhachHang khachHang = qlcf.KhachHangs.Where(kh => kh.SoDienThoai == sdt).FirstOrDefault();
            if (khachHang != null)
            {
                return khachHang.TenKhachHang;
            }
            else
                return string.Empty;
        }
        public void UpdateHoaDon(string maHoaDon, string maNhanVien, string maKhachHang, int giamGia, DateTime gioRa)
        {
            TimeSpan gr = gioRa.TimeOfDay;
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaHoaDon == maHoaDon).FirstOrDefault();
            if (hd != null)
            {
                if(maKhachHang == string.Empty)
                {
                    hd.MaNhanVien = maNhanVien;
                    hd.GiamGia = giamGia;
                    hd.GioRa = gr;
                    hd.TongTien -= giamGia;
                    hd.TrangThai = "Đã thanh toán";
                }
                else
                {
                    hd.MaNhanVien = maNhanVien;
                    hd.MaKhachHang = maKhachHang;
                    hd.GiamGia = giamGia;
                    hd.GioRa = gr;
                    hd.TongTien -= giamGia;
                    hd.TrangThai = "Đã thanh toán";
                }              
                qlcf.SubmitChanges();
            }
        }
        public TimeSpan GetNgayGioVao(string maHoaDon)
        {
            DateTime gioVao = DateTime.Now;
            TimeSpan gv = gioVao.TimeOfDay;
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaHoaDon == maHoaDon).FirstOrDefault();
            if (hd != null)
            {
                gv = (TimeSpan)hd.GioVao;
            }
            return gv;
        }
        public int GetDonGiaDoUong(string maDoUong)
        {
            int donGia = 0;
            DoUong du = qlcf.DoUongs.Where(d => d.MaDoUong == maDoUong).FirstOrDefault();
            if (du != null)
            {
                donGia = du.Gia;
            }
            return donGia;
        }
        public void InsertChiTietHoaDon(string maHoaDon, string maDoUong)
        {
            ChiTietHoaDon cts = qlcf.ChiTietHoaDons.Where(ct => ct.MaHoaDon == maHoaDon && ct.MaDoUong == maDoUong).FirstOrDefault();
            if (cts == null)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.MaCTHD = PhatSinhMaCTHD(maHoaDon);
                cthd.MaHoaDon = maHoaDon;
                cthd.MaDoUong = maDoUong;
                cthd.SoLuong = 1;
                cthd.ThanhTien = GetDonGiaDoUong(maDoUong);

                qlcf.ChiTietHoaDons.InsertOnSubmit(cthd);
                qlcf.SubmitChanges();
            }
            else
            {
                cts.SoLuong++;
                cts.ThanhTien = cts.SoLuong * GetDonGiaDoUong(maDoUong);
                qlcf.SubmitChanges();
            }
        }
        public void DeleteChiTietHoaDon(string maCTHD)
        {
            ChiTietHoaDon cthd = qlcf.ChiTietHoaDons.Where(ct => ct.MaCTHD == maCTHD).FirstOrDefault();
            if(cthd != null)
            {
                qlcf.ChiTietHoaDons.DeleteOnSubmit(cthd);
                qlcf.SubmitChanges();
            }
        }
        public void CongDiemTichLuyKhachHang(string maKhachHang, int diemCong)
        {
            KhachHang khachHang = qlcf.KhachHangs.Where(kh => kh.MaKhachHang == maKhachHang).FirstOrDefault();
            if(khachHang != null)
            {
                khachHang.DiemTichLuy += diemCong;
                qlcf.SubmitChanges();
            }
        }
        public bool KiemTraSoLuongTonNguyenLieu(string maDoUong)
        {
            List<CongThuc> lstCongThuc = qlcf.CongThucs.Where(ct => ct.MaDoUong == maDoUong).Select(ct => ct).ToList();
            if (lstCongThuc != null)
            {
                foreach (var item in lstCongThuc)
                {
                    NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == item.MaNguyenLieu).FirstOrDefault();
                    if (nl != null)
                    {
                        if (nl.SoLuongTon < item.SoLuong)
                            return true;
                    }
                }
            }
            return false;
        }
        public void UpdateTruSoLuongNguyenLieu(string maDoUong)
        {
            List<CongThuc> lstCongThuc = qlcf.CongThucs.Where(ct => ct.MaDoUong == maDoUong).Select(ct => ct).ToList();
            if(lstCongThuc != null)
            {
                foreach (var item in lstCongThuc)
                {
                    NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == item.MaNguyenLieu).FirstOrDefault();
                    if(nl != null)
                    {
                        nl.SoLuongTon -= item.SoLuong;                      
                    }
                }
                qlcf.SubmitChanges();
            }
        }
        public void UpdateCongSoLuongNguyenLieu(string maDoUong, int soLuongMua)
        {
            List<CongThuc> lstCongThuc = qlcf.CongThucs.Where(ct => ct.MaDoUong == maDoUong).Select(ct => ct).ToList();
            if (lstCongThuc != null)
            {
                foreach (var item in lstCongThuc)
                {
                    NguyenLieu nl = qlcf.NguyenLieus.Where(n => n.MaNguyenLieu == item.MaNguyenLieu).FirstOrDefault();
                    if (nl != null)
                    {
                        nl.SoLuongTon += item.SoLuong * soLuongMua;
                    }
                }
                qlcf.SubmitChanges();
            }
        }
        public void DoiBan(string maHoaDon, string maBan)
        {
            HoaDon hd = qlcf.HoaDons.Where(h => h.MaHoaDon == maHoaDon).FirstOrDefault();
            if (hd != null)
            {
                hd.MaBan = maBan;
                qlcf.SubmitChanges();
            }
        }
    }
}
