using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyBanMayTinh.DAO
{
    public class ctHoaDonDAO
    {
        private static ctHoaDonDAO instance; // Ctrl + R + E

        public static ctHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ctHoaDonDAO(); return ctHoaDonDAO.instance; }
            private set { ctHoaDonDAO.instance = value; }
        }



        public List<chiTietHoaDonBan> Ds(string id)
        {
            List<chiTietHoaDonBan> list = new List<chiTietHoaDonBan>();

            string query = "select * from dbo.ctHoaDonBan   where idHoaDonBan =  '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                chiTietHoaDonBan ds = new chiTietHoaDonBan(item);
                list.Add(ds);
            }
            return list;
        }

        public bool them(string idHoaDon, string idSanPham, string soLuong)
        {


            string query = string.Format("exec sp_ThemChiTietHoaDon @MaHoaDon ='{0}' ,@MaSanPham ='{1}'  ,  @SoLuong = {2}", idHoaDon, idSanPham, soLuong);
         
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool xoa(string idHoaDon, string idSanPham)
        {
            string query = string.Format("exec sp_xoaChiTietHoaDon1 @MaHoaDon ='{0}' ,@MaSanPham ='{1}' ", idHoaDon, idSanPham);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }




    }
}
