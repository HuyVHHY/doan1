using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;

namespace BLL
{
    public class ctHoaDonNhapBLL
    {

        private static ctHoaDonNhapBLL instance; // Ctrl + R + E

        public static ctHoaDonNhapBLL Instance
        {
            get { if (instance == null) instance = new ctHoaDonNhapBLL(); return ctHoaDonNhapBLL.instance; }
            private set { ctHoaDonNhapBLL.instance = value; }
        }


        public List<chiTietHoaDonNhap> ds(string id )
        {
            return ctHoaDonNhapDAO.Instance.Ds(id);
        }


        public string them(string idHoaDonNhap, string idSanPham, string soLuong, string donGia)
        {
            if (!ctHoaDonNhapDAO.Instance.them(idHoaDonNhap, idSanPham, soLuong, donGia))
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
            if (ctHoaDonNhapDAO.Instance.xoa(idHoaDonNhap, idSanPham))
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
