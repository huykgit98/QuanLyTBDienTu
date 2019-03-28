using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Employee
    {
        private string id;
        private string name_emp;
        private string address_emp;
        private string phone;

        public string Id { get => id; set => id = value; }
        public string Name_emp { get => name_emp; set => name_emp = value; }
        public string Address_emp { get => address_emp; set => address_emp = value; }
        public string Phone { get => phone; set => phone = value; }

        public Employee(string id, string name_emp, string address_emp, string phone)
        {
            Id = id;
            Name_emp = name_emp;
            Address_emp = address_emp;
            Phone = phone;
        }

        public Employee(DataRow r)
        {
            Id = r["id"].ToString();
            Name_emp = r["name_emp"].ToString();
            Address_emp = r["address_emp"].ToString();
            Phone = r["phone"].ToString();
        }
    }
}
