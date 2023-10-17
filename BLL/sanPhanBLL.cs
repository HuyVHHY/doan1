using DTO;
using QuanLyBanMayTinh.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class sanPhanBLL
    {


        private static sanPhanBLL instance; // Ctrl + R + E

        public static sanPhanBLL Instance
        {
            get { if (instance == null) instance = new sanPhanBLL(); return sanPhanBLL.instance; }
            private set { sanPhanBLL.instance = value; }
        }


        public List<sanPham> loadDs()
        {
            return sanPhamDAO.Instance.DsSanPham();
            
        }


        public List<sanPham> find(string id , string name)
        {

            return sanPhamDAO.Instance.find(id,name);
        }


        public bool checkId(string id)
        {
            if (sanPhamDAO.Instance.kiemtraMa(id))
            {
                return true;
            }
            else { return false; }
        }


        public string xoa(string id)
        {
            if (sanPhamDAO.Instance.xoa(id))
            {
                return "xóa thành công";
            }

            else
            {
                return "xóa thất bại";
            }
        }


        public string them(string id, string ten, string loai, string thuongHieu, string moTa, string giaBan)
        {
            if (checkId(id))
            {
                if (sanPhamDAO.Instance.them(id, ten, loai, thuongHieu, moTa, giaBan))
                {
                    return "thêm thành công";
                }
                else
                {
                    return "thêm thất bại";
                }

            }
            else
            {
                return "bị trùng id";
            }
           
        }


        public string sua(string id, string ten, string loai, string thuongHieu, string moTa, string giaBan)
        {
            if(sanPhamDAO.Instance.sua(id, ten, loai, thuongHieu, moTa, giaBan))
            {
                return "sửa thành công";

            }
            else
            {
                return "sửa thất bại";
            }
        }


    }
}
