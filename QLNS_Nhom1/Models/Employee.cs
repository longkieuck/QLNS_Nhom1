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
        public Employee()
        {

        }
        public Employee(DataRow row)
        {
            this.Id = Int32.Parse(row["Id"].ToString());
            this.FullName = row["FullName"].ToString();
            this.Gender = row["Gender"].ToString();
            this.PhoneNumber = row["PhoneNumber"].ToString();
            this.Address = row["Address"].ToString();
            this.DateOfBirth = DateTime.Parse(row["DateOfBirth"].ToString());
            this.PositionId = row["PositionId"].ToString();
            this.DepartmentId = row["DepartmentId"].ToString();
            this.SalaryId = row["SalaryId"].ToString();
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
