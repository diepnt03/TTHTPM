using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH1
{
    internal class Sinhvien
    {
        public string masv { get; set; }
        public string hoten { get; set; }
        public string tuoi { get; set; }
        public string diachi { get; set; }

        public Sinhvien()
        {
        }

        public Sinhvien(string masv, string hoten, string tuoi, string diachi)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.diachi = diachi;
        }
    }
}
