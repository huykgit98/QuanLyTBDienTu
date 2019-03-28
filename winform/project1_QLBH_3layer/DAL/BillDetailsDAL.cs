using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class BillDetailsDAL
    {
 

        //huy
        public static DataTable LayDSCTHD(string soHD)
        {
            string sql = string.Format("select * from BillDetails where id_bill = '{0}'", soHD);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        public static DataTable LayDSCTHDTuMaHD(string maHD)
        {
            string sql = string.Format("select tb.name_pro as 'Tên TB', tb.price as 'Đơn Giá', ct.qty as 'Số Lượng', ct.discount as 'Chiết Khấu', ct.amount as 'Thành Tiền' from Product tb, BillDetails ct where tb.id = ct.id_pro and ct.id_bill = '{0}'", maHD);
            //string sql = string.Format("select  name_pro as 'Tên TB', price as 'Đơn Giá', qty as 'Số Lượng', discount as 'Chiết Khấu', ct.amount as 'Thành Tiền'  from BillDetails ct, Product tb where ct.id_pro = tb.id and ct.id_bill = {0} ", maHD);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }
        public static bool XoaCTHDTheoSoHD(string soHD)
        {
            bool kq;
            string sql = string.Format("delete BillDetails where id_bill = {0}", soHD);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool ThemChiTietHoaDon(BillDetails cthd)
        {
            bool kq;
            string sql = string.Format("insert into BillDetails values ({0}, {1}, {2}, {3}. {4}, {5})", cthd.Id_bill, cthd.Id_pro, cthd.Qty, cthd.Price, cthd.Discount, cthd.Amount);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }

        public static bool XoaCTHDTheoSoHDVaMaTB(string soHD, string maTB)
        {
            bool kq;
            string sql = string.Format("delete BillDetails where id_bill = {0} and id_pro = {1}", soHD, maTB);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
    }
}
