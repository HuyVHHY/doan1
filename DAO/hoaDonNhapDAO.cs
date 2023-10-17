using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class hoaDonNhapDAO
    {


        private static hoaDonNhapDAO instance; // Ctrl + R + E

        public static hoaDonNhapDAO Instance
        {
            get { if (instance == null) instance = new hoaDonNhapDAO(); return hoaDonNhapDAO.instance; }
            private set { hoaDonNhapDAO.instance = value; }
        }

        public List<hoaDonNhap> Ds()
        {
            List<hoaDonNhap> list = new List<hoaDonNhap>();

            string query = "select * from dbo.HoaDonNhap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                hoaDonNhap ds = new hoaDonNhap(item);
                list.Add(ds);
            }
            return list;
        }

        public List<hoaDonNhap> find( string ngayNhap)
        {
            List<hoaDonNhap> list = new List<hoaDonNhap>();

            string query = string.Format("select * from dbo.hoaDonNhap where ngayNhap =N'{0}'",   ngayNhap);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                hoaDonNhap ds = new hoaDonNhap(item);
                list.Add(ds);
            }
            return list;
        }


        public bool kiemtraMa(string id)
        {
            string query = string.Format("select * from dbo.ctHoaDonNhap where idHoaDonNhap ='{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result <= 0;
        }



        public bool them(
           string  id,
            string idNv,
           string  idNhaCC,
           string  ngayNhap

            )
        {
            string query = string.Format("insert into dbo.hoaDonNhap(idHoaDonNhap,idNhanVien,idNhaCC,ngayNhap,tongTien) values ('{0}','{1}','{2}','{3}',0)",id, idNv, idNhaCC,ngayNhap  );


            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }


        public bool xoa( string id)
        {
            string query = string.Format("delete from  dbo.hoaDonNhap where idHoaDonNhap ='{0}'", id );

           

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }





    }
}
