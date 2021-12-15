using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BLL
{
    public class BLL_DanhMucDoUong
    {
        QLCFDataContext qlcf = new QLCFDataContext();
        public BLL_DanhMucDoUong()
        {

        }
        public IQueryable<DanhMucDoUong> LoadDanhMucDoUong()
        {
            return qlcf.DanhMucDoUongs.Select(dm => dm);
        }
        public bool KiemTraKhoaChinhDanhMucDoUong(string maDanhMuc)
        {
            DanhMucDoUong dm = qlcf.DanhMucDoUongs.Where(d => d.MaDanhMuc == maDanhMuc).FirstOrDefault();
            if (dm == null)
                return false;
            else
                return true;
        }
        public bool KiemTraTonTaiDoUong(string maDanhMuc)
        {
            DoUong doUong = qlcf.DoUongs.Where(du => du.MaDanhMuc == maDanhMuc).FirstOrDefault();
            if(doUong == null)         
                return false;          
            else        
                return true;              
        }
        public void InsertDanhMucDoUong(string maDanhMuc, string tenDanhMuc)
        {
            DanhMucDoUong dm = new DanhMucDoUong();
            dm.MaDanhMuc = maDanhMuc;
            dm.TenDanhMuc = tenDanhMuc;

            qlcf.DanhMucDoUongs.InsertOnSubmit(dm);
            qlcf.SubmitChanges();
        }
        public void DeleteDanhMucDoUong(string maDanhMuc)
        {
            DanhMucDoUong dm = qlcf.DanhMucDoUongs.Where(d => d.MaDanhMuc == maDanhMuc).FirstOrDefault();
            //List<DoUong> lstdu = qlcf.DoUongs.Where(d => d.MaDanhMuc == maDanhMuc).ToList();
            if (dm != null)
            {
                //if(lstdu != null)
                //{
                //    foreach (var item in lstdu)
                //    {
                //        qlcf.DoUongs.DeleteOnSubmit(item);
                //        qlcf.SubmitChanges();
                //    }
                //}
                    qlcf.DanhMucDoUongs.DeleteOnSubmit(dm);
                    qlcf.SubmitChanges();           
            }
        }
        public void UpdateDanhMucDoUong(string maDanhMuc, string tenDanhMuc)
        {
            DanhMucDoUong dm = qlcf.DanhMucDoUongs.Where(d => d.MaDanhMuc == maDanhMuc).FirstOrDefault();
            if (dm != null)
            {
                dm.TenDanhMuc = tenDanhMuc;
                qlcf.SubmitChanges();
            }
        }
    }
}
