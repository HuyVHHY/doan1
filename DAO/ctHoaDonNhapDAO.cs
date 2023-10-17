using DTO;
using QuanLyBanMayTinh.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class ctHoaDonNhapDAO
    {
        private static ctHoaDonNhapDAO instance;

        public static ctHoaDonNhapDAO Instance
        {
            get { if (instance == null) instance = new ctHoaDonNhapDAO(); return ctHoaDonNhapDAO.instance; }
            private set { ctHoaDonNhapDAO.instance = value; }
        }

        public List<chiTietHoaDonNhap> Ds(string id)
        {
            List<chiTietHoaDonNhap> list = new List<chiTietHoaDonNhap>();

            string query = "select * from dbo.ctHoaDonNhap   where idHoaDonNhap =  '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                chiTietHoaDonNhap ds = new chiTietHoaDonNhap(item);
                list.Add(ds);
            }
            return list;
        }



        public bool them(string idHoaDonNhap, string idSanPham, string soLuong, string donGia)
        {

            
                string query = string.Format("exec  ThemHoaDonNhap @MaHoaDon = '{0}', @MaSanPham = '{1}', @SoLuong = {2}, @GiaSanPham = {3}", idHoaDonNhap, idSanPham, soLuong, donGia);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            
        }

        public bool xoa(string idHoaDonNhap, string idSanPham)
        {
            string query = string.Format("exec XoaChiTietHoaDonNhap @MaHoaDon = '{0}' , @MaSanPham='{1}'", idHoaDonNhap, idSanPham);


            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
