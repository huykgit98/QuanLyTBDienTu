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
        // tạo singleton
        private static CategoryDAL instance;
        public static CategoryDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAL();
                return instance;
            }
            private set => instance = value;
        }

        // lấy toàn bộ dữ liệu
        public List<Category> getAll()
        {
            List<Category> l = new List<Category>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Category");
            foreach(DataRow cate in data.Rows)
            {
                Category c = new Category(cate);
                l.Add(c);
            }
            return l;
        }

        // lấy toàn bộ thông tin theo id
        public List<Category> getById(string id)
        {
            List<Category> l = new List<Category>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Category WHERE id='"+id+"'");
            foreach (DataRow cate in data.Rows)
            {
                Category c = new Category(cate);
                l.Add(c);
            }
            return l;
        }

    }
}
