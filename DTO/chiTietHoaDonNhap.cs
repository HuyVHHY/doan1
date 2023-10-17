using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chiTietHoaDonNhap
    {



        public chiTietHoaDonNhap
            (
            string idHoaDonNhap,
            string idSanPham,
            string soLuong,
            string donGia
            ) 
        {
            this.IdHoaDonNhap= idHoaDonNhap;
            this.IdSanPham= idSanPham;
            this.SoLuong= soLuong;
            this.DonGia= donGia;
        }


        public chiTietHoaDonNhap(DataRow row) 
        {
            this.IdHoaDonNhap = row["idHoaDonNhap"].ToString();
            this.IdSanPham = row["idSanPham"].ToString();
            this.SoLuong = row["soLuong"].ToString();
            this.DonGia = row["donGia"].ToString();

        }

        private string idHoaDonNhap;
        private string idSanPham;
        private string soLuong;
        private string donGia;

        public string IdHoaDonNhap { get => idHoaDonNhap; set => idHoaDonNhap = value; }
      

        public string IdSanPham { get => idSanPham; set => idSanPham = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string DonGia { get => donGia; set => donGia = value; }
    }
}
