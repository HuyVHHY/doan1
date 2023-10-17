using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class nhanVien
    {
        public nhanVien
            (
            string idNhanVien,
            string tenNhanVien,
            string ngaySinh,
            string gioiTinh,
            string canCuoc,
            string sdt,
            string email,
            string diaChi,
            string userName,
            string password,
            int typee
            )
        { 
            this.IdNhanVien= idNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.NgaySinh = ngaySinh;
            this.GioiTinh= gioiTinh;    
            this.CanCuoc= canCuoc;
            this.Sdt= sdt;
            this.Email= email;  
            this.DiaChi= diaChi;
            this.UserName= userName;
            this.Password= password;
            this.Typee= typee;


        } 


        public nhanVien (DataRow row)
        {

            this.IdNhanVien = row["idNhanVien"].ToString();
            this.TenNhanVien = row["tenNhanVien"].ToString();
            this.NgaySinh = row["ngaySinhNhanVien"].ToString();
            this.GioiTinh = row["gioiTinhNhanVien"].ToString();
            this.CanCuoc = row["cccdNhanVien"].ToString();
            this.Sdt= row["sdtNhanVien"].ToString();
            this.Email = row["emaiNhanVien"].ToString();
            this.DiaChi = row["diaChiNhanVien"].ToString();
            this.UserName = row["UserName"].ToString();
            this.Password = row["PassWordd"].ToString();
            this.Typee = (int)row["Typee"];

        }


        private string idNhanVien;
        private string tenNhanVien;
        private string ngaySinh;
        private string gioiTinh;
        private string canCuoc;
        private string sdt;
        private string email;
        private string diaChi;
        private string userName;
        private string password;
        private int typee;

        public string IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CanCuoc { get => canCuoc; set => canCuoc = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Typee { get => typee; set => typee = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
