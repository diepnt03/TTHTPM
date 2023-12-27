using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Xuly pr = new Xuly();

        private void button1_Click(object sender, EventArgs e)
        {
            pr.Hienthi(gridviewSinhvien);
        }
        private void Xoatextbox()
        {
            txtmasv.Clear();
            txtHoten.Clear();
            txtTuoi.Clear();
            txtDiachi.Clear();
            ActiveControl = txtmasv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string errs = "";
            string strmasv = "^[s][0-9]{2}$";
            string strpattern = "^[a-zA-Z ]+$";
            string tuoipattern = "^[0-9]{2}$";
            if (!Regex.IsMatch(txtmasv.Text, strmasv))
            {
                errs += "\nBan phai nhap ma sv bat dau la s theo sau la 2 so";
            }
            if (!Regex.IsMatch(txtHoten.Text, strpattern))
            {
                errs += "\nBan phai nhap ho ten";
            }
            if (!Regex.IsMatch(txtTuoi.Text, tuoipattern))
            {
                errs += "\nBan phai nhap tuoi co 2 so";
            }
            else
            {
                int t = Convert.ToInt16(txtTuoi.Text);
                if (t < 18) errs += "\nBan phai nhap tuoi >= 18";
            }
            if (errs != "")
            {
                MessageBox.Show("Co loi xay ra:" + errs);
            }
            else
            {
                Sinhvien sv = new Sinhvien();
                sv.masv = txtmasv.Text;
                sv.hoten = txtHoten.Text;
                sv.tuoi = txtTuoi.Text;
                sv.diachi = txtDiachi.Text;
                bool k = pr.ThemSinhvien(sv);
                if (k)
                {
                    pr.Hienthi(gridviewSinhvien);
                    Xoatextbox();
                }
                else
                {
                    ActiveControl = txtmasv;
                }
            }
            Xoatextbox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sinhvien s = new Sinhvien();
            s.masv = txtmasv.Text;
            pr.XoaSinhvien(s);
            pr.Hienthi(gridviewSinhvien);
            Xoatextbox();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            Sinhvien s = new Sinhvien();
            s.masv = txtmasv.Text;
            s.hoten = txtHoten.Text;
            s.tuoi = txtTuoi.Text;
            s.diachi = txtDiachi.Text;
            pr.SuaSinhvien(s);
            pr.Hienthi(gridviewSinhvien);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Sinhvien s = new Sinhvien();
            s.masv = txtmasv.Text;
            pr.TimSinhvien(s, gridviewSinhvien);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pr.Hienthi(gridviewSinhvien);
        }

        private void gridviewSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridviewSinhvien.SelectedCells[0].RowIndex;
            DataGridViewRow row = gridviewSinhvien.Rows[index];
            txtmasv.Text = Convert.ToString(row.Cells["masv"].Value);
            txtHoten.Text = Convert.ToString(row.Cells["hoten"].Value);
            txtTuoi.Text = Convert.ToString(row.Cells["tuoi"].Value);
            txtDiachi.Text = Convert.ToString(row.Cells["diachi"].Value);
        }
    }
}

