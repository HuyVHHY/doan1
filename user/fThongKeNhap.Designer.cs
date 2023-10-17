namespace user
{
    partial class fThongKeNhap
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInTK = new System.Windows.Forms.Button();
            this.txtTongKe = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nam = new System.Windows.Forms.RadioButton();
            this.thang = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tháng = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDsTk = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtInTK);
            this.groupBox4.Controls.Add(this.txtTongKe);
            this.groupBox4.Location = new System.Drawing.Point(357, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 176);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xác Nhận";
            // 
            // txtInTK
            // 
            this.txtInTK.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtInTK.Location = new System.Drawing.Point(142, 19);
            this.txtInTK.Name = "txtInTK";
            this.txtInTK.Size = new System.Drawing.Size(105, 145);
            this.txtInTK.TabIndex = 4;
            this.txtInTK.Text = "In Thống Kê";
            this.txtInTK.UseVisualStyleBackColor = false;
            this.txtInTK.Click += new System.EventHandler(this.txtInTK_Click);
            // 
            // txtTongKe
            // 
            this.txtTongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTongKe.Location = new System.Drawing.Point(20, 19);
            this.txtTongKe.Name = "txtTongKe";
            this.txtTongKe.Size = new System.Drawing.Size(105, 145);
            this.txtTongKe.TabIndex = 0;
            this.txtTongKe.Text = "Thống Kê";
            this.txtTongKe.UseVisualStyleBackColor = false;
            this.txtTongKe.Click += new System.EventHandler(this.txtTongKe_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.nam);
            this.groupBox5.Controls.Add(this.thang);
            this.groupBox5.Location = new System.Drawing.Point(366, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 77);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thống Kê Theo";
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nam.Location = new System.Drawing.Point(162, 33);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(58, 22);
            this.nam.TabIndex = 1;
            this.nam.TabStop = true;
            this.nam.Text = "Năm";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // thang
            // 
            this.thang.AutoSize = true;
            this.thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thang.Location = new System.Drawing.Point(34, 33);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(67, 22);
            this.thang.TabIndex = 0;
            this.thang.TabStop = true;
            this.thang.Text = "Tháng";
            this.thang.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tháng);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.txtThang);
            this.groupBox1.Location = new System.Drawing.Point(366, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 207);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Theo Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm";
            // 
            // tháng
            // 
            this.tháng.AutoSize = true;
            this.tháng.Location = new System.Drawing.Point(24, 56);
            this.tháng.Name = "tháng";
            this.tháng.Size = new System.Drawing.Size(38, 13);
            this.tháng.TabIndex = 2;
            this.tháng.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(76, 117);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 1;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(76, 56);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDsTk);
            this.groupBox3.Location = new System.Drawing.Point(12, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 579);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách";
            // 
            // dgvDsTk
            // 
            this.dgvDsTk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsTk.Location = new System.Drawing.Point(6, 25);
            this.dgvDsTk.Name = "dgvDsTk";
            this.dgvDsTk.Size = new System.Drawing.Size(303, 554);
            this.dgvDsTk.TabIndex = 0;
            // 
            // fThongKeNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "fThongKeNhap";
            this.Text = "fThongKeNhap";
            this.Load += new System.EventHandler(this.fThongKeNhap_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsTk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button txtInTK;
        private System.Windows.Forms.Button txtTongKe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.RadioButton thang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tháng;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDsTk;
    }
}