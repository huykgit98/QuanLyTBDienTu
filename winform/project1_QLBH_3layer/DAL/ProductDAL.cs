using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class ProductDAL
    {

        


        //// huy
        //// lấy danh sách thiết bị
        //Rút trích dữ liêu: select 
        public static List<Product> LayDSThietBi()
        {
            List<Product> _ds = new List<Product>();
            string sql = "select * from Product";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Product td = new Product();
                td.Id = dt.Rows[i]["id"].ToString();
                td.Id_cate = dt.Rows[i]["id_cate"].ToString();
                td.Name_pro = dt.Rows[i]["name_pro"].ToString();
                td.Qty = int.Parse(dt.Rows[i]["qty"].ToString());
                td.Price = int.Parse(dt.Rows[i]["price"].ToString());
                _ds.Add(td);
            }
            return _ds;
        }

        public static List<Product> LayDSThietBiTheoMaLoai(string maLoai)
        {
            List<Product> _ds = new List<Product>();
            string sql = "select * from Product where id_cate = " + maLoai;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Product td = new Product();
                td.Id = dt.Rows[i]["id"].ToString();
                td.Id_cate = dt.Rows[i]["id_cate"].ToString();
                td.Name_pro = dt.Rows[i]["name_pro"].ToString();
                td.Qty = int.Parse(dt.Rows[i]["qty"].ToString());
                td.Price = int.Parse(dt.Rows[i]["price"].ToString());
                _ds.Add(td);
            }
            return _ds;
        }

        public static List<Product> LayDSMaTBVaTenTBTheoMaLoai(string maLoai)
        {
            List<Product> ds = new List<Product>();
            string sql = "select * from Product where id_cate = " + maLoai;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Product td = new Product();
                td.Id = dt.Rows[i]["id"].ToString();
                td.Name_pro = dt.Rows[i]["name_pro"].ToString();
                ds.Add(td);
            }
            return ds;
        }

        public static DataTable LayDanhSachTBTheoMaLoai(string maLoai)
        {
            string sql = string.Format("select tb.id as 'Mã TB', tb.name_pro as 'Tên Thiết Bị', tb.Price as 'Đơn Giá', tb.qty as 'Số Lượng', c.name_cate as 'Loại TB' from Product tb, Category c where tb.id_cate = c.id and tb.id_cate = '{0}'", maLoai);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
        //lay dstb
        public static DataTable LayDanhSachTB()
        {
            string sql = "select tb.id as 'Mã TB', tb.name_pro as 'Tên Thiết Bị', tb.Price as 'Đơn Giá', tb.qty as 'Số Lượng', c.name_cate as 'Loại TB' from Product tb, Category c where tb.id_cate = c.id";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
        //lay ma tu dong tang
        public static string MaTuTang()
        {
            string sql = @"select * from Product";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            string maTuTang ="";
            if(dt.Rows.Count <= 0)
            {
                maTuTang = "PD0001";
            }
            else
            {
                int k;
                maTuTang = "PD";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 4));
                k = k + 1;
                if(k<10)
                { maTuTang = maTuTang + "000"; }
                else if(k<100)
                { maTuTang = maTuTang + "00"; }
                else if(k<1000)
                { maTuTang = maTuTang + "0"; }
                maTuTang = maTuTang + k.ToString();
            }
            return maTuTang;
        }
        public static bool KiemTraTrungTenThietBi(string tenTB)
        {
            bool kq;
            string sql = "select * from Product where name_pro = N'" + tenTB + "'";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = false;
            else
                kq = true;
            return kq;
        }

        public static bool ThemThietBi(Product tb)
        {
            string sql = string.Format("insert into Product (id, id_cate, name_pro, qty, price) values ('{0}', '{1}', '{2}', {3}, {4})", tb.Id, tb.Id_cate, tb.Name_pro, tb.Qty, tb.Price);
            bool kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool XoaThietBiTheoMaTB(string maTB)
        {
            string sql = string.Format("delete Product where id ='{0}'", maTB);
            bool kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool CapNhatThietBi(Product tb)
        {
            string sql = string.Format("update Product set id_cate = '{0}', name_pro = N'{1}', qty = {2}, price = {3} where id = '{4}'", tb.Id_cate, tb.Name_pro, tb.Qty, tb.Price, tb.Id);
            bool kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool KiemTraTenTBCapNhat(string tenTB, string maTB)
        {
            bool kq;
            string sql = string.Format("select * from Product where name_pro = N'{0}' and id = '{1}'", tenTB, maTB);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                kq = false;
            else
                kq = true;
            return kq;
        }
        public static DataTable TraCuuThietBiTheoTen(string tenTB)
        {
            string sql = string.Format("select tb.id as 'Mã TB', tb.name_pro as 'Tên Thiết Bị', tb.Price as 'Đơn Giá', tb.qty as 'Số Lượng', c.name_cate as 'Loại TB' from Product tb, Category c where tb.name_pro like N'%{0}%' and tb.id_cate = c.id", tenTB);
            DataTable kq = SqlDataAccessHelper.ExecuteQuery(sql);
            return kq;
        }

    }
}
