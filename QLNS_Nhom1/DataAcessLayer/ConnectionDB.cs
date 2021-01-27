using Dapper;
using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.DataAcessLayer
{
    class ConnectionDB
    {
        /// <summary>
        /// Lấy Dữ liệu Bảng Employee 
        /// </summary>
        /// CreatedBy : Nguyễn Văn Hiến 
        /// <returns> Danh Sách Nhân Viên(Employee)</returns>
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            using(IDbConnection dbConnection = new SqlConnection())
            {
                employees = dbConnection.Query<Employee>("").ToList();
            }
            return employees;
        }




    }
}
