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
        // tạo singleton
        private static ProductDAL instance;
        public static ProductDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAL();
                return instance;
            }
            private set => instance = value;
        }

        // lấy toàn bộ dữ liệu
        public List<Product> getAll()
        {
            List<Product> l = new List<Product>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Product");
            foreach (DataRow cate in data.Rows)
            {
                Product c = new Product(cate);
                l.Add(c);
            }
            return l;
        }

        // lấy toàn bộ thông tin theo tên thiết bị và id_cate của loại thiết bị
        public List<Product> getByNameAndIdCate(string name_pro,string id_cate)
        {
            List<Product> l = new List<Product>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Product WHERE name_pro LIKE '%"+name_pro+"%' AND id_cate='" + id_cate + "'");
            foreach (DataRow cate in data.Rows)
            {
                Product c = new Product(cate);
                l.Add(c);
            }
            return l;
        }

        // lấy toàn bộ thông tin theo id của chính nó
        public List<Product> getById(string id)
        {
            List<Product> l = new List<Product>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Product WHERE id='" + id + "'");
            foreach (DataRow cate in data.Rows)
            {
                Product c = new Product(cate);
                l.Add(c);
            }
            return l;
        }
    }
}
