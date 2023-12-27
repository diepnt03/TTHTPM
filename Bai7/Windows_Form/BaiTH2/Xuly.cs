using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BaiTH2
{
    internal class Xuly
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public Xuly()
        {
            doc = new XmlDocument();
            filename = "lophoc.xml";
            if (!File.Exists(filename))
            {
                XmlElement lophoc = doc.CreateElement("lophoc");
                doc.AppendChild(lophoc);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void Hienthi(DataGridView grd)
        {
            grd.Rows.Clear();
            grd.ColumnCount = 4;
            XmlNodeList li = root.SelectNodes("sinhvien");
            int index = 0;
            foreach (XmlNode item in li)
            {
                grd.Rows.Add();
                grd.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                // grd.Rows[index].Cells[0].Value = item.Attributes[1].InnerText;
                grd.Rows[index].Cells[1].Value = item.SelectSingleNode("hoten").InnerText;
                grd.Rows[index].Cells[2].Value = item.SelectSingleNode("tuoi").InnerText;
                grd.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi").InnerText;
                //grd.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi/xa").InnerText; 
                //grd.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi/huyen").InnerText; 
                //grd.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi/tinh").InnerText;
                index++;
            }
        }
        public bool ThemSinhvien(Sinhvien s)
        {
            XmlNode svcantim = root.SelectSingleNode("sinhvien[@masv='" + s.masv + "']");
            if (svcantim != null)
            {
                MessageBox.Show("Trung ma");
                return false;
            }
            else
            {
                XmlElement sv = doc.CreateElement("sinhvien");
                sv.SetAttribute("masv", s.masv);
                XmlElement hoten = doc.CreateElement("hoten");
                // hoten.InnerText = s.hoten;
                XmlText tht = doc.CreateTextNode(s.hoten);
                hoten.AppendChild(tht);
                XmlElement tuoi = doc.CreateElement("tuoi");
                tuoi.InnerText = s.tuoi;
                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = s.diachi;
                sv.AppendChild(hoten);
                sv.AppendChild(tuoi);
                sv.AppendChild(diachi);
                root.AppendChild(sv);
                doc.Save(filename);
                return true;
            }

        }
        public void SuaSinhvien(Sinhvien s)
        {
            XmlNode svcantim = root.SelectSingleNode("sinhvien[@masv='" + s.masv + "']");
            if (svcantim != null) //Có sinh viên trong danh sách
            {
                XmlElement sv = doc.CreateElement("sinhvien");
                sv.SetAttribute("masv", s.masv);
                XmlElement hoten = doc.CreateElement("hoten");
                hoten.InnerText = s.hoten;
                XmlElement tuoi = doc.CreateElement("tuoi");
                tuoi.InnerText = s.tuoi;
                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = s.diachi; sv.AppendChild(hoten);
                sv.AppendChild(tuoi);
                sv.AppendChild(diachi);
                root.ReplaceChild(sv, svcantim);
                doc.Save(filename);
            }
        }
        public void XoaSinhvien(Sinhvien s)
        {
            XmlNode svcantim = root.SelectSingleNode("sinhvien[@masv='" + s.masv + "']");
            if (svcantim != null)
            {
                DialogResult d = MessageBox.Show("Ban co chac chan xoa khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (d == DialogResult.Yes)
                {
                    root.RemoveChild(svcantim);
                    doc.Save(filename);
                }
            }
            else
            {
                MessageBox.Show("Khong co sinh vien co ma " + s.masv + " de xoa");
            }
        }
        public void TimSinhvien(Sinhvien s, DataGridView gr)
        {
            XmlNode svcantim = root.SelectSingleNode("sinhvien[@masv='" + s.masv + "']");
            if (svcantim != null)
            {
                gr.Rows.Clear();
                gr.ColumnCount = 4;
                gr.Rows[0].Cells[0].Value = svcantim.Attributes[0].InnerText;
                gr.Rows[0].Cells[1].Value = svcantim.SelectSingleNode("hoten").InnerText;
                gr.Rows[0].Cells[2].Value = svcantim.SelectSingleNode("tuoi").InnerText;
                gr.Rows[0].Cells[3].Value = svcantim.SelectSingleNode("diachi").InnerText;
            }
            else
            {
                MessageBox.Show("Khong co sinh vien co ma " + s.masv);
            }
        }
    }
}

