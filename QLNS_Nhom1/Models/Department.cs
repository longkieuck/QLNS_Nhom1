﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.Models
{
    /// <summary>
    /// Phòng Ban 
    /// CreatedBy : Nguyễn Văn Hiến
    /// </summary>
    class Department
    {

        public Department()
        {
            
        }
        public Department(string DepartmentId)
        {
            this.DepartmentId = DepartmentId;
        }
        public Department(DataRow row)
        {
            this.DepartmentId = row["DepartmentId"].ToString();
            this.DepartmentIdName = row["DepartmentIdName"].ToString();
        }
        public Department(string departmentid, string departmentname)
        {
            this.DepartmentId = departmentid;
            this.DepartmentIdName = departmentname;
        }
        // Mã phòng ban
        public string DepartmentId { get; set; }
        // Tên Phòng ban
        public string DepartmentIdName { get; set; }

    }
}
