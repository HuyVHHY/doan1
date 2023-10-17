using DTO;
using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyBanMayTinh.DAO
{
    public class nhanVienDAO
    {

        private static nhanVienDAO instance;

        public static nhanVienDAO Instance
        {
            get { if (instance == null) instance = new nhanVienDAO(); return nhanVienDAO.instance; }
            private set { nhanVienDAO.instance = value; }
        }


        //đăng nhập
        public bool Login(string userName, string passWord)
        {


            string query = "USP_DangNhap @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord /*list*/});
            return result.Rows.Count > 0;
        }


        public nhanVien GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from nhanVien where UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new nhanVien(item);
            }

            return null;
        }
        public string[] layIdQuyen(string tk, string mk)
        {
            string[] arr=new string[2];
            DataTable data = DataProvider.Instance.ExecuteQuery("Select idNhanVien,Typee from nhanVien where UserName = '" + tk + "'  and PassWordd='" + mk + "' ");
            if (!data.HasErrors)
            {
                foreach (DataRow row in data.Rows)
                {

                    arr[0]=row["idNhanVien"].ToString();
                    arr[1]=row["Typee"].ToString();
                    break;
                }


            }
            return arr;
        }





        public List<nhanVien> getLisNhanVien()
        {
            List<nhanVien> list = new List<nhanVien>();

            string query = "select * from nhanVien ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                nhanVien nhanVien = new nhanVien(item);
                list.Add(nhanVien);
            }
            return list;
        }
        public bool kiemTk( string tk)
        {

            string query = string.Format("select * from nhanVien where UserName ='{0}'", tk);

            int result = DataProvider.Instance.KiemTraMa(query);
            return result <= 0;

        }

        public bool kiemtraMa(string tk)
        {
            string query = string.Format("select * from nhanVien where idNhanVien ='{0}'", tk);

            int result = DataProvider.Instance.KiemTraMa(query);

            return result <= 0;
        }



        public bool themNhanVien( string idNhanVien,  string tenNhanVien,  string ngaySinh,  string gioiTinh, string canCuoc, string sdt, string email,string diaChi, string userName,string password,int typee)
        {

            

            string query = string.Format("insert into nhanVien(idNhanVien,tenNhanVien,ngaySinhNhanVien,gioiTinhNhanVien,cccdNhanVien,sdtNhanVien,emaiNhanVien,diaChiNhanVien,UserName,PassWordd,Typee)values('{0}',N'{1}','{2}',N'{3}','{4}','{5}','{6}',N'{7}','{8}','{9}',{10})", idNhanVien, tenNhanVien, ngaySinh,gioiTinh,canCuoc,sdt,email,diaChi,userName,password,typee);


            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool xoa(string idNhanVien)
        {
            string query = string.Format("delete from nhanVien  where idNhanVien ='{0}'", idNhanVien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }



        public bool suaNhanVien(string idNhanVien, string tenNhanVien, string ngaySinh, string gioiTinh, string canCuoc, string sdt, string email, string diaChi, string userName, string password, int typee)
        {



            string query = string.Format("UPDATE dbo.nhanVien set tenNhanVien =N'{0}' ,ngaySinhNhanVien=N'{1}' ,gioiTinhNhanVien=N'{2}' ,cccdNhanVien = N'{3}',sdtNhanVien=N'{4}' ,emaiNhanVien=N'{5}' ,diaChiNhanVien= N'{6}' ,UserName=N'{7}' ,PassWordd=N'{8}' ,Typee={9} where idNhanVien='{10}'", tenNhanVien, ngaySinh, gioiTinh, canCuoc, sdt, email, diaChi, userName, password, typee, idNhanVien);


            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }



        public List<nhanVien> fildNhanVien(string manv,string tenNv)
        {
            List<nhanVien> list = new List<nhanVien>();

            string query = string.Format("select * from dbo.nhanVien where idNhanVien='{0}' or tenNhanVien like N'%{1}%'" , manv,tenNv);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                nhanVien nhanVien = new nhanVien(item);
                list.Add(nhanVien);
            }
            return list;
        }



    }
}
