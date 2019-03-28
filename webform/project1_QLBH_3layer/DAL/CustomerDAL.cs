using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class CustomerDAL
    {
        // tạo singleton
        private static CustomerDAL instance;
        public static CustomerDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAL();
                return instance;
            }
            private set => instance = value;
        }

        // thêm khách hàng
        string id = null;
        public int Insert(string name_cus, string address_cus, string phone)
        {
            id = DataProvider.Instance.AutoIncrement("SELECT * FROM Customer","KH");
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO Customer(id,name_cus,address_cus,phone) " +
                                                         "VALUES ('"+id+"','"+name_cus+"','"+address_cus+"','"+phone+"')");
        }

        // lấy thông tin của khách hàng vừa tạo
        public List<Customer> getByIdJustCreated()
        {
            List<Customer> l = new List<Customer>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Customer WHERE id='" + id + "'");
            foreach(DataRow r in data.Rows)
            {
                Customer c = new Customer(r);
                l.Add(c);
            }
            return l;
        }

    }
}
