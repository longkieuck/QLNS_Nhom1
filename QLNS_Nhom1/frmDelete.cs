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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
            LoadListEmployee();
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
}
