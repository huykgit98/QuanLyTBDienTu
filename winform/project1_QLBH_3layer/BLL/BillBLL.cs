using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class BillBLL
    {
        
    
        //huy
        public static DataTable LayDSHoaDon()
        {
            DataTable _ds = BillDAL.LayDSHoaDon();
            return _ds;
        }

        public static string LaySoHDTuMaKH(string maKH)
        {
            string soHD = BillDAL.LaySoHoaDonTuMaKH(maKH);
            return soHD;
        }
        public static List<string> LayDSKHChuaThanhToan()
        {
            List<string> _ds = BillDAL.LayDSKHChuaThanhToan();
            return _ds;
        }
        public static bool XoaHDTheoSoHD(string SoHD)
        {
            bool kq = BillDAL.XoaHDTheoSoHD(SoHD);
            return kq;
        }


    }
}
