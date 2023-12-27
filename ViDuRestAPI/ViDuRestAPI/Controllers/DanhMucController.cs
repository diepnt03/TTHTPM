using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http;
using ViDuRestAPI.Models;

namespace ViDuRestAPI.Controllers
{
    public class DanhMucController : ApiController
    {
        //lấy toàn bộ danh muc
        CSDLTestEntities db = new CSDLTestEntities();
        [HttpGet]
        public IEnumerable<DanhMuc> LayToanBoDM()
        {
            IEnumerable<DanhMuc> query = db.DanhMucs;
            return query;
        }
    }
}
