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
    public partial class fnhanVien : Form
    {
        private string idNhanVien;
        private string tenNhanVien;
        private string ngaySinh;
        private string gioiTinh;
        private string canCuoc;
        private string sdt;
        private string email;
        private string diaChi;
        private string userName;
        private string password;
        private int typee;




        void layDuLieuTufrom()
        {

            idNhanVien = txtMaNv.Text;
            tenNhanVien = txtTenNv.Text;
            ngaySinh =  chuyenDoiDate.ConvertDateTime(dtpNgaySinh.Value.ToString());

            if (gtNamSinh.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else if (gtNu.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                MessageBox.Show("chọn nam hoạc nữ");
            };

            canCuoc = txtSoCC.Text;
            sdt = txtSdt.Text;
            email = txtEmail.Text;
            diaChi = txtDiaChi.Text;
            userName = txtTk.Text;
            password = txtMk.Text;
            typee = ccbChucVu.SelectedIndex;
          


        }


        void xoaTexBox()
        {
            txtMaNv.Text = "";
            txtTenNv.Text = "";

            gtNamSinh.Checked = false;
            gtNu.Checked = false;

            txtSoCC.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtTk.Text = "";
            txtMk.Text = "";

        }


        void loadDs()
        {

            dgvDsNhanVien.DataSource= nhanVienBLL.Instance.loadDs();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNv.Enabled = false;

        }





        public fnhanVien()
        {
            InitializeComponent();
        }

        private void dgvDsNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNv.Focus();
                return;
            }
            if (dgvDsNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dgvDsNhanVien.Rows[e.RowIndex];

                idNhanVien = row.Cells[0].Value.ToString();
                tenNhanVien = row.Cells[1].Value.ToString();
                ngaySinh = row.Cells[2].Value.ToString();
                gioiTinh = row.Cells[3].Value.ToString();
                canCuoc = row.Cells[4].Value.ToString();
                sdt = row.Cells[10].Value.ToString();
                email = row.Cells[5].Value.ToString();
                diaChi = row.Cells[6].Value.ToString();
                userName = row.Cells[7].Value.ToString();
                password = row.Cells[8].Value.ToString();
                typee = (int)row.Cells[9].Value;


                txtMaNv.Text = idNhanVien;
                txtTenNv.Text = tenNhanVien;
                if (gioiTinh == "nam")
                {
                    gtNamSinh.Checked = true;
                    gtNu.Checked = false;
                }
                else
                {
                    gtNamSinh.Checked = false;
                    gtNu.Checked = true;
                }
                txtSoCC.Text = canCuoc;
                txtSdt.Text = sdt;
                txtEmail.Text = email;
                txtDiaChi.Text = diaChi;
                txtTk.Text = userName;
                txtMk.Text = password;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                txtMaNv.Enabled = false;
                btnThem.Enabled = true;
                btnBoQua.Enabled = true;
            }
        }

        private void fnhanVien_Load(object sender, EventArgs e)
        {
            loadDs();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xoaTexBox();
            txtMaNv.Enabled = true;
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

                layDuLieuTufrom();
                if (nhanVienBLL.Instance.checkId(idNhanVien))
                {


                    if (nhanVienBLL.Instance.checkName(tenNhanVien))
                    {


                        if (nhanVienBLL.Instance.them(idNhanVien, tenNhanVien, ngaySinh, gioiTinh, canCuoc, sdt, email, diaChi, userName, password, typee))
                        {
                            MessageBox.Show("thêm thành công");
                            loadDs();
                            xoaTexBox();
                        }
                        else
                        {
                            MessageBox.Show("thêm không thành công");
                        }

                    }
                    else
                    {
                        MessageBox.Show("bị trùng ID");
                    }

                }
                else
                {
                    MessageBox.Show("đã có id");
                }


            }
            catch
            {
                MessageBox.Show("lỗi");
            }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            loadDs();



            xoaTexBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {



            try
            {

                layDuLieuTufrom();

                if (nhanVienBLL.Instance.sua(idNhanVien, tenNhanVien, ngaySinh, gioiTinh, canCuoc, sdt, email, diaChi, userName, password, typee))
                {
                    MessageBox.Show("thành công");
                    xoaTexBox();
                    loadDs();
                }

            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                layDuLieuTufrom();
                if (nhanVienBLL.Instance.xoa(idNhanVien))
                {
                    MessageBox.Show("xoa thành công");
                    loadDs();
                    xoaTexBox();
                }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDsNhanVien.DataSource= nhanVienBLL.Instance.find(txtTimMa.Text, txtTimTen.Text);
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            
        }

        private void ccbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
