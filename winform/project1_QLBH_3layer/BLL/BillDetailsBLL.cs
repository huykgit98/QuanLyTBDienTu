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
    public class BillDetailsBLL
    {
        
        //huy
        public static bool ThemChiTietHoaDon(BillDetails cthd)
        {
            bool kq = BillDetailsDAL.ThemChiTietHoaDon(cthd);
            return kq;
        }
        public static bool XoaCTHDTheoSoHD(string soHD)
        {
            bool kq = BillDetailsDAL.XoaCTHDTheoSoHD(soHD);
            return kq;
        }
        public static bool XoaCTHDTheoSoHDVaMaTD(string soHD, string MaTB)
        {
            bool kq = BillDetailsDAL.XoaCTHDTheoSoHDVaMaTB(soHD, MaTB);
            return kq;
        }
        public static DataTable LayDSCTHDTuMaHD(string maHD)
        {
            DataTable _ds = BillDetailsDAL.LayDSCTHDTuMaHD(maHD);
            return _ds;
        }
        public static DataTable LayDSCTHD(string SoHD)
        {
            DataTable dt = BillDetailsDAL.LayDSCTHD(SoHD);
            return dt;
        }
    }
}
