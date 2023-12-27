using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; 

namespace Hieu_XSMl
{
    class Class1
    {
        
        static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("CHƯƠNG TRÌNH ĐỌC FILE THUVIEN.XML");
            XmlDocument doc = new XmlDocument();
            doc.Load("students.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList li = root.SelectNodes("student");
            int i = 1; 
            foreach(XmlNode item in li)
            {
                Console.WriteLine("--------------\nPhần tử thứ: ", i );
                Console.WriteLine("Firstname : ", item.SelectSingleNode("firstname").InnerText );
                Console.WriteLine("Lastname :  ", item.SelectSingleNode("lastname").InnerText);
                Console.WriteLine("NickName: ", item.SelectSingleNode("nickname").InnerText);
                Console.WriteLine("Marks: ", item.SelectSingleNode("marks").InnerText);
                i++; 
                
            }
            Console.WriteLine("Số lượng phần tử trong student: ", li.Count);
            Console.ReadKey(); 
        }

        
    }
}
