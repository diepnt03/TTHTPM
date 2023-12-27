using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdde1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string link = "https://localhost:44314/api/sanpham?sl=5";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] arrSanPham = data as SanPham[];
            dssp.DataSource = arrSanPham;
        }
    }
}
