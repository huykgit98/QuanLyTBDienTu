using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Product
    {
        private string id;
        private string id_cate;
        private string name_pro;
        private int qty;
        private int price;

        public string Id { get => id; set => id = value; }
        public string Id_cate { get => id_cate; set => id_cate = value; }
        public string Name_pro { get => name_pro; set => name_pro = value; }
        public int Qty { get => qty; set => qty = value; }
        public int Price { get => price; set => price = value; }
    
        public Product(string id, string id_cate, string name_pro, int qty, int price)
        {
            Id = id;
            Id_cate = id_cate;
            Name_pro = name_pro;
            Qty = qty;
            Price = price;
        }

        public Product(DataRow r)
        {
            Id = r["id"].ToString();
            Id_cate = r["id_cate"].ToString();
            Name_pro = r["name_pro"].ToString();
            Qty = (int)r["qty"];
            Price = (int)r["price"];
        }
    }
}
