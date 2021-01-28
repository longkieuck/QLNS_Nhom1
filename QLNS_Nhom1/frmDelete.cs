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

namespace QLNS_Nhom1
{
    public partial class frmDelete : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source =.\\SQLEXPRESS;Initial Catalog = QLNS; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void Loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from dbo.Employee";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public frmDelete()
        {
            InitializeComponent();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tbID.Text = dgv.Rows[i].Cells[0].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from dbo.Employee where Id = '"+tbID.Text+"'";
            command.ExecuteNonQuery();
            Loaddata();
        }
    }
}
