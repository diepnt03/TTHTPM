using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BaiTH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("lophoc");
            doc.AppendChild(root);
            Sinhvien s1 = new Sinhvien("sv01", "Nguyen Thi Anh", "20", "Ha noi");
            Sinhvien s2 = new Sinhvien("sv02", "Nguyen Thi Binh", "20", "Hai phong");
            Sinhvien s3 = new Sinhvien("sv03", "Tran Van Tuan", "20", "Ha nam");
            themSinhvien(doc, root, s1);
            themSinhvien(doc, root, s2);
            themSinhvien(doc, root, s3);
            Console.WriteLine("Da xong!");
            Console.ReadKey();
        }
        static void themSinhvien(XmlDocument doc, XmlElement root, Sinhvien s)
        {
            XmlElement sv = doc.CreateElement("sinhvien");
            sv.SetAttribute("masv", s.masv); 
            XmlElement hoten = doc.CreateElement("hoten"); 
            hoten.InnerText = s.hoten; 
            XmlElement tuoi = doc.CreateElement("tuoi"); 
            tuoi.InnerText = s.tuoi; 
            XmlElement diachi = doc.CreateElement("diachi"); 
            diachi.InnerText = s.diachi;
            root.AppendChild(sv);
            sv.AppendChild(hoten); 
            sv.AppendChild(tuoi);
            sv.AppendChild(diachi);
            doc.Save("lophoc2.xml");
        }
    }
}
