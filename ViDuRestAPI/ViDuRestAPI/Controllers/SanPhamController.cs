using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViDuRestAPI.Models;

namespace ViDuRestAPI.Controllers
{
    public class SanPhamController : ApiController
    {

        CSDLTestEntities db = new CSDLTestEntities();

        //lấy toàn bộ sản phẩm
        [HttpGet]
        public IEnumerable<SanPham> LayToanBoSP()
        {
            IEnumerable<SanPham> query = db.SanPhams;
            return query;
        }
        //tìm sản phẩm theo mã
        [HttpGet]
        public SanPham LaySPTheoMa(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            return sp;
        }

        [HttpGet]
        public IEnumerable<SanPham> LaySPTheoDM(int madm)
        {
            IEnumerable<SanPham> query = db.SanPhams.Where(x => x.MaDanhMuc == madm);
            return query;
        }

        [HttpPost]
        public bool ThemMoi(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp == null)
            {
                SanPham spnew = new SanPham();
                spnew.MaSP = ma;
                spnew.TenSP = ten;
                spnew.DonGia = gia;
                spnew.MaDanhMuc = madm;
                db.SanPhams.Add(spnew);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpPut]
        public bool CapNhat(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.MaSP == ma);
            if (sp != null)
            {
                sp.MaSP = ma;
                sp.TenSP = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        [HttpDelete]
        public bool XoaSP(int ma)
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


    }
}














