namespace BaiTH2
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
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.gridviewSinhvien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(182, 116);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(198, 26);
            this.txtHoten.TabIndex = 4;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(182, 152);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(198, 26);
            this.txtTuoi.TabIndex = 5;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(182, 80);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(198, 26);
            this.txtmasv.TabIndex = 6;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(182, 188);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(198, 26);
            this.txtDiachi.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Đọc file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(437, 126);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 36);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(437, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 36);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(594, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 36);
            this.button6.TabIndex = 16;
            this.button6.Text = "&Đóng";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(594, 126);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(133, 36);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "&Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(594, 76);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(133, 36);
            this.btnCapnhat.TabIndex = 14;
            this.btnCapnhat.Text = "&Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // gridviewSinhvien
            // 
            this.gridviewSinhvien.AllowUserToOrderColumns = true;
            this.gridviewSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewSinhvien.Location = new System.Drawing.Point(73, 293);
            this.gridviewSinhvien.Name = "gridviewSinhvien";
            this.gridviewSinhvien.RowHeadersWidth = 62;
            this.gridviewSinhvien.RowTemplate.Height = 28;
            this.gridviewSinhvien.Size = new System.Drawing.Size(691, 235);
            this.gridviewSinhvien.TabIndex = 17;
            this.gridviewSinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSinhvien_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 630);
            this.Controls.Add(this.gridviewSinhvien);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.DataGridView gridviewSinhvien;
    }
}

