using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BLL
{
    public class hoaDonNhapBLL
    {


        private static hoaDonNhapBLL instance; // Ctrl + R + E

        public static hoaDonNhapBLL Instance
        {
            get { if (instance == null) instance = new hoaDonNhapBLL(); return hoaDonNhapBLL.instance; }
            private set { hoaDonNhapBLL.instance = value; }
        }


        public List<hoaDonNhap> loadDs()
        {
            return hoaDonNhapDAO.Instance.Ds();
        }

        public List<hoaDonNhap> find( string ngay)
        {
            return hoaDonNhapDAO.Instance.find( ngay);
        }

        public bool checkid (string id)
        {
            if (hoaDonNhapDAO.Instance.kiemtraMa(id))
            {
                return true;
            }
            else { return false; }

        }

        public string them(string id,
            string idNv,
           string idNhaCC,
           string ngayNhap)
        {
            if (checkid(id))
            {
                if (hoaDonNhapDAO.Instance.them(id, idNv, idNhaCC, ngayNhap))
                {
                    return "thành công";
                }
                else
                {
                    return "thất bại";
                }
            }
            else
            {
                return " id bị trùng";
            }
        }




        public string xoa(string id)
        {
            if (hoaDonNhapDAO.Instance.xoa(id))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }

        }
    }
}
