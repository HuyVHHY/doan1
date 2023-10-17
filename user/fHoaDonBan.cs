using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user
{
    public partial class fHoaDonBan : Form
    {

        //hoa don 

        private string id;
        private string idNhanVien = Program.id;
        private string idKhachHang;
        private string ngayNhap;
        private string tongTien;


        void xoaTexBox()
        {

            txIdHoaDon.Text = "";
            txtMaKhanhHang.Text = "";
            dtpNgayBan.Text = "";
            txtTongTien.Text = "";

        }

        void loadDsHDN()
        {
            dgvDS.DataSource= HoaDonBLL.Instance.loadDs();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txIdHoaDon.Enabled = false;
            txtTongTien.Enabled = false;
            txtTongTien.Enabled=false;
        }



        void layDuLieu()
        {
            idHoaDonBan = txIdHoaDon.Text;

            id = txIdHoaDon.Text;
            idKhachHang = txtMaKhanhHang.Text;
            ngayNhap = chuyenDoiDate.ConvertDateTime(dtpNgayBan.Value.ToString());
            tongTien = txtTongTien.Text;
        }


        // chi tieets hoa don


        private string idHoaDonBan;
        private string idSanPham;
        private string soLuong;



        void layDuLieuSp()
        {

            idHoaDonBan = txIdHoaDon.Text;
            idSanPham = txtMaSp.Text;

            soLuong = Soluong.Value.ToString();
        }

        void loadDsSanPham()
        {
            dgvSP.DataSource= ctHoaDonBLL.Instance.ds(idHoaDonBan);
            btnThemSp.Enabled = true;
            BtnXoaSP.Enabled = false;
            btnluuSp.Enabled = false;
            txtMaSp.Enabled = false;
            txtTongTien.Enabled = false;
        }

        void xoaTxtSanPham()
        {
            txtMaSp.Text = "";
            Soluong.Value = 0;


        }



        public fHoaDonBan()
        {
            InitializeComponent();
        }

        private void fHoaDonBan_Load(object sender, EventArgs e)
        {
            loadDsHDN();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            txIdHoaDon.Enabled = true;
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
                MessageBox.Show(HoaDonBLL.Instance.them(id, idNhanVien, idKhachHang, ngayNhap));
                loadDsHDN();
                xoaTexBox();
            }
            catch { MessageBox.Show("nhập sai bị trùng khóa"); }
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txIdHoaDon.Focus();
                return;
            }
            if (dgvDS.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dgvDS.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                idKhachHang = row.Cells[2].Value.ToString();
                ngayNhap = row.Cells[3].Value.ToString();
                tongTien = row.Cells[4].Value.ToString();


                txIdHoaDon.Text = id;
                txtMaKhanhHang.Text = idKhachHang;
                dtpNgayBan.Text = ngayNhap;
                txtTongTien.Text = tongTien;
                loadDsSanPham();


            }
            layDuLieu();



            txIdHoaDon.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            xoaTxtSanPham();
            txtMaSp.Enabled = true;
            BtnXoaSP.Enabled = false;
            btnThemSp.Enabled = false;
            btnluuSp.Enabled = true;
            btnBoQuaSp.Enabled = true;
        }

        private void BtnXoaSP_Click(object sender, EventArgs e)
        {

            layDuLieuSp();
            MessageBox.Show(ctHoaDonBLL.Instance.xoa(idHoaDonBan, idSanPham));
            xoaTxtSanPham();
            loadDsSanPham();
            try
            {

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnBoQuaSp_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            loadDsSanPham();
        }

        private void btnluuSp_Click(object sender, EventArgs e)
        {
           
            try
            {
                layDuLieuSp();
                MessageBox.Show(ctHoaDonBLL.Instance.them(idHoaDonBan, idSanPham, soLuong));
                xoaTxtSanPham();
                loadDsSanPham();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

            layDuLieuSp();
            HoaDonBLL.Instance.inHoaDon(idHoaDonBan);
            xoaTxtSanPham();
            loadDsSanPham();
            try
            {
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemSp.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txIdHoaDon.Focus();
                return;
            }
            if (dgvDS.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                
                    DataGridViewRow row = dgvSP.Rows[e.RowIndex];
                    txtMaSp.Text = row.Cells[1].Value.ToString();



            }




            txtMaSp.Enabled = false;
            BtnXoaSP.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                layDuLieu();
                MessageBox.Show(HoaDonBLL.Instance.xoa(idHoaDonBan));
                loadDsHDN();
                xoaTexBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
