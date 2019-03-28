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
    public class CategoryBLL
    {
       
        //// huy
        public static string LayMaLoaiTuTenLoai(string tenLoai)
        {
            string maLoai = CategoryDAL.LayMaLoaiTuTenLoai(tenLoai);
            return maLoai;
        }

        public static List<Category> LayDSLoaiThietBi()
        {
            List<Category> _ds;
            _ds = CategoryDAL.LayDSLoaiThietBi();
            return _ds;
        }
    }
}
