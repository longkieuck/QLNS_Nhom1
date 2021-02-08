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
    public partial class FormGT : Form
    {
        public FormGT()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        private void richTextBox1_BindingContextChanged(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Phần mềm này có thế giúp giáo viên " +
                "quản lý từ mô hình lớp 10-10000 học viên, có thể áp dụng ở" +
                " các trung tâm học thêm . Với giao diện thân thiện và dễ sử" +
                " dụng,phần mềm hoàn toàn chạy độc lập trên nhiều máy tính có" +
                " cấu hình khác nhau hoặc tiết kiệm ngân sách tối đa cho các trung tâm bằng mô hình " +
                "Chúng tôi luôn mong muốn mang đến cho nền Giáo Dục Việt Nam những " +
                "công nghệ mới nhất – tiên tiến nhất – tiết kiệm ngân sách nhất.Xin " +
                "chân thành cảm ơn Quý khách hàng đã tin tưởng và sử dụng sảm phẩm của " +
                "chúng tôi.Chúng tôi sẽ không ngừng học tập và nghiên cứu để ngày càng hoàn " +
                "thiện hơn, để đóng góp một phần nhỏ bé vào nền Giáo Dục của nước nhà.");
        }
    }
}
