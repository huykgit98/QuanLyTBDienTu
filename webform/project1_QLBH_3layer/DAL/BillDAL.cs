using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class BillDAL
    {
        // tạo singleton
        private static BillDAL instance;
        public static BillDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAL();
                return instance;
            }
            private set => instance = value;
        }

        // lấy toàn bộ dữ liệu của hóa đơn
        public List<Bill> getAll()
        {
            List<Bill> l = new List<Bill>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill");
            foreach (DataRow r in data.Rows)
            {
                Bill b = new Bill(r);
                l.Add(b);
            }
            return l;
        }

        // thêm hóa đơn
        string id = null;
        public int Insert(string id_cus, DateTime date_delivery, int total)
        {
            id = DataProvider.Instance.AutoIncrement("SELECT * FROM Bill", "BL");
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO Bill(id,id_cus,date_order,date_delivery,total,status) " +
                            "VALUES ('"+id+"','"+id_cus+"','"+Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd")+"'," +
                            "'"+ Convert.ToDateTime(date_delivery).ToString("yyyy-MM-dd") + "','"+total+"','0')");
        }

        // lấy thông tin của khách hàng vừa tạo
        public List<Bill> getByIdJustCreated()
        {
            List<Bill> l = new List<Bill>();
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE id='" + id + "'");
            foreach (DataRow r in data.Rows)
            {
                Bill b = new Bill(r);
                l.Add(b);
            }
            return l;
        }

    }
}
