using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Nhap_phan_tu
{
    internal class DataUtil
    {
        //tạo 3 biến thành viên
        XmlDocument doc;
        XmlElement root;
        string filename;

        public DataUtil() {
            filename = "Course.xml";
            doc = new XmlDocument();
            //Kiểm tra xem đã có file tài liệu hay chưa
            if(!File.Exists(filename))
            {
                //nếu chưa có thì tạo phần tử gốc course
                XmlElement course = doc.CreateElement("course");
                doc.AppendChild(course);
                doc.Save(filename); //lưu vào file
            }
            doc.Load(filename);//nạp tài liệu Xml vào biến doc
            root = doc.DocumentElement; //lấy ra phần tử gốc từ thuộc tính của biến doc
        }
        //viết phương thức thêm phần tử student vào file xml
        public void AddStudent(SinhVien s)
        {
            //tạo phần tử Student 
            XmlElement st = doc.CreateElement("student");
            st.SetAttribute("id", s.id); //đăth thuộc tính id
            XmlElement name = doc.CreateElement("name"); //tạo phần tử name
            name.InnerText = s.name; //đặt giá trị Text cho name
            XmlElement age = doc.CreateElement("age");
            age.InnerText = s.age;
            XmlElement city = doc.CreateElement("city");
            city.InnerText = s.city;

            //thiết lập mqh giữa các phần tử
            st.AppendChild(name); //thêm các con cho phần tử Student 
            st.AppendChild(age);
            st.AppendChild(city);
            root.AppendChild(st); //đưa phần tử sinh viên vào nút gốc
            doc.Save(filename);//ghi thành file
        }

        //viết phương thức lấy ra dữ liệu từ file xml
        public List<SinhVien> GetAllStudents()
        {
            //lấy ra danh sách các node student
            XmlNodeList nodes = root.SelectNodes("student");
            List<SinhVien> li = new List<SinhVien>();
            foreach (XmlNode item in nodes)//chuyển ds các nút sang ds các đối tượng
            {
                SinhVien s = new SinhVien();
                s.id = item.Attributes[0].InnerText;
                s.name = item.SelectSingleNode("name").InnerText;
                s.age = item.SelectSingleNode("age").InnerText;
                s.city = item.SelectSingleNode("city").InnerText;
                li.Add(s);
            }
            return li;
        }


        //cập nhật phần tử Student
        public bool updateStudent(SinhVien s)
        {

            XmlNode stfind = root.SelectSingleNode("student[@id='" + s.id + "']");
            if (stfind != null)
            {
                //tạo phần tử Student 
                XmlElement st = doc.CreateElement("student");
                st.SetAttribute("id", s.id); //đăth thuộc tính id
                XmlElement name = doc.CreateElement("name"); //tạo phần tử name
                name.InnerText = s.name; //đặt giá trị Text cho name
                XmlElement age = doc.CreateElement("age");
                age.InnerText = s.age;
                XmlElement city = doc.CreateElement("city");
                city.InnerText = s.city;

                //thiết lập mqh giữa các phần tử
                st.AppendChild(name); //thêm các con cho phần tử Student 
                st.AppendChild(age);
                st.AppendChild(city);
                

                root.ReplaceChild(st, stfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }

        public bool DeleteStudent(string id)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + id + "']");
            if(stfind != null)
            {
                root.RemoveChild(stfind);
                doc.Save(filename) ;
                return true;
            }
            return false;

        }
        public SinhVien FindByID(string id)
        {
            XmlNode stfind = root.SelectSingleNode("student[@id='" + id + "']");
            SinhVien s = null;
            if (stfind != null)
            {
                s = new SinhVien();
                s.id = stfind.Attributes[0].InnerText;
                s.name = stfind.SelectSingleNode("name").InnerText;
                s.age = stfind.SelectSingleNode("age").InnerText;
                s.city = stfind.SelectSingleNode("city").InnerText;
            }
            return s;
        }

    }
}
