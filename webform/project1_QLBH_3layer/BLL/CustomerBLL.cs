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
    public class CustomerBLL
    {
        // thêm khách hàng
        public int Insert(string name_cus, string address_cus, string phone)
        {
            return DAL.CustomerDAL.Instance.Insert(name_cus,address_cus,phone);
        }

        // lấy ra thông tin khách hàng vừa tạo
        public List<Customer> getByIdJustCreated()
        {
            return DAL.CustomerDAL.Instance.getByIdJustCreated();
        }

        // lấy thông tin của khách hàng theo id
    }
}
