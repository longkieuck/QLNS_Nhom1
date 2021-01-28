using Dapper;
using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_Nhom1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
<<<<<<< HEAD
            //var connectionString = "Server = DESKTOP-6N6LFDC\\SQLEXPRESS;Database=QLNS;User ID=nhom1;pwd=nhom1";
            //IDbConnection dbConnection = new SqlConnection(connectionString);
=======
            var connectionString = "Server=DESKTOP-0L1VLRS\\SQLEXPRESS01;Database=QLNS;User ID=nhom1;pwd=nhom1";
            IDbConnection dbConnection = new SqlConnection(connectionString);

            // Khởi tạo commadText
            //var customers = dbConnection.Query<Employee>("Select * From [Employee]");
>>>>>>> origin/thiep

            //// Khởi tạo commadText
            //var customers = dbConnection.Query<Employee>("Select * From [Employee]");
            // Trả về dữ liệu 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            //Application.Run(new fMain());
            Application.Run(new fCreateEmployee());
=======
            Application.Run(new fLogin());
>>>>>>> origin/thiep
        }
    }
}
