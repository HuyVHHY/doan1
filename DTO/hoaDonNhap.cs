using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hoaDonNhap
    {

        public hoaDonNhap
            (
            string id,
            string idNv,
            string idNhaCC,
            string ngayNhap,
            string tongTien
            ) 
        {
            this.Id = id;
            this.IdNv = idNv;
            this.IdNhaCC= idNhaCC;
            this.NgayNhap = ngayNhap;
            this.TongTien= tongTien;
        }

        public hoaDonNhap(DataRow row)
        {
            this.Id = row["idHoaDonNhap"].ToString();
            this.IdNv = row["idNhanVien"].ToString();
            this.IdNhaCC = row["idNhaCC"].ToString();
            this.NgayNhap = row["ngayNhap"].ToString();
            this.TongTien = row["tongTien"].ToString();

        }


        private string id;
        private string idNv;
        private string idNhaCC;
        private string ngayNhap;
        private string tongTien;

        public string Id { get => id; set => id = value; }
        public string IdNv { get => idNv; set => idNv = value; }
        public string IdNhaCC { get => idNhaCC; set => idNhaCC = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
    }
}
