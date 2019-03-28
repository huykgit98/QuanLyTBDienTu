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
    public class BillBLL
    {
        // thêm khách hàng
        public int Insert(string id_cus,DateTime date_delivery, int total)
        {
            return DAL.BillDAL.Instance.Insert(id_cus,date_delivery,total);
        }

        // lấy toàn bộ dữ liệu hóa đơn
        public List<Bill> getAll()
        {
            return DAL.BillDAL.Instance.getAll();
        }

        // lấy ra thông tin hóa đơn vừa tạo
        public List<Bill> getByIdJustCreated()
        {
            return DAL.BillDAL.Instance.getByIdJustCreated();
        }

    }
}
