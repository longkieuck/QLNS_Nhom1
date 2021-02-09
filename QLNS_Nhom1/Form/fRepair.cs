using QLNS_Nhom1.DAO;
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
    public partial class fRepair : Form
    {
        public fRepair()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            LoadListEmployee();
            AddCombobox();
            AddBindingEmployee();

        }
        /// <summary>
        /// đổ dữ liệu vào girdview
        /// created by dat
        /// </summary>
        void LoadListEmployee()
        {
            dtgvNV.DataSource = EmployeeDAO.Instance.GetListEmployee();
        }


        /// <summary>
        /// lấy dữ liệu khi trỏ chuột trong gridview
        /// created by dat
        /// </summary>
        void AddBindingEmployee()
        {
            txtFullName.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "FullName", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txtPhoneNumber.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            dtpDateOfBirth.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "DateOfBirth", true, DataSourceUpdateMode.Never));
            var fmaleBinding = new Binding("Checked", dtgvNV.DataSource, "Gender", true, DataSourceUpdateMode.Never);
            fmaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nữ ";
            fmaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nữ " : "Nam";
            radNu.DataBindings.Add(fmaleBinding);
            radNu.CheckedChanged += (s, args) => radNam.Checked = !radNu.Checked;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// cac ham convertdata
        /// </summary>
    
        private string GetDepartmentIdByDepartmentName(string departmentName)
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
        private string GetDepartmentIdNameByDepartmentId(string departmentId)
        {
            var departments = DepartmentDAO.Instance.GetDepartments();
            foreach (var department in departments)
            {
                if (department.DepartmentId.Equals(departmentId))
                {
                    return department.DepartmentIdName;
                }
            }
            return "Null-Dữ liệu truyền vào bị lỗi";

        }
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

        private string GetPositionNameByPositionId(string positionId)
        {
            var positions = PositonDAO.Instance.GetPositions();
            foreach (var position in positions)
            {
                if (position.PositionId.Equals(positionId))
                {
                    return position.PositionName;
                }
            }
            return "Null-Dữ liệu truyền vào bị lỗi";

        }
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

        private float GetLevelSalaryBySararyId(string SalaryId)
        {
            var salaries = SalaryDAO.Instance.GetSalaries();
            foreach (var salary in salaries)
            {
                if (salary.SalaryId.Equals(SalaryId))
                {
                    return salary.LevelSalary;
                }
            }
            return 0;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
         
            if (MessageBox.Show("Bạn có thật sự muốn sửa nhân viên có tên là: " + txtFullName.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtFullName.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "" ||cbxDepartmentId.Text=="" || cbxPositionId.Text == "" || cbxSalaryId.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    Employee employee = new Employee();
                    employee.FullName = txtFullName.Text;
                    employee.DateOfBirth = dtpDateOfBirth.Value;
                    employee.Address = txtAddress.Text;
                    employee.Gender = radNam.Checked ? "Nam" : radNu.Checked?"Nữ":radKhac.Checked?"Khác":"null";
                    if (employee.Gender == "null") MessageBox.Show("Vui lòng chọn giới tính!");
                    else
                    {
                        employee.PhoneNumber = txtPhoneNumber.Text;
                        employee.PositionId = GetPositionIdByPositionName(cbxPositionId.Text);
                        employee.DepartmentId = GetDepartmentIdByDepartmentName(cbxDepartmentId.Text);
                        employee.SalaryId = GetSalaryIdByLevelSalary(float.Parse(cbxSalaryId.Text));
                        employee.Id = id;
                        if (EmployeeDAO.Instance.UpdateEmployee(employee))
                        {
                            MessageBox.Show("Sửa nhân viên thành công! ");
                            this.Hide();

                            fRepair f = new fRepair();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi sửa nhân viên! ");
                        }
                    }
                }
            }
        }
        int id;
        /// <summary>
        /// chuc nang tuong tu voi blinding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            string DepartmentId;
            string PositionId;
            string SararyId;
            if (numrow >= 0)
            {
                DepartmentId = dtgvNV.Rows[numrow].Cells[7].Value.ToString();
                cbxDepartmentId.Text = GetDepartmentIdNameByDepartmentId(DepartmentId);
                SararyId = dtgvNV.Rows[numrow].Cells[8].Value.ToString();
                cbxSalaryId.Text = GetLevelSalaryBySararyId(SararyId).ToString();
                PositionId = dtgvNV.Rows[numrow].Cells[6].Value.ToString();
                cbxPositionId.Text = GetPositionNameByPositionId(PositionId);
                id = Convert.ToInt32(dtgvNV.Rows[numrow].Cells[0].Value);
            }

                

            
        }
    }
}