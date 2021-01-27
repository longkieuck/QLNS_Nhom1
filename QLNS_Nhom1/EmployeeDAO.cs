using QLNS_Nhom1.DataAcessLayer;
using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }

        private EmployeeDAO() { }

        /// <summary>
        /// lay ra danh sach nhan vien
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetListEmployee()
        {
            List<Employee> list = new List<Employee>();

            string query = "select * from Employee";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Employee food = new Employee(item);
                list.Add(food);
            }

            return list;
        }

        /// <summary>
        /// lay ds ma phong ban
        /// created by dat
        /// </summary>
        /// <returns></returns>
        public List<Department> GetListDepartmentId()
        {
            List<Department> List = new List<Department>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT DepartmentId FROM Department");
            foreach (DataRow item in data.Rows)
            {
                Department DepartmentId = new Department(item);
                List.Add(DepartmentId);
            }
            return List;
        }

        /// <summary>
        /// lay ds ma chuc vu
        /// created by dat
        /// </summary>
        /// <returns></returns>
        public List<Position> GetListPositiontId()
        {
            List<Position> List = new List<Position>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT PositionId FROM Position");
            foreach (DataRow item in data.Rows)
            {
                Position PositiontId = new Position(item);
                List.Add(PositiontId);
            }
            return List;
        }

        /// <summary>
        /// lay ds ma luong
        /// created by dat
        /// </summary>
        /// <returns></returns>
        public List<Salary> GetListSalaryId()
        {
            List<Salary> List = new List<Salary>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT SalaryId FROM Salary");
            foreach (DataRow item in data.Rows)
            {
                Salary SalaryId = new Salary(item);
                List.Add(SalaryId);
            }
            return List;
        }
    }
}
