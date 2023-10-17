namespace user
{
    partial class fhoaDonNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dateTk = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Soluong = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnluuSp = new System.Windows.Forms.Button();
            this.btnBoQuaSp = new System.Windows.Forms.Button();
            this.BtnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtIdNhaCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Soluong)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1142, 590);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnTim);
            this.groupBox9.Controls.Add(this.dateTk);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Location = new System.Drawing.Point(906, 28);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(237, 292);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tìm Kiếm";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTim.Location = new System.Drawing.Point(62, 213);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(90, 32);
            this.btnTim.TabIndex = 16;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dateTk
            // 
            this.dateTk.Location = new System.Drawing.Point(31, 111);
            this.dateTk.Margin = new System.Windows.Forms.Padding(2);
            this.dateTk.Name = "dateTk";
            this.dateTk.Size = new System.Drawing.Size(144, 20);
            this.dateTk.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ngày Nhập";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvSP);
            this.groupBox6.Location = new System.Drawing.Point(603, 338);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(540, 256);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sản Phẩm Đã Có Trong Đơn";
            // 
            // dgvSP
            // 
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(9, 19);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.Size = new System.Drawing.Size(530, 226);
            this.dgvSP.TabIndex = 0;
            this.dgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellContentClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtGia);
            this.groupBox7.Controls.Add(this.txtMaSp);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.Soluong);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(603, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(297, 313);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi Tiết Hóa Đơn";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(14, 152);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(277, 20);
            this.txtGia.TabIndex = 17;
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(29, 97);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(92, 20);
            this.txtMaSp.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã Sản Phẩm";
            // 
            // Soluong
            // 
            this.Soluong.Location = new System.Drawing.Point(182, 97);
            this.Soluong.Name = "Soluong";
            this.Soluong.Size = new System.Drawing.Size(90, 20);
            this.Soluong.TabIndex = 13;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnluuSp);
            this.groupBox8.Controls.Add(this.btnBoQuaSp);
            this.groupBox8.Controls.Add(this.BtnXoaSP);
            this.groupBox8.Controls.Add(this.btnThemSp);
            this.groupBox8.Location = new System.Drawing.Point(14, 178);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(279, 123);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Xác Nhận";
            // 
            // btnluuSp
            // 
            this.btnluuSp.BackColor = System.Drawing.Color.Green;
            this.btnluuSp.Location = new System.Drawing.Point(17, 75);
            this.btnluuSp.Name = "btnluuSp";
            this.btnluuSp.Size = new System.Drawing.Size(92, 48);
            this.btnluuSp.TabIndex = 12;
            this.btnluuSp.Text = "Lưu";
            this.btnluuSp.UseVisualStyleBackColor = false;
            this.btnluuSp.Click += new System.EventHandler(this.btnluuSp_Click);
            // 
            // btnBoQuaSp
            // 
            this.btnBoQuaSp.Location = new System.Drawing.Point(166, 75);
            this.btnBoQuaSp.Name = "btnBoQuaSp";
            this.btnBoQuaSp.Size = new System.Drawing.Size(92, 48);
            this.btnBoQuaSp.TabIndex = 11;
            this.btnBoQuaSp.Text = "Bỏ Qua";
            this.btnBoQuaSp.UseVisualStyleBackColor = true;
            this.btnBoQuaSp.Click += new System.EventHandler(this.btnBoQuaSp_Click);
            // 
            // BtnXoaSP
            // 
            this.BtnXoaSP.BackColor = System.Drawing.Color.Red;
            this.BtnXoaSP.Location = new System.Drawing.Point(166, 28);
            this.BtnXoaSP.Name = "BtnXoaSP";
            this.BtnXoaSP.Size = new System.Drawing.Size(92, 48);
            this.BtnXoaSP.TabIndex = 9;
            this.BtnXoaSP.Text = "Xóa";
            this.BtnXoaSP.UseVisualStyleBackColor = false;
            this.BtnXoaSP.Click += new System.EventHandler(this.BtnXoaSP_Click);
            // 
            // btnThemSp
            // 
            this.btnThemSp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThemSp.Location = new System.Drawing.Point(17, 28);
            this.btnThemSp.Name = "btnThemSp";
            this.btnThemSp.Size = new System.Drawing.Size(92, 48);
            this.btnThemSp.TabIndex = 7;
            this.btnThemSp.Text = "Thêm";
            this.btnThemSp.UseVisualStyleBackColor = false;
            this.btnThemSp.Click += new System.EventHandler(this.btnThemSp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giá Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số Lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 584);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnBoQua);
            this.groupBox3.Location = new System.Drawing.Point(0, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 145);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xác Nhận";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Green;
            this.btnLuu.Location = new System.Drawing.Point(17, 67);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 48);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(129, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 48);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Location = new System.Drawing.Point(17, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 48);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(129, 67);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(92, 48);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDS);
            this.groupBox4.Location = new System.Drawing.Point(278, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 564);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvDS
            // 
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS.Location = new System.Drawing.Point(3, 16);
            this.dgvDS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.RowHeadersWidth = 51;
            this.dgvDS.RowTemplate.Height = 24;
            this.dgvDS.Size = new System.Drawing.Size(296, 545);
            this.dgvDS.TabIndex = 1;
            this.dgvDS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtIdNhaCC);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.dtpNgayNhap);
            this.groupBox5.Controls.Add(this.txtTongTien);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txId);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(17, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 344);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Hóa Đơn";
            // 
            // txtIdNhaCC
            // 
            this.txtIdNhaCC.Location = new System.Drawing.Point(26, 126);
            this.txtIdNhaCC.Name = "txtIdNhaCC";
            this.txtIdNhaCC.Size = new System.Drawing.Size(144, 20);
            this.txtIdNhaCC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(24, 185);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(144, 20);
            this.dtpNgayNhap.TabIndex = 7;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(26, 249);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(144, 20);
            this.txtTongTien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng Gía Trị Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Nhập";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(26, 68);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(144, 20);
            this.txId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // fhoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 673);
            this.Controls.Add(this.groupBox1);
            this.Name = "fhoaDonNhap";
            this.Text = "fhoaDonNhap";
            this.Load += new System.EventHandler(this.fhoaDonNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Soluong)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dateTk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Soluong;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnluuSp;
        private System.Windows.Forms.Button btnBoQuaSp;
        private System.Windows.Forms.Button BtnXoaSP;
        private System.Windows.Forms.Button btnThemSp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtIdNhaCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label label1;
    }
}