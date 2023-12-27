using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Phieu1
{
    internal class Program
    {
        static void Main(string[] args) //viết main
        {
            //hiển thị tiếng việt
            Console.OutputEncoding = Encoding.UTF8;

            //Hiển thị tiêu đề
            Console.WriteLine("Chuong trình đọc file SanPham.xml");

            //tạo phần tử XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.Load("SanPham.xml"); //nạp tài liệu xml vaod biến doc
            //Lưu ý phải đặt file thư viện đúng vị trí: prj - bin - debug

            XmlElement root = doc.DocumentElement;//lấy ra phần tử gốc
            XmlNodeList li = root.SelectNodes("sanpham");//lấy ra 1 ds các nút cuonsach
            int i = 1;
            foreach (XmlNode item in li)
            { //sử dụng for để lặp qua các phần tử
                Console.WriteLine("--------\nPhần tử thứ: " + i);//Hiển thị thứ tự cuốn sách
                Console.WriteLine("Mã sản phẩm: " + item.SelectSingleNode("masp").InnerText);//Hiển thị tên sách
                Console.WriteLine("Tên sản phẩm: " + item.SelectSingleNode("tensp").InnerText);
                Console.WriteLine("Số lượng: " + item.SelectSingleNode("soLuong").InnerText);
                i++; //tăng biến đếm i
            }
            Console.WriteLine("Số lượng phần tử sản phẩm la: " + li.Count);
            Console.ReadLine();

        }
    }
}

