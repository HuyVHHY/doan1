using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class khachHang

    {


        public khachHang(string id, string ten,string sdt,string emai)
        {
             this.Id=id;
             this.Ten=ten;
             this.Sdt=  sdt;
             this.Emai= emai;



        }
        public khachHang(DataRow row) 
        
        {
            this.Id = row["idKhachHang"].ToString();
            this.Ten = row["tenKhachHang"].ToString();
            this.Sdt = row["sdtKhachHang"].ToString();
            this.Emai = row["emailKhachHang"].ToString();
        }


        private string id;
        private string ten;
        private string sdt;
        private string emai;

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Emai { get => emai; set => emai = value; }
    }
}
