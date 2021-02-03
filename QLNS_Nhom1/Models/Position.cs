using System.Data;
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
        public Position()
        {
        }
        // Mã chức vụ
        public string PositionId { get; set; }
        
        // Tên chức vụ
        public string PositionName { get; set; }

    }
}
