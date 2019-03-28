using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class CategoryDAL
    {
       
        //// huy
        public static string LayMaLoaiTuTenLoai(string tenLoai)
        {
            string maLoai;
            string sql = string.Format("select id from Category where name_cate = N'{0}'", tenLoai);
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                maLoai = (dt.Rows[0]["id"].ToString());
            else
                return "";
            return maLoai;
        }
        public static List<Category> LayDSLoaiThietBi()
        {
            List<Category> _ds = new List<Category>();
            string sql = "select * from Category";
            DataTable dt = SqlDataAccessHelper.ExecuteQuery(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Category loai = new Category();
                loai.Id = dt.Rows[i]["id"].ToString();
                loai.Name_cate = dt.Rows[i]["name_cate"].ToString();
                _ds.Add(loai);
            }
            return _ds;
        }
    }
}
