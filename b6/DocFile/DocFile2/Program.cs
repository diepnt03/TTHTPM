using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DocFile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hiển thị tiếng việt
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chuong trình đọc file thuvien.xml cách 2");

            //tạo phần tử XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.Load("thuvien.xml"); //nạp tài liệu xml vaod biến doc

            XmlElement root = doc.DocumentElement;//lấy ra phần tử gốc từ biến doc
            PrintNode(root);


            Console.ReadLine();

        }
        static void PrintNode(XmlNode node)
        {
            //in ra thong tin của 1 node : kiểu, tên , giá trị
            Console.Write("Type = [" + node.NodeType + "]");
            Console.Write(", Name = [" + node.Name + "]");
            Console.Write(", Value = [" + node.Value + "]");

            //lấy ra danh sách các con của node hiện tại
            XmlNodeList children = node.ChildNodes;
            if (children.Count > 0)
            {
                Console.WriteLine("----Các con của node : " + node.Name + " là: ");
                foreach (XmlNode item in children)
                {
                    PrintNode(item);
                }
                Console.WriteLine("Kết thúc node" + node.Name);
            }
        }
    }
}
