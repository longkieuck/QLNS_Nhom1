using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.DataAcessLayer
{
    class EmployeeDAL
    {
        private static EmployeeDAL instance;

        public static EmployeeDAL Instance
        {
            get { if (instance == null) instance = new EmployeeDAL(); return EmployeeDAL.instance; }
            private set { EmployeeDAL.instance = value; }
        }

        private EmployeeDAL() { }

        public List<Employee> GetEmployeeByDepartmentID(string id)
        {
            List<Employee> list = new List<Employee>();
            string query = "select * from Employee where DepartmentId = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                list.Add(employee);
            }
            return list;
        }

    }
}
