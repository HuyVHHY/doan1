using DTO;
using QuanLyBanMayTinh.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class khachHangBLL
    {


        private static khachHangBLL instance; // Ctrl + R + E

        public static khachHangBLL Instance
        {
            get { if (instance == null) instance = new khachHangBLL(); return khachHangBLL.instance; }
            private set { khachHangBLL.instance = value; }
        }


        public List<khachHang> loadDs()
        {
            return  khachHangDA0.Instance.Ds();
            
        }


        public List<khachHang> find(string id,string name )
        {
            return khachHangDA0.Instance.find(id,name);
            
        }


        public string them(string id,  string ten,   string sdt,   string emai)
        {

            if (khachHangDA0.Instance.kiemtraMa(id))
            {
                if(khachHangDA0.Instance.them(id,ten, sdt, emai))
                {
                    return "thành công";
                }
                else
                {
                    return "thất bại";
                }

            }

            else { return "mã bị trùng"; }

        }

        public string sua(string id, string ten, string sdt, string emai)
        {
            if (khachHangDA0.Instance.sua(id, ten, sdt, emai))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }



        public string xoa(string id)
        {
            if (khachHangDA0.Instance.xoa(id))
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
