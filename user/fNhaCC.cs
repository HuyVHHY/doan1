using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace user
{
    public partial class fNhaCC : Form
    {

        private string id;
        private string ten;
        private string sdt;
        private string email;
        private string diaChi;


        void loadDsNhaCC()
        {
            dgvNhaCC.DataSource= nhaCCBLL.Instance.loadDs();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhaCC.Enabled = false;
        }
        void layDuLieu()
        {
            id = txtMaNhaCC.Text;
            ten = txtTenNhaCC.Text;
            sdt = txtSDT.Text;
            email = txtEmail.Text;
            diaChi = txtDiaChi.Text;

        }
        void xoaTexBox()
        {

            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";

        }

        public fNhaCC()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            xoaTexBox();
            txtMaNhaCC.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                layDuLieu();
                MessageBox.Show(nhaCCBLL.Instance.them(id, ten, sdt, email, diaChi));
                xoaTexBox();
                loadDsNhaCC();

            }
            catch
            {
                MessageBox.Show("nhâp đầy đủ thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try {

                layDuLieu();
                MessageBox.Show(nhaCCBLL.Instance.sua(id, ten, sdt, email, diaChi));
                xoaTexBox();
                loadDsNhaCC();
            }
            catch
            {
                MessageBox.Show("nhâp đầy đủ thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                layDuLieu();
                MessageBox.Show(nhaCCBLL.Instance.xoa(id));
                xoaTexBox();
                loadDsNhaCC();
            }
            catch
            {
                MessageBox.Show("nhâp đầy đủ thông tin");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            loadDsNhaCC();
        }

        private void dgvNhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaCC.Focus();
                return;
            }
            if (dgvNhaCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dgvNhaCC.Rows[e.RowIndex];

                id = row.Cells[0].Value.ToString();
                ten = row.Cells[1].Value.ToString();
                sdt = row.Cells[2].Value.ToString();
                email = row.Cells[3].Value.ToString();
                diaChi = row.Cells[4].Value.ToString();


                txtMaNhaCC.Text = id;
                txtTenNhaCC.Text = ten;
                txtSDT.Text = sdt;
                txtEmail.Text = email;
                txtDiaChi.Text = diaChi;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                txtMaNhaCC.Enabled = false;
                btnThem.Enabled = true;
                btnBoQua.Enabled = true;



            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource= nhaCCBLL.Instance.find(txtTimMaNCC.Text, txtTimNCC.Text);
        }

        private void fNhaCC_Load(object sender, EventArgs e)
        {
            loadDsNhaCC ();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
