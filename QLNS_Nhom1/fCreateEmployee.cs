﻿using QLNS_Nhom1.DAO;
using QLNS_Nhom1.Models;
using System;
using System.Windows.Forms;

namespace QLNS_Nhom1
{
    public partial class fCreateEmployee : Form
    {
        public fCreateEmployee()
        {
            InitializeComponent();
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

            if (EmployeeDAO.Instance.InsertEmployee(employee))
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Lỗi Trong quá trình thêm");
            }

        }
    }
}