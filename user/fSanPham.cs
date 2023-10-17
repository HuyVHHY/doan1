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
    public partial class fSanPham : Form
    {


        private string id;
        private string ten;
        private string loai;
        private string thuongHieu;
        private string moTa;
        private string giaBan;


        void layDuLieu()
        {
            id = txtID.Text;
            ten = txtTen.Text;
            loai = txtLoai.Text;
            thuongHieu = txtThongHieu.Text;
            moTa = txtMoTa.Text;
            giaBan = txtGiaBan.Text;
        }

        void xoaTexBox()
        {

            txtID.Text = "";
            txtTen.Text = "";
            txtLoai.Text = "";
            txtThongHieu.Text = "";
            txtMoTa.Text = "";
            txtGiaBan.Text = "";


        }
        public fSanPham()
        {
            InitializeComponent();
        }
        public void loadDs()
        {
            dataGridView1.DataSource=sanPhanBLL.Instance.loadDs();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtID.Enabled = false;
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            loadDs();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            xoaTexBox();
            txtID.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try 
            {
                layDuLieu();
                MessageBox.Show(sanPhanBLL.Instance.sua(id, ten, loai, thuongHieu, moTa, giaBan));
                xoaTexBox();
                loadDs();
            }
            catch 
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                layDuLieu();

                MessageBox.Show(sanPhanBLL.Instance.them(id, ten, loai, thuongHieu, moTa, giaBan)) ;
                loadDs();

            }catch(Exception ex)
            {
                MessageBox.Show("lỗi");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            try {

             layDuLieu();
            MessageBox.Show(sanPhanBLL.Instance.xoa(id));
            xoaTexBox();
            loadDs();

            }
            catch (Exception ex)
            {
                MessageBox.Show("sản phẩm con trong hóa dơn");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            loadDs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];



                id = row.Cells[0].Value.ToString();
                ten = row.Cells[1].Value.ToString();
                loai = row.Cells[2].Value.ToString();
                thuongHieu = row.Cells[3].Value.ToString();
                moTa = row.Cells[4].Value.ToString();
                giaBan = row.Cells[5].Value.ToString();



                txtID.Text = id;
                txtTen.Text = ten;
                txtLoai.Text = loai;
                txtThongHieu.Text = thuongHieu;
                txtMoTa.Text = moTa;
                txtGiaBan.Text = giaBan.ToString();



                txtID.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                txtID.Enabled = true;
                btnThem.Enabled = true;
                btnBoQua.Enabled = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            try
            {
                dataGridView1.DataSource = sanPhanBLL.Instance.find(txtTimMa.Text, txtTimTen.Text);
            }
            catch {
                MessageBox.Show("LỖI TÌM KIẾM");
            }
            
        }
    }
}
