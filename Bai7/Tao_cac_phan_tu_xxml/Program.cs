using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; //khai báo sử dụng thư viện Xml

namespace Tao_cac_phan_tu_xxml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();//tạo nút Document
            //tạo các nút Element
            XmlElement root = doc.CreateElement("thuvien");//tạo phần tử gốc thư viện
           
            Cuonsach s1 = new Cuonsach("j01","Công nghệ thông tin","Lập trình java","500","Nguyễn Đăng Hoàng","09876555","350");
            ThemSach(doc,root,s1);

            Cuonsach s2 = new Cuonsach("j02", "Công nghệ thông tin", "Lập trình python", "450", "Lê Mai Anh", "09876555", "350");
            ThemSach(doc, root, s2);

            doc.AppendChild(root);//đưa nút gốc root vào tài liệu doc
            doc.Save("thuvien.xml"); // ghi vào file




        }
        //viết phương thức ThemSach
        public static void ThemSach(XmlDocument doc,XmlElement root, Cuonsach s)
        {
            XmlElement cuonsach = doc.CreateElement("cuonsach");//tạo phần tử cuốn sách

            //bổ sung 2 thuộc tính là masach và theloai cho nút cuonsach
            cuonsach.SetAttribute("masach", s.masach);
            cuonsach.SetAttribute("theloai", s.theloai);

            XmlElement tensach = doc.CreateElement("tensach");
            XmlText ttensach = doc.CreateTextNode(s.tensach);//tạo phần tử Text
            //tiếp tục tạo nút Element và Text xen kẽ
            XmlElement sotrang = doc.CreateElement("sotrang");
            XmlText tsotrang = doc.CreateTextNode(s.sotrang);
            XmlElement tacgia = doc.CreateElement("tacgia");
            XmlElement hoten = doc.CreateElement("hoten");
            XmlText thoten = doc.CreateTextNode(s.hoten);
            XmlElement dienthoai = doc.CreateElement("dienthoai");
            XmlText tdienthoai = doc.CreateTextNode(s.dienthoai);
            XmlElement giatien = doc.CreateElement("giatien");
            XmlText tgiatien = doc.CreateTextNode(s.giatien);

            //thêm các nút Text là con các nút tensach, sotrang, heten,dienthoai,giatien
            tensach.AppendChild(ttensach);
            sotrang.AppendChild(tsotrang);
            hoten.AppendChild(thoten);
            dienthoai.AppendChild(tdienthoai);
            giatien.AppendChild(tgiatien);

            //tạo các mối quan hệ giữa các phần tử
            root.AppendChild(cuonsach);//đưa cuốn sách vào phần tử gốc
            cuonsach.AppendChild(tensach);//đưa tên sách vào cuốn sách
            cuonsach.AppendChild(sotrang);
            cuonsach.AppendChild(tacgia);
            tacgia.AppendChild(hoten);
            tacgia.AppendChild(dienthoai);
            cuonsach.AppendChild(giatien);

        }
    }
}
