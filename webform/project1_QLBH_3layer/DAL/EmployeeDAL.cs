using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class EmployeeDAL
    {
        // tạo singleton
        private static EmployeeDAL instance;
        public static EmployeeDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAL();
                return instance;
            }
            private set => instance = value;
        }
    }
}
