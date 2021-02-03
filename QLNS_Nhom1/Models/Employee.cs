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
        public Employee() { }

        public Employee(int id, string name, string gender, string phonenumber, string address, DateTime dateofbirth, string positionid,
            string departmentid, string salaryid)
        {
            this.Id = id;
            this.FullName = name;
            this.Gender = gender;
            this.PhoneNumber = phonenumber;
            this.Address = address;
            this.DateOfBirth = dateofbirth;
            this.PositionId = positionid;
            this.DepartmentId = departmentid;
            this.SalaryId = salaryid;
        }
        public Employee(DataRow dataRow)
        {
            this.Id = (int)dataRow["Id"];
            this.FullName = dataRow["FullName"].ToString();
            this.Gender = dataRow["Gender"].ToString();
            this.PhoneNumber = dataRow["PhoneNumber"].ToString();
            this.Address = dataRow["Address"].ToString();
            this.DateOfBirth = DateTime.Parse(dataRow["DateOfBirth"].ToString());
            this.PositionId = dataRow["PositionId"].ToString();
            this.DepartmentId = dataRow["DepartmentId"].ToString();
            this.SalaryId = dataRow["SalaryId"].ToString();
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

