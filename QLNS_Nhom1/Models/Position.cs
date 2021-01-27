using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.Models
{
    /// <summary>
    /// Chức vụ 
    /// CreatedBy : Nguyễn Văn Hiến
    /// </summary>
    class Position
    {
        //contructor
        public Position(DataRow row)
        {
            this.PositionId = row["PositionId"].ToString();
            this.PositionName = row["PositionName"].ToString();
        }

        // Mã chức vụ
        public string PositionId { get; set; }
        
        // Tên chức vụ
        public string PositionName { get; set; }

    }
}
