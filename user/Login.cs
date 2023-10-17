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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (nhanVienBLL.Instance.Login(userName, passWord))
            {

                arr = nhanVienBLL.Instance.idNguoiQuyen(userName, passWord);
                Program.id = arr[0];
                Program.typee = arr[1];
                fTrangChu f = new fTrangChu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var thongBao = MessageBox.Show("EXIT?","Thông Báo",MessageBoxButtons.YesNo);
            if (thongBao == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
