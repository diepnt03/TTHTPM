namespace TX2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttacgia = new System.Windows.Forms.TextBox();
            this.txtcasi = new System.Windows.Forms.TextBox();
            this.txttenbai = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.dataBai = new System.Windows.Forms.DataGridView();
            this.mabai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbmabai = new System.Windows.Forms.ComboBox();
            this.cbbtheloai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bài";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ca sĩ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên bài";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thể loại";
            // 
            // txttacgia
            // 
            this.txttacgia.Location = new System.Drawing.Point(197, 244);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(271, 26);
            this.txttacgia.TabIndex = 7;
            // 
            // txtcasi
            // 
            this.txtcasi.Location = new System.Drawing.Point(197, 195);
            this.txtcasi.Name = "txtcasi";
            this.txtcasi.Size = new System.Drawing.Size(271, 26);
            this.txtcasi.TabIndex = 8;
            // 
            // txttenbai
            // 
            this.txttenbai.Location = new System.Drawing.Point(197, 146);
            this.txttenbai.Name = "txttenbai";
            this.txttenbai.Size = new System.Drawing.Size(271, 26);
            this.txttenbai.TabIndex = 9;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(657, 48);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 40);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(657, 105);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 40);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "&Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(657, 163);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 40);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(657, 228);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(100, 40);
            this.btnketthuc.TabIndex = 14;
            this.btnketthuc.Text = "&Kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // dataBai
            // 
            this.dataBai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabai,
            this.theloai,
            this.tenbai,
            this.casi,
            this.tacgia});
            this.dataBai.Location = new System.Drawing.Point(38, 295);
            this.dataBai.Name = "dataBai";
            this.dataBai.RowHeadersWidth = 62;
            this.dataBai.RowTemplate.Height = 28;
            this.dataBai.Size = new System.Drawing.Size(957, 202);
            this.dataBai.TabIndex = 15;
            this.dataBai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBai_CellClick);
            this.dataBai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBai_CellContentClick);
            // 
            // mabai
            // 
            this.mabai.HeaderText = "Mã Bài";
            this.mabai.MinimumWidth = 8;
            this.mabai.Name = "mabai";
            this.mabai.Width = 150;
            // 
            // theloai
            // 
            this.theloai.HeaderText = "Thể Loại";
            this.theloai.MinimumWidth = 8;
            this.theloai.Name = "theloai";
            this.theloai.Width = 150;
            // 
            // tenbai
            // 
            this.tenbai.HeaderText = "Tên Bài";
            this.tenbai.MinimumWidth = 8;
            this.tenbai.Name = "tenbai";
            this.tenbai.Width = 150;
            // 
            // casi
            // 
            this.casi.HeaderText = "Ca sĩ";
            this.casi.MinimumWidth = 8;
            this.casi.Name = "casi";
            this.casi.Width = 150;
            // 
            // tacgia
            // 
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.MinimumWidth = 8;
            this.tacgia.Name = "tacgia";
            this.tacgia.Width = 150;
            // 
            // cbbmabai
            // 
            this.cbbmabai.FormattingEnabled = true;
            this.cbbmabai.Location = new System.Drawing.Point(197, 51);
            this.cbbmabai.Name = "cbbmabai";
            this.cbbmabai.Size = new System.Drawing.Size(266, 28);
            this.cbbmabai.TabIndex = 16;
            // 
            // cbbtheloai
            // 
            this.cbbtheloai.FormattingEnabled = true;
            this.cbbtheloai.Location = new System.Drawing.Point(197, 97);
            this.cbbtheloai.Name = "cbbtheloai";
            this.cbbtheloai.Size = new System.Drawing.Size(266, 28);
            this.cbbtheloai.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 558);
            this.Controls.Add(this.cbbtheloai);
            this.Controls.Add(this.cbbmabai);
            this.Controls.Add(this.dataBai);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttenbai);
            this.Controls.Add(this.txtcasi);
            this.Controls.Add(this.txttacgia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttacgia;
        private System.Windows.Forms.TextBox txtcasi;
        private System.Windows.Forms.TextBox txttenbai;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.DataGridView dataBai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabai;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbai;
        private System.Windows.Forms.DataGridViewTextBoxColumn casi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.ComboBox cbbmabai;
        private System.Windows.Forms.ComboBox cbbtheloai;
    }
}

