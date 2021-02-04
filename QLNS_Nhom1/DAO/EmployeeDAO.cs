using Dapper;
using QLNS_Nhom1.DataAcessLayer;
using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.DAO
{
    /// <summary>
    /// DAO : Data Access Object Employee
    /// </summary>
    class EmployeeDAO
    {

        /// <summary>
        /// Tạo 1 design patter Singleton EmployeeDAO
        /// CreatedBy : Nguyễn Văn Hiến
        /// </summary>
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; } 
        }
        private EmployeeDAO() { }

        /// <summary>
        /// Lấy Danh sách nhân viên từ DB
        /// </summary>
        /// CreatedBy : Nguyễn Văn Hiến 
        /// <returns> Danh sách nhân viên</returns>
        public List<Employee> GetListEmployee()
        {
            List<Employee> list = new List<Employee>();

            string query = "select * from Employee";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                list.Add(employee);
            }
            return list;
        }

        /// <summary>
        /// Thêm nhân viên .
        /// 
        /// </summary>
        /// <param name="employee">Đối tượng nhân viên cần thêm</param>
        /// CreatedBy : Nguyễn Văn Hiến
        /// <returns>true or false : ứng với sự thay đổi số hàng có lớn 0 hay là không lớn hơn 0</returns>
        public bool InsertEmployee(Employee employee)
        {
            string query = string.Format("EXEC InsertEmployee @name , @gender , @phoneNumber , @address , @dateOfBrith ," +
                " @positionId , @departmentId , @salaryId ");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {employee.FullName,
                employee.Gender,employee.PhoneNumber,employee.Address,employee.DateOfBirth,employee.PositionId,employee.DepartmentId,employee.SalaryId});
            return result > 0;
        }
        

        public bool UpdateNv(Employee employee)
        {
            string query = string.Format(" EXEC UpdateEmployee @FullName , @DateOfBirth , @Address " +
                ", @Gender , @PhoneNumber , @SalaryId , @DepartmentId , @PositionId , @Id ");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { employee.FullName, employee.DateOfBirth, employee.Address,
                employee.Gender, employee.PhoneNumber, employee.SalaryId, employee.DepartmentId, employee.PositionId, employee.Id });

            return result > 0;
        }

        

    }
}
