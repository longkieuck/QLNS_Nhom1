﻿using QLNS_Nhom1.DAO;
using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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


        /// <summary>
        /// kiểm tra định dạng regex họ và tên 
        /// created by : NVH
        /// </summary>
        /// <param name="name"> input : 1 chuỗi</param>
        /// <returns>true or false</returns>
        private bool CheckFullName(string name)
        {
            //regex họ và tên :Bắt ít nhất 1 kí tự và nhiều nhất 20 kí tự
            string re = "^\\D{1,20}$";
            //string re = "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$";
            Regex regex = new Regex(re);
            Match match = regex.Match(name);
            //trả về true : đúng định dạng ,false : sai định dạng 
            return match.Success;
        }

        /// <summary>
        /// Kiểm tra regex địa chỉ 
        /// CreatedBy : NVH
        /// </summary>
        /// <param name="address"> input : địa chỉ dạng chuỗi </param>
        /// <returns>true or false</returns>
        private bool CheckAddress(string address)
        {
            //regex địa chỉ :  các chữ cái bao gồm cả tiếng việt , bắt đầu từ 1 kí tự 
            string re = "^\\D{1,20}$";
            Regex regex = new Regex(re);
            Match match = regex.Match(address);
            //trả về true : đúng định dạng ,false : sai định dạng 
            return match.Success;
        }
        private bool CheckPhoneNumber(string phoneNumber)
        {
            //regex địa chỉ :  tên gồm các chữ cái ,Các kí tự đầu của  của tên or họ phải bắt đầu bằng chữ hoa
            //Và có ít nhất 2 thành phần trở lên 
            string re = "^[0-9]{1,15}$";
            Regex regex = new Regex(re);
            Match match = regex.Match(phoneNumber);
            //trả về true : đúng định dạng ,false : sai định dạng 
            return match.Success;
        }
        
        public bool Check()
        {
            if (!CheckFullName(txtFullName.Text.Trim()) | !CheckPhoneNumber(txtPhoneNumber.Text.Trim()) 
                | !CheckAddress(txtAddress.Text.Trim())
                | string.IsNullOrEmpty(cbDepartmentId.Text) | string.IsNullOrEmpty(cbPositionId.Text)
                | string.IsNullOrEmpty(cbSalaryId.Text)
                | string.IsNullOrEmpty(cbGender.Text)
                )
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Lấy dữ liệu mã phòng ban thông qua tên phòng ban
        /// Created By : Nguyễn Văn Hiến
        /// </summary>
        /// <param name="departmentName">tên phòng ban cần lấy mã</param>
        /// <returns>mã phòng ban or lỗi</returns>
        public string GetDepartmentIdByDepartmentName(string departmentName)
        {
            var departments = DepartmentDAO.Instance.GetDepartments();
            foreach (var department in departments)
            {
                if (department.DepartmentIdName.Equals(departmentName))
                {
                    return department.DepartmentId;
                }
            }
            return "Null-Dữ liệu truyền vào bị lỗi";

        }

        /// <summary>
        /// Lấy dữ liệu mã chức vụ thông qua tên chức vụ
        /// Created By : Nguyễn Văn Hiến
        /// </summary>
        /// <param name="positionName">tên chức vụ cần lấy mã </param>
        /// <returns>Mã chức vụ or lỗi </returns>
        private string GetPositionIdByPositionName(string positionName)
        {
            var positions = PositonDAO.Instance.GetPositions();
            foreach (var position in positions)
            {
                if (position.PositionName.Equals(positionName))
                {
                    return position.PositionId;
                }
            }
            return "Null-Dữ liệu truyền vào bị lỗi";

        }

        /// <summary>
        /// Láy mã lương thông qua cấp độ lương
        /// Created By : Nguyễn Văn Hiến
        /// </summary>
        /// <param name="levelSalary">cấp độ lương</param>
        /// <returns>mã lương or lỗi</returns>
        private string GetSalaryIdByLevelSalary(float levelSalary)
        {
            var salaries = SalaryDAO.Instance.GetSalaries();
            foreach (var salary in salaries)
            {
                if (salary.LevelSalary == levelSalary)
                {
                    return salary.SalaryId;
                }
            }
            return "Null-Dữ liệu truyền vào bị lỗi";

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            /// check valid 
            if (!Check())
            {
                MessageBox.Show("Dữ liệu Nhập đang lỗi hệ thống báo dưới đây , Vui lòng kiểm tra lại\n" +
                    "Họ Và Tên(bao gồm các kí tự) :"+ CheckFullName(txtFullName.Text) + "\nSố điện thoại(bao gồm các số) : "+ CheckPhoneNumber(txtPhoneNumber.Text.Trim())
                    +"\nĐịa chỉ(bao gồm các kí tự): "+ CheckAddress(txtAddress.Text.Trim())
                    +"\nChức vụ : " + !string.IsNullOrEmpty(cbPositionId.Text)
                    + "\nGiới tính : " + !string.IsNullOrEmpty(cbGender.Text)
                    + "\nMã lương : " + !string.IsNullOrEmpty(cbSalaryId.Text)
                    + "\nMã phòng ban : " + !string.IsNullOrEmpty(cbDepartmentId.Text)
                    + "\nNgày sinh : " + true
                    );
            }
            // Khi dữ liệu hợp lệ 
            else
            {
                // Lấy dữ liệu nhập : khi đã nhập đủ 
                Employee employee = new Employee();
                employee.FullName = txtFullName.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.Address = txtAddress.Text;
                employee.PositionId = GetPositionIdByPositionName(cbPositionId.Text);
                employee.DepartmentId = GetDepartmentIdByDepartmentName(cbDepartmentId.Text);
                employee.SalaryId = GetSalaryIdByLevelSalary(float.Parse(cbSalaryId.Text));
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
}
