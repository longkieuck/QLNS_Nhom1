using QLNS_Nhom1.DataAcessLayer;
using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_Nhom1
{
    public partial class fCreateEmployee : Form
    {
        public fCreateEmployee()
        {
            InitializeComponent();
            AddCombobox();
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            //Kiếm tra có nhập dữ liệu hay không


            // Lấy dữ liệu nhập : khi đã nhập đủ 
            Employee employee = new Employee();
            employee.Id = Int32.Parse(txtEmployeeId.Text);
            employee.FullName = txtFullName.Text;
            employee.PhoneNumber = txtPhoneNumber.Text;
            employee.Address = txtAddress.Text;
            employee.PositionId = cbPositionId.SelectedItem.ToString();
            employee.DepartmentId = cbDepartmentId.SelectedItem.ToString();
            employee.SalaryId = cbSalaryId.SelectedItem.ToString();
            employee.Gender = cbGender.SelectedItem.ToString();
            employee.DateOfBirth = dateTimeDOB.Value;

            //if (DataAcessLayer.Instance.InsertEmployee(employee))
            //{
            //    MessageBox.Show("Thêm Thành Công");
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi Trong quá trình thêm");
            //}

        }
    }
}
