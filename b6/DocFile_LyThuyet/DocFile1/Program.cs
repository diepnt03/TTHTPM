using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DocFile1
{
    internal class Program
    {
        static void Main(string[] args) //viết main
        {
            //hiển thị tiếng việt
            Console.OutputEncoding = Encoding.UTF8;

            //Hiển thị tiêu đề
            Console.WriteLine("Chuong trình đọc file thuvien.xml");

            //tạo phần tử XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.Load("thuvien.xml"); //nạp tài liệu xml vaod biến doc
            //Lưu ý phải đặt file thư viện đúng vị trí: prj - bin - debug

            XmlElement root = doc.DocumentElement;//lấy ra phần tử gốc
            XmlNodeList li = root.SelectNodes("cuonsach");//lấy ra 1 ds các nút cuonsach
            int i = 1;
            foreach (XmlNode item in li)
            { //sử dụng for để lặp qua các phần tử
                Console.WriteLine("--------\nPhần tử thứ: " + i);//Hiển thị thứ tự cuốn sách
                Console.WriteLine("Tên sách: " + item.SelectSingleNode("tensach").InnerText);//Hiển thị tên sách
                Console.WriteLine("Số trang: " + item.SelectSingleNode("sotrang").InnerText);
                Console.WriteLine("Họ tên tác giả: " + item.SelectSingleNode("tacgia/hoten").InnerText);
                Console.WriteLine("Điện thoại tác giả: " + item.SelectSingleNode("tacgia/dienthoai").InnerText);
                Console.WriteLine("Giá tiền: " + item.SelectSingleNode("giatien").InnerText);
                i++; //tăng biến đếm i
            }
            Console.WriteLine("Số lượng phần tử cuonsach la: " + li.Count);
            Console.ReadLine();

        }
    }
}

