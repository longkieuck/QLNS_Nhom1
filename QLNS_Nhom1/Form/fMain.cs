using QLNS_Nhom1;
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
            LoadDepartment();

        }

        void LoadDepartment()
        {
            List<Department> listDepartment = DepartmentDAL.Instance.GetListDepartment();
            Department department = new Department("Tất Cả", "Tất Cả");

            listDepartment.Insert(0, department);

            cbDepartment.DataSource = listDepartment;
            cbDepartment.DisplayMember = "DepartmentIdName";
        }

        List<Employee> SearchEmployeeByName(string name, string department)
        {
            List<Employee> listEmployee = EmployeeDAL.Instance.SearchEmployeeByName(name,department);

            return listEmployee;
        }

        void LoadEmployeeList(List<Employee> employee)
        {
            GetDepartmentName(employee);
            foreach (Employee em in employee)
            {
                ListViewItem item = new ListViewItem(em.Id.ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.FullName });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.Gender });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.PhoneNumber });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.Address });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.DateOfBirth.ToString("yyyy/MM/dd") });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.DepartmentId });

                lstEmployee.Items.Add(item);
            }
        }
        void LoadEmployeeListByDepartmentId(string id)
        {
            List<Employee> listEmployee = EmployeeDAL.Instance.GetEmployeeByDepartmentID(id);
            LoadEmployeeList(listEmployee);
            listEmployee.Clear();
        }

        void GetDepartmentName(List<Employee> employee)
        {
            List<Department> listDepartment = DepartmentDAL.Instance.GetListDepartment();
            foreach (Employee em in employee)
            {
                foreach (Department dep in listDepartment)
                {
                    if (em.DepartmentId.CompareTo(dep.DepartmentId) == 0)
                    {
                        em.DepartmentId = dep.DepartmentIdName;
                    }
                }
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstEmployee.Items.Clear();
            string id = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            Department selected = cb.SelectedItem as Department;

            id = selected.DepartmentId;

            LoadEmployeeListByDepartmentId(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstEmployee.Items.Clear();
            string departmentname = cbDepartment.Text;
            List<Employee> listEmployee = SearchEmployeeByName(txtEmployee.Text,departmentname);
            LoadEmployeeList(listEmployee);
        }
    
        private void btnEdit_Click(object sender, EventArgs e)
        {

            // khơi tạo form sửa ,mở form
            fRepair f = new fRepair();
            f.Show();

            // đóng lại cửa sổ main
            //this.Close();
        }

        private void TaoHoSo_Click(object sender, EventArgs e)
        {
            fCreateEmployee f = new fCreateEmployee();
            f.Show();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            fDelete frm = new fDelete();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            fRepair f = new fRepair();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void TaoHoSo_Click_1(object sender, EventArgs e)
        {
            fCreateEmployee f = new fCreateEmployee();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fIntroduce formgt = new fIntroduce();
            formgt.Show();
        }

        private void môTảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fIntruction formmt = new fIntruction();
            formmt.Show();
        }
    }
}

