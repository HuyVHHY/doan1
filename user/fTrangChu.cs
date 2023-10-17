using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user
{
    public partial class fTrangChu : Form
    {
        public fTrangChu()
        {
            InitializeComponent();


            OpenChildForm(new msTrangChu());
            if (int.Parse(Program.typee)>0)
            {
                nHÂNVIÊNToolStripMenuItem.Enabled = false;
                sẢNPHẨMToolStripMenuItem.Enabled = false;
                tHỐNGKÊToolStripMenuItem.Enabled = false;
                hÓAĐƠNNHẬPToolStripMenuItem.Enabled = false;


            }
        }
        private Form currentFormChild1;


        private void OpenChildForm(Form FormChild)
        {
            if (currentFormChild1 != null)
            {
                currentFormChild1.Close();
            }
            currentFormChild1 = FormChild;
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            FormChild.Dock = DockStyle.Fill;
            panel1.Controls.Add(currentFormChild1);
            panel1.Tag = FormChild;
            FormChild.BringToFront();
            FormChild.Show();
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new fnhanVien());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void sẢNPHẨMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new fSanPham());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void nHÀCUNGCẤPToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenChildForm(new fNhaCC());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hÓAĐƠNNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new fhoaDonNhap());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void hÓAĐƠNXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new fHoaDonBan());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void tRANGCHỦToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new msTrangChu());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void thốngKêHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new fThongKeNhap());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void thốngKêHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                OpenChildForm(new FthongKeXuat());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }

        private void kháchHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new fKhachHang());

            }
            catch (Exception ex) { MessageBox.Show("lỗi"); }
        }
    }
}
