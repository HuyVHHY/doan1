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
    public class sanPhamDAO
    {

        private static sanPhamDAO instance; // Ctrl + R + E

        public static sanPhamDAO Instance
        {
            get { if (instance == null) instance = new sanPhamDAO(); return sanPhamDAO.instance; }
            private set { sanPhamDAO.instance = value; }
        }



        public List<sanPham> DsSanPham()
        {
            List<sanPham> list = new List<sanPham>();

            string query = "select * from dbo.sanPham ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanPham ds = new sanPham(item);
                list.Add(ds);
            }
            return list;
        }

        public List<sanPham> find(string id, string name)
        {
            List<sanPham> list = new List<sanPham>();

            string query = string.Format("select * from dbo.sanPham where idSanPham ='{0}' or tenSanPham like N'%{1}%'", id, name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                sanPham ds = new sanPham(item);
                list.Add(ds);
            }
            return list;
        }




        public bool kiemtraMa(string id)
        {
            string query = string.Format("select * from dbo.sanPham where idSanPham ='{0}'", id);

            int result = DataProvider.Instance.KiemTraMa(query);

            return result <= 0;
        }


        public bool xoa(string id)
        {
            string query = string.Format("delete from dbo.sanPham where idSanPham ='{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }



        public bool them(string id,  string ten,  string loai,  string thuongHieu,  string moTa, string giaBan)
        {
            string query = string.Format("insert into dbo.sanPham(idSanPham,tenSanPham,loaiSanPham,thuongHieu,moTa,giaBan,soLuong)values('{0}',N'{1}' , N'{2}',N'{3}' ,N'{4}',{5} ,0)", id, ten, loai, thuongHieu,  moTa, giaBan);



            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool sua(string id, string ten, string loai, string thuongHieu, string moTa, string giaBan)
        {
            string query = string.Format("UPDATE dbo.sanPham set tenSanPham =N'{1}' ,loaiSanPham =N'{2}',thuongHieu=N'{3}' ,moTa=N'{4}' ,giaBan={5}  where  idSanPham='{0}'", id, ten, loai, thuongHieu, moTa, giaBan);
           
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }



    }
}
