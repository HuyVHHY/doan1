using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

namespace QuanLyBanMayTinh.DAO
{
    public class khachHangDA0
    {

        private static khachHangDA0 instance; // Ctrl + R + E

        public static khachHangDA0 Instance
        {
            get { if (instance == null) instance = new khachHangDA0(); return khachHangDA0.instance; }
            private set { khachHangDA0.instance = value; }
        }

        public List<khachHang> Ds()
        {
            List<khachHang> list = new List<khachHang>();

            string query = "select * from dbo.khachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                khachHang ds = new khachHang(item);
                list.Add(ds);
            }
            return list;
        }


        public List<khachHang> find(string id, string name)
        {
            List<khachHang> list = new List<khachHang>();

            string query = string.Format("select * from dbo.khachHang where idKhachHang ='{0}' or tenKhachHang like N'%{1}%'", id, name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                khachHang ds = new khachHang(item);
                list.Add(ds);
            }
            return list;
        }

        public bool kiemtraMa(string id)
        {
            string query = string.Format("select * from dbo.khachHang where idKhachHang ='{0}'", id);

            int result = DataProvider.Instance.KiemTraMa(query);

            return result <= 0;
        }

        public bool them(
           string id,
           string ten,
           string sdt,
           string emai
            )
        {
            string query = string.Format("insert into dbo.khachHang(idKhachHang,tenKhachHang,sdtKhachHang,emailKhachHang)values('{0}',N'{1}',N'{2}',N'{3}')",
               id,
               ten, 
               sdt, 
               emai 
                );



            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }




        public bool sua (
           string id,
           string ten,
           string sdt,
           string emai
            )
        {
            string query = string.Format("UPDATE dbo.khachHang set tenKhachHang =N'{1}' ,sdtKhachHang='{2}' ,emailKhachHang ='{3}'where idKhachHang ='{0}'",
               id,
               ten,
               sdt,
               emai
                );



            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }



        public bool xoa(string id)
        {
            string query = string.Format("delete from  dbo.khachHang where idKhachHang ='{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


    }
}
