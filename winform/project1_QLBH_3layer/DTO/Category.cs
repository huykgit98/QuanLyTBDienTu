using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Category
    {
        private string id;
        private string name_cate;

        public string Id { get => id; set => id = value; }
        public string Name_cate { get => name_cate; set => name_cate = value; }

        public Category(string id, string name_cate)
        {
            Id = id;
            Name_cate = name_cate;
        }

        public Category(DataRow r)
        {
            Id = r["id"].ToString();
            Name_cate = r["name_cate"].ToString();
        }

        public Category()
        {
        }
    }
}
