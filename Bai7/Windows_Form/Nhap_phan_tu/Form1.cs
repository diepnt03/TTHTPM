using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhap_phan_tu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //tạo đối tượng DataUtil
        DataUtil data = new DataUtil();
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

       //viết phương thức hiển thị DisplayData
        private void DisplayData()
        {
            dataGridView1.DataSource = data.GetAllStudents();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 200;
            lblCount.Text = dataGridView1.Rows.Count + ""; //số lượng sv
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //tạo đối tượng SinhVien mới
            SinhVien s = new SinhVien();    
            //lấy giá trị có trong các textbox đưa vào đối tượng
            s.id = txtId.Text;
            s.name = txtName.Text;
            s.age = txtAge.Text;
            s.city = txtCity.Text;
            data.AddStudent(s);
            ClearTextboxs();
            DisplayData();
        }
        //xóa các text trong textbox, đặt con trỏ vào điều kiển txtId
        private void ClearTextboxs()
        {
            txtId.Clear();
            txtName.Clear();    
            txtAge.Clear();
            txtCity.Clear();
            ActiveControl = txtId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhVien s = (SinhVien)dataGridView1.CurrentRow.DataBoundItem;
            txtId.Text = s.id;
            txtName.Text = s.name;
            txtAge.Text = s.age;
            txtCity.Text = s.city;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //tạo đối tượng SinhVien mới
            SinhVien s = new SinhVien();
            //lấy giá trị có trong các textbox đưa vào đối tượng
            s.id = txtId.Text;
            s.name = txtName.Text;
            s.age = txtAge.Text;
            s.city = txtCity.Text;
            bool kt = data.updateStudent(s);
            if (!kt)
            {
                MessageBox.Show("Không cập nhật được sinh viên có id = " + s.id);
                return;
            }
            DisplayData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextboxs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
                "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool kt = data.DeleteStudent(txtId.Text);
                if (!kt)
                {
                    MessageBox.Show("Có lỗi khi xóa.","Thông báo");
                    return;
                }
                DisplayData();
                ClearTextboxs();

            }

        }

        private void btnFindbyID_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            List<SinhVien> li = new List<SinhVien>();
            SinhVien s = data.FindByID(id);
            if (s != null)
            {
                li.Add(s);
                dataGridView1.DataSource = li;
                lblCount.Text = dataGridView1.Rows.Count + "";
                txtId.Text = s.id;
                txtName.Text = s.name;
                txtAge.Text = s.age;
                txtCity.Text = s.city;
                return;
            }
            MessageBox.Show("Không có sinh viên có id này.", "Thông báo");
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
