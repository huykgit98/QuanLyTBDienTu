using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DTO;

namespace DAL
{
    public class DataProvider
    {
        // tạo singleton
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set => instance = value;
        }

        // chuỗi kết nối
        private string connString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        // trả về số nguyên 
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }

        // trả về dạng bảng
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        // tạo mã tự động
        public string AutoIncrement(string query, string keyword)
        {
            DataTable data = new DataTable();
            data = ExecuteQuery(query);
            if (data.Rows.Count < 1)
                keyword += "0001";
            else
            {
                int k = Convert.ToInt32(data.Rows[data.Rows.Count - 1][0].ToString().Substring(2, 4)) + 1;
                if (k < 10)
                    keyword += "000";
                else if (k < 100)
                    keyword += "00";
                else if (k < 1000)
                    keyword += "0";
                keyword += k.ToString();
            }
            return keyword;
        }

    }
}
