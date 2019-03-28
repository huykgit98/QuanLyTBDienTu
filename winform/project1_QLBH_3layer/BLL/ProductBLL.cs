using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class ProductBLL
    {
        

        //huy
        public static bool ThemThietBi(Product tb)
        {
            bool kq = ProductDAL.ThemThietBi(tb);
            return kq;
        }
        public static bool XoaThietBiTheoMaTB(string maTB)
        {
            bool kq = ProductDAL.XoaThietBiTheoMaTB(maTB);
            return kq;
        }

        public static bool CapNhatThietBi(Product tb)
        {
            bool kq = ProductDAL.CapNhatThietBi(tb);
            return kq;
        }

        public static List<Product> LayDSThietBi()
        {
            List<Product> _ds;
            _ds = ProductDAL.LayDSThietBi();
            return _ds;
        }

        public static List<Product> LayDSThietBiTheoMaLoai(string maLoai)
        {
            List<Product> _ds;
            _ds = ProductDAL.LayDSThietBiTheoMaLoai(maLoai);
            return _ds;
        }

        public static List<Product> LayDSMaTBVaTenTBTheoMaLoai(string maLoai)
        {
            List<Product> dsTB = ProductDAL.LayDSMaTBVaTenTBTheoMaLoai(maLoai);
            return dsTB;
        }

        public static DataTable LayDanhSachTBTheoMaLoai(string maLoai)
        {
            DataTable dt = ProductDAL.LayDanhSachTBTheoMaLoai(maLoai);
            return dt;
        }
        public static DataTable LayDanhSachTB()
        {
            DataTable dt = ProductDAL.LayDanhSachTB();
            return dt;
        }
        public static string MaTuTang()
        {
            string ma = ProductDAL.MaTuTang();
            return ma;
        }

        public static bool KiemTraTrungTenThietBi(string tenTB)
        {
            bool kq = ProductDAL.KiemTraTrungTenThietBi(tenTB);
            return kq;
        }

        public static bool KiemTraTenTBCapNhat(string tenTB, string maTB)
        {
            bool kq = ProductDAL.KiemTraTenTBCapNhat(tenTB, maTB);
            return kq;
        }

        public static DataTable TraCuuThietBiTheoTen(string tenTB)
        {
            DataTable kq = ProductDAL.TraCuuThietBiTheoTen(tenTB);
            return kq;
        }

    }
}