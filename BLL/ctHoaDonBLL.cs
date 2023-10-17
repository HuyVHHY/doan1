using DAO;
using DTO;
using QuanLyBanMayTinh.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class ctHoaDonBLL
    {


        private static ctHoaDonBLL instance; // Ctrl + R + E

        public static ctHoaDonBLL Instance
        {
            get { if (instance == null) instance = new ctHoaDonBLL(); return ctHoaDonBLL.instance; }
            private set { ctHoaDonBLL.instance = value; }
        }


        public List<chiTietHoaDonBan> ds(string id)
        {
            return ctHoaDonDAO.Instance.Ds(id);
        }


        public string them(string idHoaDon, string idSanPham, string soLuong)
        {
            if (ctHoaDonDAO.Instance.them(idHoaDon, idSanPham, soLuong))
            {
                return " thành công";
            }
            else
            {
                return "thất bại";
            }
        }
        public string xoa(string idHoaDonNhap, string idSanPham)
        {
            if (!ctHoaDonDAO.Instance.xoa(idHoaDonNhap, idSanPham))
            {
                return " thành công";
            }
            else
            {
                return "thất bại";
            }
        }
    } 
}
