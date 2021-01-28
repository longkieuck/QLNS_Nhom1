using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_Nhom1
{
    public partial class FormGT : Form
    {
        public FormGT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\xuanh\Desktop\gioithieu.txt";
            var str = File.ReadAllText(path);
            textBox1.Text = str;
        }
    }
}
