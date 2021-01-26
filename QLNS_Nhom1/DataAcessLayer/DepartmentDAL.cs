using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.DataAcessLayer
{
    //Created by Bui Thi My Van
    class DepartmentDAL
    {
        private static DepartmentDAL instance;

        public static DepartmentDAL Instance
        {
            get { if (instance == null) instance = new DepartmentDAL(); return DepartmentDAL.instance; }
            private set { DepartmentDAL.instance = value; }
        }

        private DepartmentDAL() { }

        public List<Department> GetListDepartment()
        {
            List<Department> list = new List<Department>();

            string query = "select * from Department";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Department department = new Department(item);
                list.Add(department);
            }

            return list;
        }
    }
}
