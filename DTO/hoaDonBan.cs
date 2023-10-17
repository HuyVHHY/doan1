using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hoaDonBan
    {


        public hoaDonBan
            (string id,string idNhanVien,string idKhachHang, string ngayNhap, string tongTien)
        {
                            
            this.Id = id;
            this.IdKhachHang = idKhachHang;
            this.IdNhanVien= idNhanVien;
            this.NgayNhap=ngayNhap;
            this.TongTien= tongTien;
         
        }

        public hoaDonBan(DataRow row)
        {

            this.Id = row["idHoaDonBan"].ToString();
            this.IdNhanVien = row["idNhanVien"].ToString();

            this.IdKhachHang = row["idKhachHang"].ToString();
            this.NgayNhap = row["ngayNhap"].ToString();
            this.TongTien = row["tongTien"].ToString();

        }


        private string id;
        private string idNhanVien;
        private string idKhachHang;
        private string ngayNhap;
        private string tongTien;
        

        public string Id { get => id; set => id = value; }
      
        public string IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public string IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
    }
}
