using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bai7_Phieubt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //tạo đối tượng DataUtil
        DataUtil data = new DataUtil();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void DisplayData()
        {
            dataGridView1.DataSource = data.GetAllTaiKhoan();
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 100;
            //lblCount.Text = dataGridView1.Rows.Count + ""; 

        }
        public void clearTextBox()
        {
            txtStk.Text = "";
            txtTtk.Text = "";
            txtDc.Text = "";
            txtSt.Text = "";
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            //lấy giá trị có trong các textbox đưa vào đối tượng
            tk.stk = txtStk.Text;
            tk.ttk = txtTtk.Text;
            tk.dc = txtDc.Text;
            tk.st = txtSt.Text;
            if (!data.KiemTraSoTaiKhoan(tk.stk))
            {
                MessageBox.Show("Số tài khoản " + tk.stk + " đã tồn tại! Vui lòng thêm số khác.", "Thông Báo");
                clearTextBox();
                return;
            }
            data.AddTaiKhoan(tk);
            DisplayData();
            clearTextBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TaiKhoan tk = (TaiKhoan)dataGridView1.CurrentRow.DataBoundItem;
            txtStk.Text = tk.stk;
            txtTtk.Text = tk.ttk;
            txtDc.Text = tk.dc;
            txtSt.Text = tk.st;

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.stk = txtStk.Text;
            tk.ttk = txtTtk.Text;
            tk.dc = txtDc.Text;
            tk.st = txtSt.Text;
            bool kt = data.updateTaiKhoan(tk);
            if (!kt)
            {
                MessageBox.Show("Không tìm thấy tài khoản có stk: " + tk.stk, "Thông Báo");
                return;
            }
            clearTextBox();
            DisplayData();
            return;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa không?",
               "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (d == DialogResult.Yes)
            {
                bool kt = data.DeleteTaiKhoan(txtStk.Text);
                if (!kt)
                {
                    MessageBox.Show("Có lỗi khi xóa.", "Thông báo");
                    return;
                }
                DisplayData();
                clearTextBox();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string stk = txtStk.Text;
            List<TaiKhoan> li = new List<TaiKhoan>();
            TaiKhoan s = data.FindBySTK(stk);
            if (s != null)
            {
                li.Add(s);
                dataGridView1.DataSource = li;
                txtStk.Text = s.stk;
                txtTtk.Text = s.ttk;
                txtDc.Text = s.dc;
                txtSt.Text = s.st;
                return;
            }
            MessageBox.Show("Không có tài khoản có stk này.", "Thông báo");
            return;
        }
    }
}
