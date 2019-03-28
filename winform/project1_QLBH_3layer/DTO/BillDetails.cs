using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class BillDetails
    {
        private string id_bill;
        private string id_pro;
        private int qty;
        private int price;
        private int discount;
        private int amount;

        public string Id_bill { get => id_bill; set => id_bill = value; }
        public string Id_pro { get => id_pro; set => id_pro = value; }
        public int Qty { get => qty; set => qty = value; }
        public int Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Amount { get => amount; set => amount = value; }

        public BillDetails(string id_bill, string id_pro, int qty, int price, int discount, int amount)
        {
            Id_bill = id_bill;
            Id_pro = Id_pro;
            Qty = qty;
            Price = price;
            Discount = discount;
            Amount = amount;
        }

        public BillDetails(DataRow r)
        {
            Id_bill = r["id_bill"].ToString();
            Id_pro = r["id_pro"].ToString();
            Qty = (int)r["qty"];
            Price = (int)r["price"];
            Discount = (int)r["discount"];
            Amount = (int)r["amount"];
        }
    }
}
