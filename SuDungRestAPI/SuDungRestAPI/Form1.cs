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

namespace SuDungRestAPI
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
            LoadComboBox();
        }

        public void LoadDataGridView()
        {
            string link = "https://localhost:44395/api/sanpham";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arrSanPham = data as SanPham[];
            dataGridView1.DataSource = arrSanPham;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string madm = txtMaDM.Text;
            string link = "https://localhost:44395/api/sanpham?madm=" + madm;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arrSanPham = data as SanPham[];
            dataGridView1.DataSource = arrSanPham;
        }

        //Lấy danh mục sản phẩm hiện lên combobox
        public void LoadComboBox()
        {
            string link = "https://localhost:44395/api/danhmuc";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(response.GetResponseStream());
            DanhMuc[] arrDanhMuc = data as DanhMuc[];
            cboDanhMuc.DataSource = arrDanhMuc;
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DisplayMember = "TenDM";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtMaSP.Text, txtTenSP.Text, txtDonGia.Text, cboDanhMuc.SelectedValue);
            string link = "https://localhost:44395/api/sanpham/"+ postString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
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
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
            }


        }
    }
}














