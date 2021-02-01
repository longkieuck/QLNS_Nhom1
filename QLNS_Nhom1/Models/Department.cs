<<<<<<< HEAD
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
        public Department(DataRow row)
        {
            this.DepartmentId = row["DepartmentId"].ToString();
            this.DepartmentIdName = row["DepartmentIdName"].ToString();
        }
        public Department()
        {

        }
        // Mã phòng ban
        public string DepartmentId { get; set; }
        // Tên Phòng ban
        public string DepartmentIdName { get; set; }
    }
}
=======
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
        private DataRow dataRow;
        private string departmentid;
        private string departmentidname;

        public Department() {}
        public Department(string departmentid, string departmentname)
        {
            this.DepartmentId = departmentid;
            this.DepartmentIdName = departmentname;
        }
        public Department(DataRow dataRow)
        {
            this.DepartmentId = dataRow["DepartmentId"].ToString();
            this.DepartmentIdName = dataRow["DepartmentIdName"].ToString();
        }

        // Mã phòng ban
        public string DepartmentId 
        { 
            get { return departmentid; }
            set { departmentid = value; }
        }
        // Tên Phòng ban
        public string DepartmentIdName 
        {
            get { return departmentidname; }
            set { departmentidname = value; }
        }

    }
}
>>>>>>> origin/van
