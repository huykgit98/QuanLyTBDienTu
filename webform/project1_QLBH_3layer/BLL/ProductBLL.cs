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
    public class ProductBLL
    {
        // lấy toàn bộ dữ liệu
        public List<Product> getAll()
        {
            return DAL.ProductDAL.Instance.getAll();
        }

        // lấy toàn bộ thông tin theo id của loại thiết bị
        public List<Product> getByNameAndIdCate(string name_pro, string id_cate)
        {
            return DAL.ProductDAL.Instance.getByNameAndIdCate(name_pro,id_cate);
        }
        
        // lấy toàn bộ thông tin theo id của chính nó
        public List<Product> getById(string id)
        {
            return DAL.ProductDAL.Instance.getById(id);
        }
    }
}
