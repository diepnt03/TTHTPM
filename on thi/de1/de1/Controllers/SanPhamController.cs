using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using de1.Models;

namespace de1.Controllers
{
    public class SanPhamController : ApiController
    {
        QuanLySanPhamEntities db = new QuanLySanPhamEntities();

        //lấy toàn bộ sản phẩm
        [HttpGet]
        public IEnumerable<SanPham> DanhSachSP()
        {
            IEnumerable<SanPham> qr = db.SanPhams;
            return qr;
        }
       

        [HttpPost]
        public bool ThemSP(int ma, string ten, float gia, float sl, float tien)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp == null)
            {
                SanPham spnew = new SanPham();
                spnew.MaSP = ma;
                spnew.TenSanPham = ten;
                spnew.DonGia = gia;
                spnew.SoLuongBan = sl;
                spnew.TienBan = tien;
                db.SanPhams.Add(spnew);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool XoaNhanvien(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut]
        public bool SuaNhanvien(int ma, string ten, float gia, float sl, float tien)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {
                sp.MaSP = ma;
                sp.TenSanPham = ten;
                sp.DonGia = gia;
                sp.SoLuongBan = sl;
                sp.TienBan = tien;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        //tìm sản phẩm co so luong > 5
        [HttpGet]

        public IEnumerable<SanPham> DSSoLuong(int sl)
        {
            IEnumerable<SanPham> query = db.SanPhams.Where(x => x.SoLuongBan > sl);
            return query;
        }


    }
}