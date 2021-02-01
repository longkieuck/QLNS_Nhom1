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
    class PositonDAO
    {
        /// <summary>
        /// Tạo 1 design patter Singleton PositonDAO
        /// CreatedBy : Nguyễn Văn Hiến
        /// </summary>
        private static PositonDAO instance;
        public static PositonDAO Instance
        {
            get { if (instance == null) instance = new PositonDAO(); return PositonDAO.instance; }
            private set { PositonDAO.instance = value; }
        }
        private PositonDAO() { }

        private string connectionString = "Server=DESKTOP-6N6LFDC\\SQLEXPRESS;Database=QLNS;User ID=nhom1;pwd=nhom1";

        /// <summary>
        /// Lấy danh sách các thông tin đầy đủ của các chức vụ
        /// </summary>
        /// CreatedBy : Nguyễn Văn Hiến 
        /// <returns> Danh sách chức vụ</returns>
        public List<Position> GetPositions()
        {
            var positions = new List<Position>();
            IDbConnection dbConnection = new SqlConnection(connectionString);

            positions = dbConnection.Query<Position>("Select * from Position").ToList();

            return positions;
        }
    }
}
