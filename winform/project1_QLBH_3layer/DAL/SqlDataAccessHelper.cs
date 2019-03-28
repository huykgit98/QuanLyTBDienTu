using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SqlDataAccessHelper
    {//Chuỗi kết nối
        private static String _connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=demo_QLBH_3layer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //ExecuteQuery : Select
        public static DataTable ExecuteQuery(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }
        //ExecuteNonQuery: Insert, Update, Delete
        public static bool ExecuteNonQuery(String sql)
        {
            bool kq;
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            connect.Close();
            return kq;
        }

    }
}