using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class sanPham
    {
        public sanPham
        (

        string id,
        string ten,
        string loai,
        string thuongHieu,
        string moTa,
        string giaBan,
        string soLuong
        ) 
        { 

            this.Id= id;
            this.Ten= ten;
            this.Loai= loai;
            this.ThuongHieu= thuongHieu;
            this.MoTa= moTa;
            this.GiaBan= giaBan;
            this.SoLuong= soLuong;
        }


        public sanPham (DataRow row)
        {

            this.Id = row["idSanPham"].ToString();
            this.Ten = row["tenSanPham"].ToString();
            this.Loai = row["loaiSanPham"].ToString();
            this.ThuongHieu = row["thuongHieu"].ToString();
            this.MoTa = row["moTa"].ToString();
            this.GiaBan = row["giaBan"].ToString();
            this.SoLuong = row["soLuong"].ToString();

        }



        private string id;
        private string ten;
        private string loai;
        private string thuongHieu;
        private string moTa;
        private string giaBan;
        private string soLuong;

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loai { get => loai; set => loai = value; }
        public string ThuongHieu { get => thuongHieu; set => thuongHieu = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        
      
        public string GiaBan { get => giaBan; set => giaBan = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
    }
}
