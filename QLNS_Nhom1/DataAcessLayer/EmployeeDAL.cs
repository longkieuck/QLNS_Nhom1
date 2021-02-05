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
            if (id.CompareTo("Tất Cả") == 0)
            {
                string query = string.Format("select * from Employee");
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Employee employee = new Employee(item);
                    list.Add(employee);
                }
            }
            else
            {
                string query = string.Format("select * from Employee where DepartmentId = '{0}'", id);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Employee employee = new Employee(item);
                    list.Add(employee);
                }

            }
            return list;
        }

        public List<Employee> SearchEmployeeByName(string name, string department)
        {
            List<Employee> list = new List<Employee>();
            if(department.CompareTo("Tất Cả") == 0)
            {
                string query = string.Format("select * from Employee where [dbo].[GetUnsignString](FullName) like N'%' + [dbo].[GetUnsignString](N'{0}') + '%'", name);

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    Employee employee = new Employee(item);
                    list.Add(employee);
                }
            }
            else
            {
                string query = string.Format("exec GetEmployeeListByName @name , @department");

                DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name, department });

                foreach (DataRow item in data.Rows)
                {
                    Employee employee = new Employee(item);
                    list.Add(employee);
                }
            }

            return list;
        }

    }
}
