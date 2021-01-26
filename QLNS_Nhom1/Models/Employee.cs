using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.Models
{
    /// <summary>
    /// Nhân Viên
    /// CreatedBy : Nguyễn Văn Hiến
    /// </summary>
    class Employee
    {
        private DataRow dataRow;
        public Employee()
        {

        }
        public Employee(DataRow dataRow)
        {
            this.dataRow = dataRow;
        }
        // Mã Nhân viên 
        public int Id { get; set; }
        // Tên 
        public string FullName { get; set; }
        // Giới tính
        public string Gender { get; set; }
        // Số điện thoại 
        public string PhoneNumber { get; set; }
        // Địa chỉ 
        public string Address { get; set; }
        // Ngày sinh
        public DateTime DateOfBirth { get; set; }
        // chức vụ
        public string PositionId { get; set; }
        // Mã phòng ban 
        public string DepartmentId { get; set; }
        // Mã lương 
        public string SalaryId { get; set; }
    }

}
