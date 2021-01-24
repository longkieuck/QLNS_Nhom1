using System;
using System.Collections.Generic;
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
    }
}
