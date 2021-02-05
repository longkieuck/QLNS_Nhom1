namespace QLNS_Nhom1
{
    partial class gioithieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnshowhd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnshowhd
            // 
            this.btnshowhd.Location = new System.Drawing.Point(96, 12);
            this.btnshowhd.Name = "btnshowhd";
            this.btnshowhd.Size = new System.Drawing.Size(179, 28);
            this.btnshowhd.TabIndex = 0;
            this.btnshowhd.Text = "đọc";
            this.btnshowhd.UseVisualStyleBackColor = true;
            this.btnshowhd.Click += new System.EventHandler(this.btnshowhd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(31, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 249);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "giới thiệu:phần mềm quản lý nhân viên là một phần mềm quản lý mà trong đó mỗi côn" +
                "g ty",
            " có thể sử dụng để quản lý nhân viên một cách rõ ràng đồng thời tổ chức có hiệu q" +
                "uả mà ",
            "không tốn quá nhiều công sức, theo đó phần mềm sẽ chỉ định một admin quản lý tron" +
                "g ứng",
            " dụng này.",
            "Admin sẽ có quyền truy cập để thêm , sửa , xóa thông tin nhân viên để công ty có " +
                "thể theo",
            " dõi được tất cả thông tin cá nhân của các nhân viên."});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 238);
            this.listBox1.TabIndex = 0;
            // 
            // gioithieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnshowhd);
            this.Name = "gioithieu";
            this.Text = "gioithieu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshowhd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}