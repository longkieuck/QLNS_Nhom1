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
    class DepartmentDAO
    {
        /// <summary>
        /// Tạo 1 design patter Singleton DepartmentDAO
        /// CreatedBy : Nguyễn Văn Hiến
        /// </summary>
        private static DepartmentDAO instance;
        public static DepartmentDAO Instance
        {
            get { if (instance == null) instance = new DepartmentDAO(); return DepartmentDAO.instance; }
            private set { DepartmentDAO.instance = value; }
        }
        private DepartmentDAO() { }


        /// <summary>
        /// Lấy danh sách các thông tin đầy đủ của các phòng ban
        /// </summary>
        /// CreatedBy : Nguyễn Văn Hiến 
        /// <returns> Danh sách phòng ban</returns>
        //public List<Department> GetDepartments()
        //{
        //    var departments = new List<Department>();
        //    IDbConnection dbConnection = new SqlConnection(connectionString);

        //    departments = dbConnection.Query<Department>("Select * from Department").ToList();

        //    return departments;
        //}
        public List<Department> GetDepartments()
        {
            List<Department> List = new List<Department>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Department");
            foreach (DataRow item in data.Rows)
            {
                Department department = new Department(item);
                List.Add(department);
            }
            return List;
        }
    }
}
