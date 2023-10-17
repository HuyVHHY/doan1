using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class nhaCungCap
    {




        public nhaCungCap
            (
             string id,
            string ten,
            string sdt,
            string email,
            string diaChi
            ) 
        {
          this.Id= id;
            this.Ten= ten;
            this.Sdt= sdt;
            this.Email= email;
            this.DiaChi= diaChi;
        

        }

        public nhaCungCap(DataRow row)
        {

            this.Id = row["idNhaCC"].ToString();
            this.Ten = row["tenNhaCC"].ToString();
            this.Sdt = row["sdtNhaCC"].ToString();
            this.Email = row["emaiNhaCC"].ToString();
            this.DiaChi = row["diaChiNhaCC"].ToString();

        }


        private string id;
        private string ten;
        private string sdt;
        private string email;
        private string diaChi;

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
