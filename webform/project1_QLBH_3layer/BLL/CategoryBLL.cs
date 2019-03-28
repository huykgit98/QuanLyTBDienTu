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
        // lấy toàn bộ dữ liệu
        public List<Category> getAll()
        {
            return DAL.CategoryDAL.Instance.getAll();
        }

        // lấy toàn bộ thông tin theo id
        public List<Category> getById(string id)
        {
            return DAL.CategoryDAL.Instance.getById(id);
        }
    }
}
