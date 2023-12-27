using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO; 

namespace bai7_Phieubt
{
    class DataUtil
    {
        //tạo 3 biến thành viên
        XmlDocument doc;
        XmlElement root;
        string filename; 
        public DataUtil()
        {
            doc = new XmlDocument();
            filename = "nganhang.xml";
            //Kiểm tra xem đã có file tài liệu hay chưa
            if (!File.Exists(filename))
            {
                //nếu chưa có thì tạo phần tử gốc nganhang
                XmlElement nganhang = doc.CreateElement("nganhang");
                doc.AppendChild(nganhang);
                doc.Save(filename); //lưu vào file

            }
            doc.Load(filename);//nạp tài liệu Xml vào biến doc
            root = doc.DocumentElement; //lấy ra phần tử gốc từ thuộc tính của biến doc

        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            XmlNodeList nodes = root.SelectNodes("taikhoan");
            List<TaiKhoan> li = new List<TaiKhoan>(); 
            foreach(XmlNode item in nodes)
            {
                TaiKhoan s = new TaiKhoan();
                s.stk = item.SelectSingleNode("sotaikhoan").InnerText;
                s.ttk = item.SelectSingleNode("tentaikhoan").InnerText;
                s.dc = item.SelectSingleNode("diachi").InnerText;
                s.st = item.SelectSingleNode("sotien").InnerText;
                li.Add(s); 
            }
            return li; 
        }
        //viết phương thức thêm phần tử TaiKhoan vào file xml
        public void AddTaiKhoan(TaiKhoan tk)
        {
            //tạo phần tử taikhoan
            XmlElement taikhoan = doc.CreateElement("taikhoan");
            XmlElement stk = doc.CreateElement("sotaikhoan");
            stk.InnerText = tk.stk;
            XmlElement ttk = doc.CreateElement("tentaikhoan");
            ttk.InnerText = tk.ttk;
            XmlElement dc = doc.CreateElement("diachi"); 
            dc.InnerText = tk.dc;
            XmlElement st = doc.CreateElement("sotien");
            st.InnerText = tk.st;

            //thiết lập mqh giữa các phần tử
            taikhoan.AppendChild(stk);
            taikhoan.AppendChild(ttk);
            taikhoan.AppendChild(dc);
            taikhoan.AppendChild(st);

            root.AppendChild(taikhoan);
            doc.Save(filename); 

        }
        public bool KiemTraSoTaiKhoan(string stk)
        {
            XmlNode sdfind = root.SelectSingleNode("taikhoan[sotaikhoan='" + stk + "']"); 
            if(sdfind != null)
            {
                return false; 
            }
            return true; 
        }
        public bool updateTaiKhoan(TaiKhoan tk)
        {

            XmlNode sdfind = root.SelectSingleNode("taikhoan[sotaikhoan='" + tk.stk + "']"); 
            if(sdfind != null)
            {
                XmlElement taikhoan = doc.CreateElement("taikhoan");
                XmlElement stk = doc.CreateElement("sotaikhoan");
                stk.InnerText = tk.stk;
                XmlElement ttk = doc.CreateElement("tentaikhoan");
                ttk.InnerText = tk.ttk;
                XmlElement dc = doc.CreateElement("diachi");
                dc.InnerText = tk.dc;
                XmlElement st = doc.CreateElement("sotien");
                st.InnerText = tk.st;

                taikhoan.AppendChild(stk);
                taikhoan.AppendChild(ttk);
                taikhoan.AppendChild(dc);
                taikhoan.AppendChild(st);

                root.ReplaceChild(taikhoan, sdfind);
                doc.Save(filename); 
                return true; 
            }
            return false; 
        }
        public bool DeleteTaiKhoan(string stk)
        {
            XmlNode tkfind = root.SelectSingleNode("taikhoan[sotaikhoan='" + stk + "']");
            if (tkfind != null)
            {
                root.RemoveChild(tkfind);
                doc.Save(filename);
                return true;
            }
            return false;

        }
        public TaiKhoan FindBySTK(string stk)
        {
            XmlNode tkfind = root.SelectSingleNode("taikhoan[sotaikhoan='" + stk + "']");
            TaiKhoan s = null;
            if (tkfind != null)
            {
                s = new TaiKhoan();
                s.stk = tkfind.SelectSingleNode("sotaikhoan").InnerText;
                s.ttk = tkfind.SelectSingleNode("tentaikhoan").InnerText;
                s.dc = tkfind.SelectSingleNode("diachi").InnerText;
                s.st = tkfind.SelectSingleNode("sotien").InnerText;
            }
            return s;
        }
    }
}
