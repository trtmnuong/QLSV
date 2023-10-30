namespace QuanLyTienDien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbsokw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbsokw = new System.Windows.Forms.TextBox();
            this.tbthanhtien = new System.Windows.Forms.TextBox();
            this.tbloaiho = new System.Windows.Forms.TextBox();
            this.tbtenkh = new System.Windows.Forms.TextBox();
            this.tbmakh = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(29, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 226);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(47, 39);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(618, 170);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(641, 457);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 35);
            this.btnthoat.TabIndex = 18;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(546, 457);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 35);
            this.btnxoa.TabIndex = 19;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuybo
            // 
            this.btnhuybo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnhuybo.Location = new System.Drawing.Point(449, 457);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(75, 35);
            this.btnhuybo.TabIndex = 20;
            this.btnhuybo.Text = "Hủy bỏ";
            this.btnhuybo.UseVisualStyleBackColor = true;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Location = new System.Drawing.Point(355, 457);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 35);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(249, 457);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 35);
            this.btnsua.TabIndex = 22;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(151, 457);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 35);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreload.Location = new System.Drawing.Point(58, 457);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(75, 35);
            this.btnreload.TabIndex = 24;
            this.btnreload.Text = "ReLoad";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(206, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "DANH SÁCH TIÊU THỤ ĐIỆN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbsokw);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbsokw);
            this.groupBox1.Controls.Add(this.tbthanhtien);
            this.groupBox1.Controls.Add(this.tbloaiho);
            this.groupBox1.Controls.Add(this.tbtenkh);
            this.groupBox1.Controls.Add(this.tbmakh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(29, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 161);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.EnabledChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(417, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thành tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại hộ";
            // 
            // lbsokw
            // 
            this.lbsokw.AutoSize = true;
            this.lbsokw.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbsokw.Location = new System.Drawing.Point(417, 26);
            this.lbsokw.Name = "lbsokw";
            this.lbsokw.Size = new System.Drawing.Size(59, 19);
            this.lbsokw.TabIndex = 3;
            this.lbsokw.Text = "Số KW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã khách hàng";
            // 
            // tbsokw
            // 
            this.tbsokw.Location = new System.Drawing.Point(535, 26);
            this.tbsokw.Name = "tbsokw";
            this.tbsokw.Size = new System.Drawing.Size(152, 27);
            this.tbsokw.TabIndex = 2;
            // 
            // tbthanhtien
            // 
            this.tbthanhtien.Location = new System.Drawing.Point(535, 75);
            this.tbthanhtien.Name = "tbthanhtien";
            this.tbthanhtien.Size = new System.Drawing.Size(152, 27);
            this.tbthanhtien.TabIndex = 2;
            this.tbthanhtien.TextChanged += new System.EventHandler(this.tbthanhtien_TextChanged);
            // 
            // tbloaiho
            // 
            this.tbloaiho.Location = new System.Drawing.Point(143, 115);
            this.tbloaiho.Name = "tbloaiho";
            this.tbloaiho.Size = new System.Drawing.Size(152, 27);
            this.tbloaiho.TabIndex = 2;
            // 
            // tbtenkh
            // 
            this.tbtenkh.Location = new System.Drawing.Point(143, 63);
            this.tbtenkh.Name = "tbtenkh";
            this.tbtenkh.Size = new System.Drawing.Size(152, 27);
            this.tbtenkh.TabIndex = 2;
            // 
            // tbmakh
            // 
            this.tbmakh.Location = new System.Drawing.Point(143, 19);
            this.tbmakh.Name = "tbmakh";
            this.tbmakh.Size = new System.Drawing.Size(152, 27);
            this.tbmakh.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 581);
            this.Controls.Add(this.btnhuybo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsokw;
        private System.Windows.Forms.TextBox tbthanhtien;
        private System.Windows.Forms.TextBox tbloaiho;
        private System.Windows.Forms.TextBox tbtenkh;
        private System.Windows.Forms.TextBox tbmakh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbsokw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

