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
    public class BillDetailsBLL
    {
        // thêm chi tiết hóa đơn
        public int Insert(string id_bill, string id_pro,int qty_pro, int qty, int price, int discount, int amount)
        {
            return DAL.BillDetailsDAL.Instance.Insert(id_bill, id_pro, qty_pro, qty, price, discount, amount);
        }

        // lấy thông tin của chi tiết hóa đơn
        public List<BillDetails> getByIdBill(string id_bill)
        {
            return DAL.BillDetailsDAL.Instance.getByIdBill(id_bill);
        }
    }
}
