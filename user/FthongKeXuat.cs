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
    public partial class FthongKeXuat : Form
    {
        public FthongKeXuat()
        {
            InitializeComponent();
        }

        private void txtInTK_Click(object sender, EventArgs e)
        {
            try
            {if (thang.Checked)
            {

                ThongKeBLL.Instance.inthongKethang(txtThang.Text, txtNam.Text);
            }
            else
            {
                ThongKeBLL.Instance.inthongKeNam(txtNam.Text);
            }

            }catch (Exception ex) { MessageBox.Show("lỗi"); }
            
        }

        private void txtTongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (thang.Checked)
                            {

                    dgvDsTk.DataSource= ThongKeBLL.Instance.dsBanNgay(txtThang.Text, txtNam.Text);
                            }
                else
                {
                    dgvDsTk.DataSource = ThongKeBLL.Instance.dsBanThang(txtNam.Text);
                }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            
        }
    }
}
