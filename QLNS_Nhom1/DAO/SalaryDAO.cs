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
        /// <summary>
        /// Lấy danh sách các thông tin đầy đủ của các kiểu lương :mã lương, lương cơ bản , hệ số 
        /// </summary>
        /// CreatedBy : Nguyễn Văn Hiến 
        /// <returns> Danh sách các loại lương</returns>
        public List<Salary> GetSalaries()
        {
            List<Salary> List = new List<Salary>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Salary");
            foreach (DataRow item in data.Rows)
            {
                Salary salary = new Salary(item);
                List.Add(salary);
            }
            return List;
        }
    }
}
