using Dapper;
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
    class SalaryDAO
    {
        /// <summary>
        /// Tạo 1 design patter Singleton SalaryDAO
        /// CreatedBy : Nguyễn Văn Hiến
        /// </summary>
        private static SalaryDAO instance;
        public static SalaryDAO Instance
        {
            get { if (instance == null) instance = new SalaryDAO(); return SalaryDAO.instance; }
            private set { SalaryDAO.instance = value; }
        }
        private SalaryDAO() { }

        private string connectionString = "Server=DESKTOP-6N6LFDC\\SQLEXPRESS;Database=QLNS;User ID=nhom1;pwd=nhom1";

        /// <summary>
        /// Lấy danh sách các thông tin đầy đủ của các kiểu lương :mã lương, lương cơ bản , hệ số 
        /// </summary>
        /// CreatedBy : Nguyễn Văn Hiến 
        /// <returns> Danh sách các loại lương</returns>
        public List<Salary> GetSalaries()
        {
            var salaries = new List<Salary>();
            IDbConnection dbConnection = new SqlConnection(connectionString);

            salaries = dbConnection.Query<Salary>("Select * from Salary").ToList();

            return salaries;
        }
    }
}
