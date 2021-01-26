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

        private string connectionString = "Server=DESKTOP-6N6LFDC\\SQLEXPRESS;Database=QLNS;User ID=nhom1;pwd=nhom1";

        /// <summary>
        /// Lấy danh sách các thông tin đầy đủ của các phòng ban
        /// </summary>
        /// CreatedBy : Nguyễn Văn Hiến 
        /// <returns> Danh sách phòng ban</returns>
        public List<Department> GetDepartments()
        {
            var departments = new List<Department>();
            IDbConnection dbConnection = new SqlConnection(connectionString);

            departments = dbConnection.Query<Department>("Select * from Department").ToList();

            return departments;
        }
    }
}
