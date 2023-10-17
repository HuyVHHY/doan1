
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chiTietHoaDonBan
    {

        public chiTietHoaDonBan(
            string idHoaDonBan,
            string idSanPham,
            int soLuong) 
        {
            this.IdHoaDonBan = idHoaDonBan;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
         
        }

        public chiTietHoaDonBan(DataRow row) 
        {
            this.IdHoaDonBan = row["idHoaDonBan"].ToString();
            this.IdSanPham = row["idSanPham"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.gia= row["Gia"].ToString();
        }

        private string idHoaDonBan;
        private string idSanPham;
        private int soLuong;
        private string gia;
       
        public string IdHoaDonBan { get => idHoaDonBan; set => idHoaDonBan = value; }
        public string IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string Gia { get => gia; set => gia = value; }
    }
}
