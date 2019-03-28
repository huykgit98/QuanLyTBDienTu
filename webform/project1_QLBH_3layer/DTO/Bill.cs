using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Bill
    {
        private string id;
        private string id_cus;
        private DateTime date_order;
        private DateTime date_delivery;
        private int total;
        private int status;

        public string Id { get => id; set => id = value; }
        public string Id_cus { get => id_cus; set => id_cus = value; }
        public DateTime Date_order { get => date_order; set => date_order = value; }
        public DateTime Date_delivery { get => date_delivery; set => date_delivery = value; }
        public int Total { get => total; set => total = value; }
        public int Status { get => status; set => status = value; }

        public Bill(string id, string id_cus, DateTime date_order, DateTime date_delivery, int total, int status)
        {
            Id = id;
            Id_cus = id_cus;
            Date_order = date_order;
            Date_delivery = date_delivery;
            Total = total;
            Status = status;
        }

        public Bill(DataRow r)
        {
            Id = r["id"].ToString();
            Id_cus = r["id_cus"].ToString();
            Date_order = (DateTime)r["date_order"];
            Date_delivery = (DateTime)r["date_delivery"];
            Total = (int)r["total"];
            Status = (int)r["status"];
        }
    }
}
