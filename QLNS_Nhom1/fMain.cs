<<<<<<< HEAD
﻿using QLNS_Nhom1.DataAcessLayer;
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
        }
        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            // khơi tạo form sửa ,mở form
            fRepairEmployee f = new fRepairEmployee();
            f.Show();

            // đóng lại cửa sổ main
            //this.Close();
        }
    }
}
=======
﻿using QLNS_Nhom1.DataAcessLayer;
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
        }
        private void fMain_Load(object sender, EventArgs e)
        {

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
    }
}
>>>>>>> e9b8b30f915d195ab2900a2a7435e8fde2986782
