
namespace bai8_PhieuBT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtXa = new System.Windows.Forms.TextBox();
            this.txtHuyen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLocLuong = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Label();
            this.lblTongLuong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ /Xã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 263);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa Chỉ / Huyện";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(286, 143);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(252, 26);
            this.txtTuoi.TabIndex = 7;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(286, 178);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(252, 26);
            this.txtLuong.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(286, 98);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(252, 26);
            this.txtHoTen.TabIndex = 9;
            // 
            // txtXa
            // 
            this.txtXa.Location = new System.Drawing.Point(286, 218);
            this.txtXa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXa.Name = "txtXa";
            this.txtXa.Size = new System.Drawing.Size(252, 26);
            this.txtXa.TabIndex = 10;
            // 
            // txtHuyen
            // 
            this.txtHuyen.Location = new System.Drawing.Point(286, 258);
            this.txtHuyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHuyen.Name = "txtHuyen";
            this.txtHuyen.Size = new System.Drawing.Size(252, 26);
            this.txtHuyen.TabIndex = 11;
            this.txtHuyen.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(286, 335);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(252, 26);
            this.txtSoDienThoai.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 425);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(926, 231);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(585, 63);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(158, 35);
            this.btnLoadFile.TabIndex = 14;
            this.btnLoadFile.Text = "&Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(585, 108);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLocLuong
            // 
            this.btnLocLuong.Location = new System.Drawing.Point(585, 205);
            this.btnLocLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocLuong.Name = "btnLocLuong";
            this.btnLocLuong.Size = new System.Drawing.Size(158, 35);
            this.btnLocLuong.TabIndex = 16;
            this.btnLocLuong.Text = "Lương > 1000";
            this.btnLocLuong.UseVisualStyleBackColor = true;
            this.btnLocLuong.Click += new System.EventHandler(this.btnLocLuong_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(585, 254);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(158, 35);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(585, 157);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(158, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "&Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(585, 298);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 35);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Địa chỉ / Tỉnh";
            // 
            // txtTinh
            // 
            this.txtTinh.Location = new System.Drawing.Point(286, 298);
            this.txtTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTinh.Name = "txtTinh";
            this.txtTinh.Size = new System.Drawing.Size(252, 26);
            this.txtTinh.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(286, 58);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(252, 26);
            this.txtMaNV.TabIndex = 23;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(110, 383);
            this.count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(155, 20);
            this.count.TabIndex = 24;
            this.count.Text = "Tổng Lương > 1000: ";
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.AutoSize = true;
            this.lblTongLuong.ForeColor = System.Drawing.Color.Red;
            this.lblTongLuong.Location = new System.Drawing.Point(279, 383);
            this.lblTongLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(18, 20);
            this.lblTongLuong.TabIndex = 25;
            this.lblTongLuong.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 383);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tổng nhân viên cùng Tỉnh: ";
            // 
            // lblTinh
            // 
            this.lblTinh.AutoSize = true;
            this.lblTinh.Location = new System.Drawing.Point(564, 383);
            this.lblTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinh.Name = "lblTinh";
            this.lblTinh.Size = new System.Drawing.Size(18, 20);
            this.lblTinh.TabIndex = 27;
            this.lblTinh.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblTinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTongLuong);
            this.Controls.Add(this.count);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnLocLuong);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtHuyen);
            this.Controls.Add(this.txtXa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtXa;
        private System.Windows.Forms.TextBox txtHuyen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLocLuong;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTinh;
    }
}

