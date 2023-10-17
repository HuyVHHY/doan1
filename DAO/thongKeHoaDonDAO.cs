using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class thongKeHoaDonDAO
    {

        private static thongKeHoaDonDAO instance;

        public static thongKeHoaDonDAO Instance
        {
            get { if (instance == null) instance = new thongKeHoaDonDAO(); return thongKeHoaDonDAO.instance; }
            private set { thongKeHoaDonDAO.instance = value; }
        }



        public DataTable tblThongtinHD( string ma)
        {


            DataTable tblThongtinHang;
           string  sql = " SELECT a.idHoaDonBan, a.ngayNhap, a.Tongtien, b.tenKhachHang, b.emailKhachHang, b.sdtKhachHang, c.tenNhanVien FROM hoaDonBan AS a, khachHang AS b, nhanVien AS c WHERE a.idHoaDonBan = '" + ma + "' AND a.idKhachHang = b.idKhachHang AND a.idNhanVien = c.idNhanVien";
            tblThongtinHang = DataProvider.Instance.ExecuteQuery(sql);

            return tblThongtinHang;
        }

        public DataTable tblThong(string ma)
        {
            DataTable tblThong;
            string sql = " SELECT x.tenSanPham, a.SoLuong, x.giaBan, a.Gia FROM ctHoaDonBan AS a , hoaDonBan AS b , dbo.sanPham as x WHERE a.idHoaDonBan ='" + ma + "' AND a.idHoaDonBan = b.idHoaDonBan and a.idSanPham = x.idSanPham";
                        tblThong = DataProvider.Instance.ExecuteQuery(sql);

            return tblThong;
        }


        public List<thongKe> thongKethang(string thang, string nam)
        {
            List<thongKe> list = new List<thongKe>();

            string query = string.Format("SELECT * FROM fn_DoanhThuNgay1({0}, {1}) ", thang, nam);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                thongKe baoCao = new thongKe(item);
                list.Add(baoCao);
            }
            return list;
        }

        public DataTable inThongKethang(string thang, string nam)
        {
            DataTable tblThong;
            string sql = string.Format("SELECT * FROM fn_DoanhThuNgay1({0}, {1}) ", thang, nam);
            tblThong = DataProvider.Instance.ExecuteQuery(sql);

            return tblThong;
        }

        public List<thongKe> thongKeNam(string nam)
        {
            List<thongKe> list = new List<thongKe>();

            string query = string.Format("SELECT * FROM ThongKeTheoThang ({0}) ", nam);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                thongKe baoCao = new thongKe(item);
                list.Add(baoCao);
            }
            return list;
        }


        public DataTable inthongKeNam(string nam)
        {
            DataTable tblThong;
            string sql = string.Format("SELECT * FROM ThongKeTheoThang ({0}) ", nam);
            tblThong = DataProvider.Instance.ExecuteQuery(sql);

            return tblThong;
        }



        public List<thongKe> thongKethangNhap(string thang, string nam)
        {
            List<thongKe> list = new List<thongKe>();

            string query = string.Format("SELECT * FROM fn_nhapTheoNgay({1}, {0}) ", thang, nam);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                thongKe baoCao = new thongKe(item);
                list.Add(baoCao);
            }
            return list;
        }


        public DataTable inthongKethangNhap(string thang, string nam)
        {
            DataTable tblThong;
            string sql = string.Format("SELECT * FROM fn_nhapTheoNgay({1}, {0}) ", thang, nam);
            tblThong = DataProvider.Instance.ExecuteQuery(sql);

            return tblThong;
        }

        public List<thongKe> thongKeNamNhap(string nam)
        {
            List<thongKe> list = new List<thongKe>();

            string query = string.Format("SELECT * FROM ThongKeNhapTheoThang({0}); ", nam);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                thongKe baoCao = new thongKe(item);
                list.Add(baoCao);
            }
            return list;
        }

        public DataTable inthongKeNamNhap(string nam)
        {
            DataTable tblThong;
            string sql = string.Format("SELECT * FROM ThongKeNhapTheoThang({0}); ", nam);
            tblThong = DataProvider.Instance.ExecuteQuery(sql);

            return tblThong;
        }





    }
}
