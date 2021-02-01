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
    public partial class fRepairEmployee : Form
    {
        public fRepairEmployee()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            LoadListEmployee();
            LoadIntoCbxDepartmentId(cbxDepartmentId);
            LoadIntoCbxPositionId(cbxPositionId);
            LoadIntoCbxSalaryId(cbxSalaryId);
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
        /// load combobox
        /// created by dat
        /// </summary>
        /// <param name="cb"></param>
        void LoadIntoCbxDepartmentId(ComboBox cb)
        {
            //cb.DataSource = EmployeeDAO.Instance.GetListDepartmentId();
            //cb.DisplayMember = "DepartmentId";

            var departments = EmployeeDAO.Instance.GetListDepartmentId();
            foreach (var item in departments)
            {

                cb.Items.Add(item.DepartmentId);
            }
        }

        void LoadIntoCbxPositionId(ComboBox cb)
        {

            //cb.DataSource = EmployeeDAO.Instance.GetListPositiontId();
            //cb.DisplayMember = "PositonId";
            var positions = EmployeeDAO.Instance.GetListPositiontId();
            foreach (var item in positions)
            {

                cb.Items.Add(item.PositionId);
            }



        }

        void LoadIntoCbxSalaryId(ComboBox cb)
        {
            //cb.DataSource = EmployeeDAO.Instance.GetListSalaryId();
            //cb.DisplayMember = "SalaryId";
            var salarys = EmployeeDAO.Instance.GetListSalaryId();
            foreach (var item in salarys)
            {
                cb.Items.Add(item.SalaryId);
            }
        }
        /// <summary>
        /// lấy dữ liệu khi trỏ chuột trong gridview
        /// created by dat
        /// </summary>
        void AddBindingEmployee()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtFullName.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "FullName", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Address", true, DataSourceUpdateMode.Never));
            cbxDepartmentId.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "DepartmentId", true, DataSourceUpdateMode.Never));
            txtPhoneNumber.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            cbxPositionId.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "PositionId", true, DataSourceUpdateMode.Never));
            cbxSalaryId.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "SalaryId", true, DataSourceUpdateMode.Never));
            dtpDateOfBirth.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "DateOfBirth", true, DataSourceUpdateMode.Never));
            var fmaleBinding = new Binding("Checked", dtgvNV.DataSource, "Gender", true, DataSourceUpdateMode.Never);
            // when Formatting (reading from datasource), return true for Female, else false
            fmaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "nu ";
            // when Parsing (writing to datasource), return "Male" for true, else "Fmale"
            fmaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "nu " : "nam";
            // add the binding
            radNu.DataBindings.Add(fmaleBinding);

            // you don't need to bind the Male radiobutton, just make it do the opposite
            // of Male by handling the CheckedChanged event on Male:
            radNu.CheckedChanged += (s, args) => radNam.Checked = !radNu.Checked;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa nhân viên có tên là: " + txtFullName.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtFullName.Text == "" || txtAddress.Text == "" || txtID.Text == "" || txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    Employee employee = new Employee();
                    employee.FullName = txtFullName.Text;
                    employee.DateOfBirth = dtpDateOfBirth.Value;
                    employee.Address = txtAddress.Text;
                    employee.Gender = radNam.Checked ? "nam" : "nu";
                    employee.PhoneNumber = txtPhoneNumber.Text;
                    employee.PositionId = cbxPositionId.Text;
                    employee.SalaryId = cbxSalaryId.Text;
                    employee.DepartmentId = cbxDepartmentId.Text;
                    employee.Id = Int32.Parse(txtID.Text);
                    if (EmployeeDAO.Instance.UpdateNv(employee))
                    {
                        MessageBox.Show("Sửa nhân viên thành công! ");
                        LoadListEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa nhân viên! ");
                    }
                }
            }
        }
    }
}