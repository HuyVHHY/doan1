using BLL;
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
    public partial class fThongKeNhap : Form
    {
        public fThongKeNhap()
        {
            InitializeComponent();
        }

        private void txtTongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (thang.Checked)
                {

                    dgvDsTk.DataSource = ThongKeBLL.Instance.dsNhapNgay( txtThang.Text, txtNam.Text);
                }
                else
                {
                    dgvDsTk.DataSource= ThongKeBLL.Instance.dsNhapThang(txtNam.Text);
                }

            }
            catch
            {
                MessageBox.Show("lõi");
            }
            
        }

        private void txtInTK_Click(object sender, EventArgs e)
        {
            try { 
                    if (thang.Checked)
                    {

                        ThongKeBLL.Instance.inThongKetThangNhap(txtNam.Text, txtThang.Text);
                    }
                    else
                    {
                        ThongKeBLL.Instance.inThongKetNamNhap(txtNam.Text);
                    }
                }
             catch
                {
                    MessageBox.Show("lõi");
                }
        }

        private void fThongKeNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
