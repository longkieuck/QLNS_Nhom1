using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_Nhom1
{
    public partial class fRepairEmployee : Form
    {
        public fRepairEmployee()
        {
            InitializeComponent();
            LoadList();
        }
        

        /// <summary>
        /// đổ dữ liệu vào girdview
        /// created by dat
        /// </summary>
        void LoadList()
        {
            dtgvNV.DataSource = EmployeeDAO.Instance.GetListFood();
        }
    }
}
