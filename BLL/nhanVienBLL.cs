using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using QuanLyBanMayTinh.DAO;

namespace BLL
{
    public class nhanVienBLL
    {

        private static nhanVienBLL instance; // Ctrl + R + E

        public static nhanVienBLL Instance
        {
            get 
            { if (instance == null) instance = new nhanVienBLL();
                return nhanVienBLL.instance; }
            private set 
            { nhanVienBLL.instance = value; }
        }

        public bool Login(string userName, string passWord)
        {
            return nhanVienDAO.Instance.Login(userName, passWord);

        }


        public string[] idNguoiQuyen(string userName, string passWord)
        {
            string[] arr = new string[2];


            arr = nhanVienDAO.Instance.layIdQuyen(userName, passWord);

            return arr;
        }


        public List<nhanVien> loadDs()
        {
            return nhanVienDAO.Instance.getLisNhanVien(); 
            
        }


        public bool them(string idNhanVien, string tenNhanVien, string ngaySinh, string gioiTinh, string canCuoc, string sdt, string email, string diaChi, string userName, string password, int typee)
        {
            if( nhanVienDAO.Instance.themNhanVien(idNhanVien, tenNhanVien, ngaySinh, gioiTinh, canCuoc, sdt, email, diaChi, userName, password, typee))
            {
                return true;

            }
            else
            {
                return false;
            } 

        }


        public bool sua(string idNhanVien, string tenNhanVien, string ngaySinh, string gioiTinh, string canCuoc, string sdt, string email, string diaChi, string userName, string password, int typee)
        {
            if(nhanVienDAO.Instance.suaNhanVien(idNhanVien, tenNhanVien, ngaySinh, gioiTinh, canCuoc, sdt, email, diaChi, userName, password, typee))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool xoa(string id)
        {
            if(nhanVienDAO.Instance.xoa(id))
            { return true; }
            else { return false; }

        }



        public List<nhanVien> find(string id ,string name) 
        {
            return nhanVienDAO.Instance.fildNhanVien(id,name);

        }

        public bool checkId(string id)
        {
            if(nhanVienDAO.Instance.kiemtraMa(id)) { return true; }
            else { return false; }  

        }


        public bool checkName(string name)
        {
            if(nhanVienDAO.Instance.kiemTk(name)) { return true; }
            else { return false; }
        }
    }
}
