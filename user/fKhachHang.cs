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
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }
        private string id;
        private string ten;
        private string sdt;
        private string emai;

        void layDuLieu()
        {
            id = txtId.Text;
            ten = txtTen.Text;
            sdt = txtSDT.Text;
            emai = txtEmail.Text;
        }


        void xoaTexBox()
        {

            txtId.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";

        }

        void loadDs()
        {
            dgvDs.DataSource= khachHangBLL.Instance.loadDs();
            
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtId.Enabled = false;
        }


        private void dgvDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }
            if (dgvDs.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dgvDs.Rows[e.RowIndex];

                id = row.Cells[0].Value.ToString();
                ten = row.Cells[1].Value.ToString();
                sdt = row.Cells[2].Value.ToString();
                emai = row.Cells[3].Value.ToString();



                txtId.Text = id;
                txtTen.Text = ten;
                txtSDT.Text = sdt;
                txtEmail.Text = emai;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                txtId.Enabled = false;
                btnThem.Enabled = true;
                btnBoQua.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            txtId.Enabled = true;
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
                MessageBox.Show(khachHangBLL.Instance.them(id, ten, sdt, emai));
                xoaTexBox();
                loadDs();

            }
            catch
            {

                MessageBox.Show("lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                layDuLieu();
                MessageBox.Show(khachHangBLL.Instance.sua(id, ten, sdt, emai));
                xoaTexBox();
                loadDs();

            }
            catch
            {

                MessageBox.Show("lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                layDuLieu();
                MessageBox.Show(khachHangBLL.Instance.xoa(id));
                xoaTexBox();
                loadDs();

            }
            catch
            {

                MessageBox.Show("lỗi");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            loadDs();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDs.DataSource= khachHangBLL.Instance.find(txtTimMaNCC.Text,txtTimMaNCC.Text);
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            loadDs  ();
        }
    }
}
