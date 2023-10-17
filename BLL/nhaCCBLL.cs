using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using DAO;
using DTO;
using QuanLyBanMayTinh.DAO;

namespace BLL
{
    public class nhaCCBLL
    {
        private static nhaCCBLL instance; // Ctrl + R + E

        public static nhaCCBLL Instance
        {
            get { if (instance == null) instance = new nhaCCBLL(); return nhaCCBLL.instance; }
            private set { nhaCCBLL.instance = value; }
        }


        public List<nhaCungCap> loadDs()
        {
            return nhaCcDAO.Instance.DsnhaCungCap();
        }

        public List<nhaCungCap> find( string id, string name) 
        {

            return nhaCcDAO.Instance.findNhaCC(id, name);
        }

        public bool checkId(string id)
        {
            if (nhaCcDAO.Instance.kiemtraMa(id))
                {
                return true;
            
            } else
            {
                return false;
            }
        }


        public string them(string id, string ten, string sdt, string email, string diaChi)
        {
            if(checkId(id))
            {
                if (nhaCcDAO.Instance.themNhaCC(id, ten, sdt, email, diaChi))
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
                return "id bị trùng";
            }
        }


        public string sua(string id, string ten, string sdt, string email, string diaChi)
        {
            if(nhaCcDAO.Instance.suaNhaCC(id, ten, sdt, email, diaChi)) {
                return "thành công";
            }
            else { return "thất bại"; }

        }

        public string xoa(string id)
        {
            if (nhaCcDAO.Instance.xoa(id))
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
