using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace bai8_PhieuBT
{
    class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            doc = new XmlDocument();
            filename = "congty.xml";
            if (!File.Exists(filename))
            {
                XmlElement congty = doc.CreateElement("congty");
                doc.AppendChild(congty);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public List<NhanVien> GetAllNhanVien()
        {
            XmlNodeList nodes = root.SelectNodes("nhanvien");
            List<NhanVien> li = new List<NhanVien>();
            foreach (XmlNode item in nodes)
            {
                NhanVien nv = new NhanVien();
                nv.manv = item.Attributes["manv"].Value;
                nv.hoten = item.SelectSingleNode("hoten").InnerText;
                nv.tuoi = item.SelectSingleNode("tuoi").InnerText;
                nv.luong = item.SelectSingleNode("luong").InnerText;
                nv.xa = item.SelectSingleNode("diachi/xa").InnerText;
                nv.huyen = item.SelectSingleNode("diachi/huyen").InnerText;
                nv.tinh = item.SelectSingleNode("diachi/tinh").InnerText;
                nv.dienthoai = item.SelectSingleNode("dienthoai").InnerText;
                li.Add(nv);
            }
            return li;
        }
        public void AddNhanVien(NhanVien nv)
        {
            XmlElement nhanvien = doc.CreateElement("nhanvien");
            nhanvien.SetAttribute("manv", nv.manv);
            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = nv.hoten;
            XmlElement tuoi = doc.CreateElement("tuoi");
            tuoi.InnerText = nv.tuoi;
            XmlElement luong = doc.CreateElement("luong");
            luong.InnerText = nv.luong;
            XmlElement diachi = doc.CreateElement("diachi");

            XmlElement xa = doc.CreateElement("xa");
            xa.InnerText = nv.xa;
            XmlElement huyen = doc.CreateElement("huyen");
            huyen.InnerText = nv.huyen;
            XmlElement tinh = doc.CreateElement("tinh");
            tinh.InnerText = nv.tinh;
            XmlElement dienthoai = doc.CreateElement("dienthoai");
            dienthoai.InnerText = nv.dienthoai;

            nhanvien.AppendChild(hoten);
            nhanvien.AppendChild(tuoi);
            nhanvien.AppendChild(luong);
            nhanvien.AppendChild(diachi);
            diachi.AppendChild(xa);
            diachi.AppendChild(huyen);
            diachi.AppendChild(tinh);
            nhanvien.AppendChild(dienthoai);

            root.AppendChild(nhanvien);
            doc.Save(filename);

        }

        //cập nhật phần tử Student
        public bool updateStudent(NhanVien s)
        {

            XmlNode stfind = root.SelectSingleNode("nhanvien[@manv='" + s.manv + "']");
            if (stfind != null)
            {
                //tạo phần tử Student 
                XmlElement st = doc.CreateElement("nhanvien");
                st.SetAttribute("manv", s.manv); //đăth thuộc tính id
                XmlElement hoten = doc.CreateElement("hoten"); //tạo phần tử name
                hoten.InnerText = s.hoten; //đặt giá trị Text cho name
                XmlElement tuoi = doc.CreateElement("tuoi");
                tuoi.InnerText = s.tuoi;
                XmlElement luong = doc.CreateElement("luong");
                luong.InnerText = s.luong;
                XmlElement diachi = doc.CreateElement("diachi");

                XmlElement xa = doc.CreateElement("xa");
                xa.InnerText = s.xa;
                XmlElement huyen = doc.CreateElement("huyen");
                huyen.InnerText = s.huyen;
                XmlElement tinh = doc.CreateElement("tinh");
                tinh.InnerText = s.tinh;
                XmlElement dienthoai = doc.CreateElement("dienthoai");
                dienthoai.InnerText = s.dienthoai;


                //thiết lập mqh giữa các phần tử
                st.AppendChild(hoten);
                st.AppendChild(tuoi);
                st.AppendChild(luong);
                st.AppendChild(diachi);
                diachi.AppendChild(xa);
                diachi.AppendChild(huyen);
                diachi.AppendChild(tinh);
                st.AppendChild(dienthoai);


                root.ReplaceChild(st, stfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
        public bool XoaNhanVien(string manv)
        {
            XmlNode cnfind = root.SelectSingleNode("nhanvien[@manv='" + manv + "']");
            if (cnfind != null)
            {
                root.RemoveChild(cnfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }

        public NhanVien FindByMaNV(string manv)
        {
            XmlNode stfind = root.SelectSingleNode("nhanvien[@manv='" + manv + "']");
            NhanVien nv = null;
            if (stfind != null)
            {
                nv = new NhanVien();
                nv.manv = stfind.Attributes[0].InnerText;
                nv.hoten = stfind.SelectSingleNode("hoten").InnerText;
                nv.tuoi = stfind.SelectSingleNode("tuoi").InnerText;
                nv.xa = stfind.SelectSingleNode("diachi/xa").InnerText;
                nv.huyen = stfind.SelectSingleNode("diachi/huyen").InnerText;
                nv.dienthoai = stfind.SelectSingleNode("dienthoai").InnerText;
                nv.luong = stfind.SelectSingleNode("luong").InnerText;
                nv.tinh = stfind.SelectSingleNode("diachi/tinh").InnerText;
            }
            return nv;
        }
        
        public List<NhanVien> KiemTraLuong()
        {
            XmlNodeList nodes = root.SelectNodes("nhanvien");
            List<NhanVien> li = new List<NhanVien>();
            foreach (XmlNode item in nodes)
            {
                if (int.Parse(item.SelectSingleNode("luong").InnerText) > 1000)
                {
                    NhanVien nv = new NhanVien();
                    nv.hoten = item.SelectSingleNode("hoten").InnerText;
                    nv.tuoi = item.SelectSingleNode("tuoi").InnerText;
                    nv.xa = item.SelectSingleNode("diachi/xa").InnerText;
                    nv.huyen = item.SelectSingleNode("diachi/huyen").InnerText;
                    nv.dienthoai = item.SelectSingleNode("dienthoai").InnerText;
                    nv.luong = item.SelectSingleNode("luong").InnerText;
                    nv.tinh = item.SelectSingleNode("diachi/tinh").InnerText;
                    nv.manv = item.Attributes["manv"].Value;
                    li.Add(nv);
                }
            }
            return li;
        }
        public List<NhanVien> LocTinh(string tinh)
        {
            XmlNodeList nodes = root.SelectNodes("nhanvien");
            List<NhanVien> li = new List<NhanVien>();
            foreach (XmlNode item in nodes)
            {
                if (item.SelectSingleNode("diachi/tinh").InnerText == tinh)
                {
                    NhanVien nv = new NhanVien();
                    nv.hoten = item.SelectSingleNode("hoten").InnerText;
                    nv.tuoi = item.SelectSingleNode("tuoi").InnerText;
                    nv.xa = item.SelectSingleNode("diachi/xa").InnerText;
                    nv.huyen = item.SelectSingleNode("diachi/huyen").InnerText;
                    nv.dienthoai = item.SelectSingleNode("dienthoai").InnerText;
                    nv.luong = item.SelectSingleNode("luong").InnerText;
                    nv.tinh = item.SelectSingleNode("diachi/tinh").InnerText;
                    nv.manv = item.Attributes["manv"].Value;
                    li.Add(nv);
                }
            }
            return li;
        }
        public List<NhanVien> LocTinh2(string tinh)
        {
            XmlNodeList nodes = root.SelectNodes("nhanvien[diachi/tinh='" + tinh + "']");
            List<NhanVien> li = new List<NhanVien>();
            foreach (XmlNode item in nodes)
            {
                NhanVien nv = new NhanVien();
                nv.hoten = item.SelectSingleNode("hoten").InnerText;
                nv.tuoi = item.SelectSingleNode("tuoi").InnerText;
                nv.xa = item.SelectSingleNode("diachi/xa").InnerText;
                nv.huyen = item.SelectSingleNode("diachi/huyen").InnerText;
                nv.dienthoai = item.SelectSingleNode("dienthoai").InnerText;
                nv.luong = item.SelectSingleNode("luong").InnerText;
                nv.tinh = item.SelectSingleNode("diachi/tinh").InnerText;
                nv.manv = item.Attributes["manv"].Value;
                li.Add(nv);
            }
            return li;
        }
    }
}
