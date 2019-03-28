using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Customer
    {
        private string id;
        private string name_cus;
        private string address_cus;
        private string phone;

        public string Id { get => id; set => id = value; }
        public string Name_cus { get => name_cus; set => name_cus = value; }
        public string Address_cus { get => address_cus; set => address_cus = value; }
        public string Phone { get => phone; set => phone = value; }

        public Customer(string id, string name_cus, string address_cus, string phone)
        {
            Id = id;
            Name_cus = name_cus;
            Address_cus = address_cus;
            Phone = phone;
        }

        public Customer(DataRow r)
        {
            Id = r["id"].ToString();
            Name_cus = r["name_cus"].ToString();
            Address_cus = r["address_cus"].ToString();
            Phone = r["phone"].ToString();
        }
    }
}
