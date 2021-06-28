using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNS_Nhom1.DAO;

namespace QLNS_Nhom1
{
    public partial class fDelete : Form
    {
        public fDelete()
        {
            InitializeComponent();
            LoadListEmployee();
            EditDataGridViewHeader();
        }
        private void EditDataGridViewHeader()
        {
            dgv.Columns["Id"].HeaderText = "Mã nhân viên";
            dgv.Columns["FullName"].HeaderText = "Họ tên";
            dgv.Columns["Gender"].HeaderText = "Giới tính";
            dgv.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dgv.Columns["Address"].HeaderText = "Địa chỉ";
            dgv.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgv.Columns["PositionId"].HeaderText = "Mã vị trí";
            dgv.Columns["DepartmentId"].HeaderText = "Mã phòng ban";
            dgv.Columns["SalaryId"].HeaderText = "Mã lương";
        }
        /// <summary>
        /// đổ dữ liệu vào girdview
        /// created by dat
        /// </summary>
        void LoadListEmployee()
        {
            dgv.DataSource = EmployeeDAO.Instance.GetListEmployee();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tbID.Text = dgv.Rows[i].Cells[0].Value.ToString();
        }

          
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập id nhân viên muốn xoá!");
            }
            else if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có id là: " + tbID.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int idEmployee;
                Int32.TryParse(tbID.Text.Trim(), out idEmployee);
                try
                {
                    EmployeeDAO.Instance.Delete(idEmployee);
                    MessageBox.Show("Xóa thành công");
                    LoadListEmployee();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                    LoadListEmployee();
                }
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
