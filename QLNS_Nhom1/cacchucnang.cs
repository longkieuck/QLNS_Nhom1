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
    public partial class cacchucnang : Form
    {
        public cacchucnang()
        {
            InitializeComponent();
        }
        int count = -1;
        private void btnpre_Click(object sender, EventArgs e)
        {
            if (count < 4)
            {
                count++;
            }
            pictureBox1.Image = imageList1.Images[count];
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (count >0)
            {
                count--;
            }
            pictureBox1.Image = imageList1.Images[count];
        }
    }
}
