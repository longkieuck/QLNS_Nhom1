﻿using System;
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formhelp = new FormHelp();
            formhelp.Show();
        }

        private void cácMẹoKhiSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTip formtip = new FormTip();
            formtip.Show();
        }
    }
}
