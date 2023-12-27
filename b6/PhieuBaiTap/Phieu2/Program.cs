using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Phieu2
{
    internal class Program
    {
        static void Main(string[] args) //viết main
        {
            //hiển thị tiếng việt
            Console.OutputEncoding = Encoding.UTF8;

            //Hiển thị tiêu đề
            Console.WriteLine("Chuong trình đọc file Congty.xml");

            //tạo phần tử XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.Load("Congty.xml"); //nạp tài liệu xml vaod biến doc
            //Lưu ý phải đặt file thư viện đúng vị trí: prj - bin - debug

            XmlElement root = doc.DocumentElement;//lấy ra phần tử gốc
            XmlNodeList li = root.SelectNodes("nhanvien");//lấy ra 1 ds các nút cuonsach
            int i = 1;
            foreach (XmlNode item in li)
            { //sử dụng for để lặp qua các phần tử
                Console.WriteLine("--------\nPhần tử thứ: " + i);//Hiển thị thứ tự cuốn sách
                Console.WriteLine("Mã nhân viên: " + item.SelectSingleNode("@manv").InnerText);//Hiển thị tên sách
                Console.WriteLine("Họ tên: " + item.SelectSingleNode("hoten").InnerText);//Hiển thị tên sách
                Console.WriteLine("Tuổi: " + item.SelectSingleNode("tuoi").InnerText);
                Console.WriteLine("Lương: " + item.SelectSingleNode("luong").InnerText);
                Console.WriteLine("Địa chỉ: ");
                Console.WriteLine("Xã: " + item.SelectSingleNode("diachi/xa").InnerText);
                Console.WriteLine("Huyện: " + item.SelectSingleNode("diachi/huyen").InnerText);
                Console.WriteLine("Tỉnh: " + item.SelectSingleNode("diachi/tinh").InnerText);
                Console.WriteLine("Điện thoại: " + item.SelectSingleNode("dienthoai").InnerText);

                i++; //tăng biến đếm i
            }
            Console.WriteLine("Số lượng phần tử nhân viên la: " + li.Count);
            Console.ReadLine();

        }
    }
}

