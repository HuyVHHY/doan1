using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class hoaDonDAO
    {

        private static hoaDonDAO instance;

        public static hoaDonDAO Instance
        {
            get { if (instance == null) instance = new hoaDonDAO(); return hoaDonDAO.instance; }
            private set { hoaDonDAO.instance = value; }
        }

        public List<hoaDonBan> Ds()
        {
            List<hoaDonBan> list = new List<hoaDonBan>();

            string query = "select * from dbo.hoaDonBan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                hoaDonBan ds = new hoaDonBan(item);
                list.Add(ds);
            }
            return list;
        }

        public List<hoaDonBan> find(string ngay)
        {
            List<hoaDonBan> list = new List<hoaDonBan>();

            string query = "select * from dbo.hoaDonBan where ngayNhap='"+ngay+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                hoaDonBan ds = new hoaDonBan(item);
                list.Add(ds);
            }
            return list;
        }



        public bool kiemtraMa(string id)
        {
            string query = string.Format("select * from dbo.hoaDonBan where idHoaDonBan ='{0}'", id);
           
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result <= 0;
        }



        public bool them( string id, string idNhanVien, string idKhachHang,   string ngayNhap   )
        {
            string query = string.Format("insert into dbo.hoaDonBan(idHoaDonBan,idNhanVien,idKhachHang,ngayNhap,tongTien) values ('{0}','{1}','{2}','{3}',0)", id, idNhanVien, idKhachHang, ngayNhap);


            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }


        public bool xoa(string id)
        {
            string query = string.Format("delete from  dbo.hoaDonBan where idHoaDonBan ='{0}'", id);



            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }


    }
}
