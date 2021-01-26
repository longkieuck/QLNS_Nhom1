using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.Models
{
    /// <summary>
    /// Lương 
    /// CreatedBy : NGuyễn Văn Hiến
    /// </summary>
    class Salary
    {
        // Mã lương
        public string SalaryId { get; set; }
        // Lương cơ bản 
        public float BaseSalary { get; set; }
        // Hệ số lương
        public float LevelSalary { get; set; }

        public Salary(string SalaryId)
        {
            this.SalaryId = SalaryId;
        }
        public Salary(DataRow row)
        {
            this.SalaryId = row["SalaryId"].ToString();
        }
    }


}
