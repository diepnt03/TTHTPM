
namespace sdde1
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
            this.dssp = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSLBan = new System.Windows.Forms.TextBox();
            this.txtTienBan = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dssp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DonGia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SL Ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền Bán";
            // 
            // dssp
            // 
            this.dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssp.Location = new System.Drawing.Point(30, 264);
            this.dssp.Name = "dssp";
            this.dssp.RowHeadersWidth = 62;
            this.dssp.RowTemplate.Height = 28;
            this.dssp.Size = new System.Drawing.Size(824, 205);
            this.dssp.TabIndex = 5;
            this.dssp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssp_CellContentClick);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(191, 38);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(190, 26);
            this.txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(191, 84);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(190, 26);
            this.txtTenSP.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(191, 136);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(190, 26);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtSLBan
            // 
            this.txtSLBan.Location = new System.Drawing.Point(191, 179);
            this.txtSLBan.Name = "txtSLBan";
            this.txtSLBan.Size = new System.Drawing.Size(190, 26);
            this.txtSLBan.TabIndex = 9;
            // 
            // txtTienBan
            // 
            this.txtTienBan.Location = new System.Drawing.Point(191, 220);
            this.txtTienBan.Name = "txtTienBan";
            this.txtTienBan.Size = new System.Drawing.Size(190, 26);
            this.txtTienBan.TabIndex = 10;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(585, 34);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(102, 41);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(585, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 41);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(585, 147);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 41);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(585, 205);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(102, 41);
            this.btnTK.TabIndex = 14;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 586);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtTienBan);
            this.Controls.Add(this.txtSLBan);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.dssp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dssp;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSLBan;
        private System.Windows.Forms.TextBox txtTienBan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTK;
    }
}

