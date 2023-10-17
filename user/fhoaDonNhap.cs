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



    public partial class fhoaDonNhap : Form
    {



        private string id;
        private string idNv = Program.id;
        private string idNhaCC;
        private string ngayNhap;
        private string tongTien;


        void xoaTexBox()
        {

            txId.Text = "";
            txtIdNhaCC.Text = "";
            dtpNgayNhap.Text = "";
            txtTongTien.Text = "";

        }
        void loadDsHDN()
        {
            dgvDS.DataSource= hoaDonNhapBLL.Instance.loadDs();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txId.Enabled = false;
            txtTongTien.Enabled = false;
        }

        void layDuLieu()
        {

            id = txId.Text;
            idNhaCC = txtIdNhaCC.Text;
            ngayNhap = chuyenDoiDate.ConvertDateTime(dtpNgayNhap.Value.ToString());
            tongTien = txtTongTien.Text;


        }







        //chiTietHoaDon

        private string idHoaDonNhap;
        private string idSanPham;
        private string soLuong;
        private string donGia;


        void layDuLieuSp()
        {

            idHoaDonNhap = txId.Text;
            idSanPham = txtMaSp.Text;

            soLuong = Soluong.Value.ToString();
            donGia = txtGia.Text;
        }

        void loadDsSanPham()
        {
            dgvSP.DataSource= ctHoaDonNhapBLL.Instance.ds( id);
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
            txtGia.Text = "";


        }








        public fhoaDonNhap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            txId.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void fhoaDonNhap_Load(object sender, EventArgs e)
        {
            loadDsHDN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try 
            {
                layDuLieu();
                MessageBox.Show(hoaDonNhapBLL.Instance.xoa(id));
                loadDsHDN();
                xoaTexBox();
            } catch { MessageBox.Show("lỗi"); }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            

            try
            {
               layDuLieu();
            MessageBox.Show(hoaDonNhapBLL.Instance.them(id, idNv, idNhaCC, ngayNhap));
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
                txId.Focus();
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
                idNhaCC = row.Cells[2].Value.ToString();
                ngayNhap = row.Cells[3].Value.ToString();
                tongTien = row.Cells[4].Value.ToString();


                txId.Text = id;
                txtIdNhaCC.Text = idNhaCC;
                dtpNgayNhap.Text = ngayNhap;
                txtTongTien.Text = tongTien;
                loadDsSanPham();


            }
            layDuLieu();



            txId.Enabled = false;
            btnXoa.Enabled = true;
            //loadDsSp(id);


        
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

        private void btnluuSp_Click(object sender, EventArgs e)
        {
            try
            {
                layDuLieuSp();
                MessageBox.Show(ctHoaDonNhapBLL.Instance.them(idHoaDonNhap, idSanPham, soLuong, donGia));
                xoaTxtSanPham();
                loadDsSanPham();

            }catch(Exception ex)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnBoQuaSp_Click(object sender, EventArgs e)
        {
            xoaTxtSanPham();
            loadDsSanPham();
        }

        private void BtnXoaSP_Click(object sender, EventArgs e)
        {
            

            try
            {
            layDuLieuSp();
            MessageBox.Show(ctHoaDonNhapBLL.Instance.xoa(idHoaDonNhap, idSanPham));
            xoaTxtSanPham();
            loadDsSanPham();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            loadDsSanPham();
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemSp.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txId.Focus();
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
                txtMaSp.Text = row.Cells[1].Value.ToString();
            

                loadDsSanPham();


            }
            



            txtMaSp.Enabled = false;
            BtnXoaSP.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDS.DataSource= hoaDonNhapBLL.Instance.find(chuyenDoiDate.ConvertDateTime(dateTk.Value.ToString()));
        }
    }
}
