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

namespace bai8_PhieuBT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        public void DisplayData()
        {
            dataGridView1.DataSource = data.GetAllNhanVien();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 100;

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
        public void clearBoxText()
        {
            txtHoTen.Text = "";
            txtHuyen.Text = "";
            txtLuong.Text = "";
            txtSoDienThoai.Text = "";
            txtTuoi.Text = "";
            txtXa.Text = "";
            txtTinh.Text = "";
            txtMaNV.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.hoten = txtHoTen.Text;
            nv.tuoi = txtTuoi.Text;
            nv.luong = txtLuong.Text;
            nv.xa = txtXa.Text;
            nv.manv = txtMaNV.Text;
            nv.huyen = txtHuyen.Text;
            nv.tinh = txtTinh.Text;
            nv.dienthoai = txtSoDienThoai.Text;

            data.AddNhanVien(nv);
            DisplayData();
            clearBoxText();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            DialogResult d = MessageBox.Show(
                "Bạn chắc chắn muốn xoá không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error
           );
            if (d == DialogResult.Yes)
            {
                bool kt = data.XoaNhanVien(manv);
                if (!kt)
                {
                    MessageBox.Show(manv + " không tồn tại!!", "Thông Báo");
                    return;
                }
                DisplayData();
                clearBoxText();
            }

        }

        private void btnLocLuong_Click(object sender, EventArgs e)
        {

            List<NhanVien> li = data.KiemTraLuong();
            int tong = 0;
            foreach (NhanVien nv in li)
            {
                tong += int.Parse(nv.luong);
            }
            lblTongLuong.Text = tong.ToString();
            dataGridView1.DataSource = li;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            List<NhanVien> li = new List<NhanVien>();
            NhanVien s = data.FindByMaNV(manv);
            if (s != null)
            {
                li.Add(s);
                dataGridView1.DataSource = li;
                txtHoTen.Text = s.hoten;
                txtHuyen.Text = s.huyen;
                txtLuong.Text = s.luong;
                txtSoDienThoai.Text = s.dienthoai;
                txtTuoi.Text = s.tuoi;
                txtXa.Text = s.xa;
                txtTinh.Text = s.tinh;
                txtMaNV.Text = s.manv;
                return;
            }
            MessageBox.Show("Không có nhân viên có manv này.", "Thông báo");
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBoxText();
        }
    }
}
