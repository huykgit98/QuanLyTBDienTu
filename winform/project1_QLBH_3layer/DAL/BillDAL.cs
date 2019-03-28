using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class BillDAL
    {

        //huy
        public static DataTable LayDSHoaDon()
        {
            string sql = "select hd.id as 'Số HĐ', kh.name_cus as 'Tên KH',kh.address_cus as 'Địa Chỉ',kh.phone as 'SĐT', hd.date_delivery as 'Ngày Lập', hd.date_order as 'Ngày giao',  hd.total as 'Tổng Tiền' from Bill hd, Customer kh where hd.id_cus = kh.id";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            return dt;
        }

        //lấy mã hóa đơn tự động tăng
        public static string MaTuTang()
        {
            string sql = @"select * from Bill";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            string maTuTang = "";
            if (dt.Rows.Count <= 0)
            {
                maTuTang = "BL0001";
            }
            else
            {
                int k;
                maTuTang = "BL";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 4));
                k = k + 1;
                if (k < 10)
                { maTuTang = maTuTang + "000"; }
                else if (k < 100)
                { maTuTang = maTuTang + "00"; }
                else if (k < 1000)
                { maTuTang = maTuTang + "0"; }
                maTuTang = maTuTang + k.ToString();
            }
            return maTuTang;
        }

        public static string LaySoHoaDonTuMaKH(string maKH)
        {
            string soHD = "";
            string sql = "select * from Bill where id_cus = " + maKH;
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                soHD = dt.Rows[0]["id"].ToString();
            }
            return soHD;
        }
        public static bool XoaHDTheoSoHD(string soHD)
        {
            bool kq;
            string sql = string.Format("delete Bill where id = '{0}'", soHD);
            kq = SqlDataAccessHelper.ExecuteNonQuery(sql);
            return kq;
        }
        public static List<String> LayDSKHChuaThanhToan()
        {
            List<string> _ds = new List<string>();
            string sql = "select * from Bill";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maKH = dt.Rows[i]["id_cus"].ToString();
                _ds.Add(maKH);
            }
            return _ds;
        }

    }
}
