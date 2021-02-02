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

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        void LoadDepartment()
        {
            List<Department> listDepartment = DepartmentDAL.Instance.GetListDepartment();
            Department department = new Department("Tất Cả", "Tất Cả");

            listDepartment.Insert(0, department);

            cbDepartment.DataSource = listDepartment;
            cbDepartment.DisplayMember = "DepartmentIdName";
        }

        List<Employee> SearchEmployeeByName(string name)
        {
            List<Employee> listEmployee = EmployeeDAL.Instance.SearchEmployeeByName(name);

            return listEmployee;
        }

        void LoadEmployeeList(List<Employee> employee)
        {
            foreach(Employee em in employee)
            {
                ListViewItem item = new ListViewItem(em.Id.ToString());
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.FullName });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.Gender });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.PhoneNumber });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.Address });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = em.DateOfBirth.ToString("yyyy/MM/dd") });

                lstEmployee.Items.Add(item);
            }
        }
        void LoadEmployeeListByDepartmentId(string id)
        {
            List<Employee> listEmployee = EmployeeDAL.Instance.GetEmployeeByDepartmentID(id);
            LoadEmployeeList(listEmployee);
            listEmployee.Clear();
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

            List<Employee> listEmployee = SearchEmployeeByName(txtEmployee.Text);
            LoadEmployeeList(listEmployee);
        }
    
        private void btnEdit_Click(object sender, EventArgs e)
        {

            // khơi tạo form sửa ,mở form
            fRepairEmployee f = new fRepairEmployee();
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
            frmDelete frm = new frmDelete();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            fRepairEmployee f = new fRepairEmployee();
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

        private void lỗiHayGặpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gioithieu fgioithieu = new gioithieu();
            fgioithieu.Show();
        }

        private void cácChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cacchucnang fcacchucnang = new cacchucnang();
            fcacchucnang.Show();
        }
    }
}

