using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyBanMayTinh.DAO
{
    public class nhaCcDAO
    {


        private static nhaCcDAO instance;

        public static nhaCcDAO Instance
        {
            get { if (instance == null) instance = new nhaCcDAO(); return nhaCcDAO.instance; }
            private set { nhaCcDAO.instance = value; }
        }

        public List<nhaCungCap> DsnhaCungCap()
        {
            List<nhaCungCap> list = new List<nhaCungCap>();

            string query = "select * from dbo.nhaCC ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                nhaCungCap ds = new nhaCungCap(item);
                list.Add(ds);
            }
            return list;
        }


        public bool kiemtraMa(string id)
        {
            string query = string.Format("select * from dbo.nhaCC where idNhaCC ='{0}'", id);

            int result = DataProvider.Instance.KiemTraMa(query);

            return result <= 0;
        }


        public bool xoa(string id)
        {
            string query = string.Format("delete from dbo.nhaCC where idNhaCC ='{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }




        public List<nhaCungCap> findNhaCC(string id, string name)
        {
            List<nhaCungCap> list = new List<nhaCungCap>();

            string query = string.Format("select * from dbo.nhaCC where idNhaCC ='{0}' or tenNhaCC like N'%{1}%'", id, name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                nhaCungCap ds = new nhaCungCap(item);
                list.Add(ds);
            }
            return list;
        }


        public bool themNhaCC(string id,string ten,string sdt,string email,string diaChi )
        {



            string query = string.Format("insert into nhaCC(idNhaCC,tenNhaCC,sdtNhaCC,emaiNhaCC,diaChiNhaCC)values ( '{0}',N'{1}' , N'{2}',N'{3}' ,N'{4}')", id, ten,sdt, email,diaChi );



            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool suaNhaCC(string id, string ten, string sdt, string email, string diaChi)
        {



            string query = string.Format("UPDATE dbo.nhaCC set tenNhaCC=N'{1}',sdtNhaCC='{2}',emaiNhaCC='{3}',diaChiNhaCC =N'{4}' where  idNhaCC ='{0}'", id, ten, sdt, email, diaChi);


            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }


    }
}
