namespace Nhap_phan_tu
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFindbyCity = new System.Windows.Forms.Button();
            this.btnFindbyID = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 30);
            this.txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(169, 207);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(185, 30);
            this.txtAge.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(169, 262);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(185, 30);
            this.txtCity.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(169, 94);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 30);
            this.txtId.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(417, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(417, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(417, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 30);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(572, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 30);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFindbyCity
            // 
            this.btnFindbyCity.Location = new System.Drawing.Point(572, 204);
            this.btnFindbyCity.Name = "btnFindbyCity";
            this.btnFindbyCity.Size = new System.Drawing.Size(134, 30);
            this.btnFindbyCity.TabIndex = 15;
            this.btnFindbyCity.Text = "&Find by City";
            this.btnFindbyCity.UseVisualStyleBackColor = true;
            // 
            // btnFindbyID
            // 
            this.btnFindbyID.Location = new System.Drawing.Point(572, 149);
            this.btnFindbyID.Name = "btnFindbyID";
            this.btnFindbyID.Size = new System.Drawing.Size(134, 30);
            this.btnFindbyID.TabIndex = 14;
            this.btnFindbyID.Text = "&Find by ID";
            this.btnFindbyID.UseVisualStyleBackColor = true;
            this.btnFindbyID.Click += new System.EventHandler(this.btnFindbyID_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(572, 91);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(113, 30);
            this.btnLoadFile.TabIndex = 13;
            this.btnLoadFile.Text = "&Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Number of students";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(460, 351);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(23, 25);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "0";
            this.lblCount.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFindbyCity);
            this.Controls.Add(this.btnFindbyID);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Course";
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFindbyCity;
        private System.Windows.Forms.Button btnFindbyID;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

