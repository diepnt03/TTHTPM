using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace sdde1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            string link = "https://localhost:44314/api/sanpham";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arrSanPham = data as SanPham[];
            dssp.DataSource = arrSanPham;
        }
        private void dssp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dssp.Rows[e.RowIndex];
            txtMaSP.Text = Convert.ToString(row.Cells[0].FormattedValue);
            txtTenSP.Text = Convert.ToString(row.Cells[1].FormattedValue);
            txtDonGia.Text = Convert.ToString(row.Cells[2].FormattedValue);
            txtSLBan.Text = Convert.ToString(row.Cells[3].FormattedValue);
            txtTienBan.Text = Convert.ToString(row.Cells[4].FormattedValue);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&sl={3}&tien={4}",
                txtMaSP.Text, txtTenSP.Text, txtDonGia.Text,txtSLBan.Text,txtTienBan.Text);
            string link = "https://localhost:44314/api/sanpham" + postString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST"; //PUT -- DELETE
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();  MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&sl={3}&tien={4}", txtMaSP.Text, txtTenSP.Text, txtDonGia.Text, txtSLBan.Text, txtTienBan.Text);
            string link = "https://localhost:44314/api/sanpham" + postString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&sl={3}&tien={4}", txtMaSP.Text, txtTenSP.Text, txtDonGia.Text, txtSLBan.Text, txtTienBan.Text);
            string link = "https://localhost:44314/api/sanpham" + postString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr, 0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

       

        private void btnTK_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        
    }
}
