using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        XmlDocument doc = new XmlDocument();
        string tentep = @"C:\Users\ADMIN\OneDrive\Documents\hk5\TichHopHeThong\tx2\TX2\TX2\amnhac.xml";
        int d;

        //xóa các text trong textbox, đặt con trỏ vào điều kiển txtId
        private void ClearTextboxs()
        {
            txttenbai.Clear();
            txtcasi.Clear();
            txttacgia.Clear();
            ActiveControl = txttenbai;
        }

        private void loadCbb()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(tentep);
            cbbmabai.DataSource = dts.Tables["baihat"];
            cbbmabai.DisplayMember = "mabai";

            cbbtheloai.DataSource = dts.Tables["baihat"];
            cbbtheloai.DisplayMember = "theloai";
        }

        private void Hienthi()
        {
            dataBai.Rows.Clear();
            doc.Load(tentep);

            XmlNodeList ds = doc.SelectNodes("/amnhac/baihat");
            int sd = 0;
            dataBai.ColumnCount = 5;
            dataBai.Rows.Add();
            foreach (XmlNode s in ds)
            {
                XmlNode ma_bai = s.SelectSingleNode("@mabai");
                XmlNode the_loai = s.SelectSingleNode("@theloai");
                XmlNode ten_bai = s.SelectSingleNode("tenbai");
                XmlNode ca_si = s.SelectSingleNode("casi");
                XmlNode tac_gia = s.SelectSingleNode("tacgia");
                

                dataBai.Rows[sd].Cells[0].Value = ma_bai.InnerText.ToString();
                dataBai.Rows[sd].Cells[1].Value = the_loai.InnerText.ToString();
                dataBai.Rows[sd].Cells[2].Value = ten_bai.InnerText.ToString();
                dataBai.Rows[sd].Cells[3].Value = ca_si.InnerText.ToString();
                dataBai.Rows[sd].Cells[4].Value = tac_gia.InnerText.ToString();

                dataBai.Rows.Add();
                sd++;
            }
        }
        private void dataBai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadCbb();
            Hienthi();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkTrung = goc.SelectSingleNode("/amnhac/baihat[@mabai = '" + cbbmabai.Text + "']");

            if (chkTrung != null)
            {
                MessageBox.Show("Mã bai '" + cbbmabai.Text + "' bị trùng", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                XmlElement s = doc.CreateElement("baihat");

                XmlAttribute ma_bai = doc.CreateAttribute("mabai");
                XmlAttribute the_loai = doc.CreateAttribute("theloai");
                XmlNode ten_bai = doc.CreateElement("tenbai");
                XmlNode ca_si = doc.CreateElement("casi");
                XmlNode tac_gia = doc.CreateElement("tacgia");
              

                ma_bai.InnerText = cbbmabai.Text;
                the_loai.InnerText = cbbtheloai.Text;
                ten_bai.InnerText = txttenbai.Text;
                ca_si.InnerText = txtcasi.Text;
                tac_gia.InnerText = txttacgia.Text;

                s.Attributes.Append(ma_bai);
                s.Attributes.Append(the_loai);
                s.AppendChild(ten_bai);
                s.AppendChild(ca_si);
                s.AppendChild(tac_gia);
                goc.AppendChild(s);
            }

            doc.Save(tentep);
            ClearTextboxs();
            Hienthi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode scu = goc.SelectSingleNode("/amnhac/baihat[@mabai = '" + cbbmabai.Text + "']");

            if (scu == null)
            {
                MessageBox.Show("Mã sách '" + cbbmabai.Text + "' không tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            XmlElement s = doc.CreateElement("baihat");

            XmlAttribute ma_bai = doc.CreateAttribute("mabai");
            XmlAttribute the_loai = doc.CreateAttribute("theloai");
            XmlNode ten_bai = doc.CreateElement("tenbai");
            XmlNode ca_si = doc.CreateElement("casi");
            XmlNode tac_gia = doc.CreateElement("tacgia");


            ma_bai.InnerText = cbbmabai.Text;
            the_loai.InnerText = cbbtheloai.Text;
            ten_bai.InnerText = txttenbai.Text;
            ca_si.InnerText = txtcasi.Text;
            tac_gia.InnerText = txttacgia.Text;

            s.Attributes.Append(ma_bai);
            s.Attributes.Append(the_loai);
            s.AppendChild(ten_bai);
            s.AppendChild(ca_si);
            s.AppendChild(tac_gia);
            goc.AppendChild(s);

            goc.ReplaceChild(s, scu);

            doc.Save(tentep);
            ClearTextboxs();
            Hienthi();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode s = goc.SelectSingleNode("/amnhac/baihat[@mabai = '" + cbbmabai.Text + "']");

            if (s == null)
            {
                MessageBox.Show("Mã sách '" + cbbmabai.Text + "' không tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                goc.RemoveChild(s);
            }
            doc.Save(tentep);
            ClearTextboxs();
            Hienthi();
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataBai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            d = e.RowIndex;
            cbbmabai.Text = dataBai.Rows[d].Cells[0].Value.ToString();
            cbbtheloai.Text = dataBai.Rows[d].Cells[1].Value.ToString();
            txttenbai.Text = dataBai.Rows[d].Cells[2].Value.ToString();
            txtcasi.Text = dataBai.Rows[d].Cells[3].Value.ToString();
            txttacgia.Text = dataBai.Rows[d].Cells[4].Value.ToString();
        }
    }
}
