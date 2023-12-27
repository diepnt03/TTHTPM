using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tao_cac_phan_tu_xxml
{
    internal class Cuonsach
    {
        //tạo các thuộc tính
        public string masach { get; set; }
        public string theloai { get; set; }
        public string tensach { get; set; }
        public string sotrang { get; set; }
        public string hoten { get; set; }
        public string dienthoai { get; set; }
        public string giatien { get; set; }

        public Cuonsach()
        {
        }

        public Cuonsach(string masach, string theloai, string tensach, string sotrang, string hoten, string dienthoai, string giatien)
        {
            this.masach = masach;
            this.theloai = theloai;
            this.tensach = tensach;
            this.sotrang = sotrang;
            this.hoten = hoten;
            this.dienthoai = dienthoai;
            this.giatien = giatien;
        }
    }
}
