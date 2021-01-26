using QLNS_Nhom1.DataAcessLayer;
using QLNS_Nhom1.Models;
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
    public partial class fMain : Form
    {
        public fMain()
        {

            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //test
        }

        void LoadDepartment()
        {
            List<Department> listDepartment = DepartmentDAL.Instance.GetListDepartment();
            cbDepartment.DataSource = listDepartment;
        }

        void LoadEmployeeListByDepartmentId(string id)
        {
            List<Employee> listEmployee = EmployeeDAL.Instance.GetEmployeeByDepartmentID(id);

        }
    }
}
