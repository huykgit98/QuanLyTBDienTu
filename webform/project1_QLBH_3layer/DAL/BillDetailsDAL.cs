using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class BillDetailsDAL
    {
        // tạo singleton
        private static BillDetailsDAL instance;
        public static BillDetailsDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDetailsDAL();
                return instance;
            }
            private set => instance = value;
        }

        // thêm chi tiết hóa đơn
        public int Insert(string id_bill, string id_pro, int qty_pro, int qty, int price, int discount, int amount)
        {
            // tính lại số lượng tồn
            string query1 = "UPDATE Product SET qty='"+(qty_pro-qty)+"' WHERE id='"+id_pro+"'";
            DataProvider.Instance.ExecuteNonQuery(query1);
            // tạo hóa đơn
            string query2 = "INSERT INTO BillDetails(id_bill,id_pro,qty,price,discount,amount) " +
                           "VALUES('"+id_bill+"','"+id_pro+"','"+qty+"','"+price+"','"+discount+"','"+amount+"')";
            return DataProvider.Instance.ExecuteNonQuery(query2);
        }

        // lấy thông tin của khách hàng vừa tạo
        public List<BillDetails> getByIdBill(string id_bill)
        {
            List<BillDetails> l = new List<BillDetails>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BillDetails WHERE id_bill='" + id_bill + "'");
            foreach (DataRow r in data.Rows)
            {
                BillDetails b = new BillDetails(r);
                l.Add(b);
            }
            return l;
        }

    }
}
