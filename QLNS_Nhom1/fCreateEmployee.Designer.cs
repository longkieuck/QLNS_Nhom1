using QLNS_Nhom1.DAO;
using QLNS_Nhom1.Models;
using System.Collections.Generic;

namespace QLNS_Nhom1
{
    partial class fCreateEmployee
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
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbSalaryId = new System.Windows.Forms.ComboBox();
            this.cbPositionId = new System.Windows.Forms.ComboBox();
            this.cbDepartmentId = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(211, 122);
            this.txtEmployeeId.Multiline = true;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(192, 33);
            this.txtEmployeeId.TabIndex = 0;
            this.txtEmployeeId.UseWaitCursor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(211, 277);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 33);
            this.txtAddress.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(211, 225);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(192, 33);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(211, 173);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(192, 33);
            this.txtFullName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 4;
            this.label1.Tag = "";
            this.label1.Text = "Mã Nhân Viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 5;
            this.label2.Tag = "";
            this.label2.Text = "Số Điện Thoại :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 6;
            this.label3.Tag = "";
            this.label3.Text = "Họ Và Tên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 7;
            this.label4.Tag = "";
            this.label4.Text = "Địa Chỉ :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 10;
            this.label5.Tag = "";
            this.label5.Text = "Chức Vụ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 32);
            this.label6.TabIndex = 11;
            this.label6.Tag = "";
            this.label6.Text = "Mã Phòng Ban :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 32);
            this.label7.TabIndex = 12;
            this.label7.Tag = "";
            this.label7.Text = "Mã Lương:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 32);
            this.label8.TabIndex = 14;
            this.label8.Tag = "";
            this.label8.Text = "Giới Tính:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Location = new System.Drawing.Point(603, 288);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(192, 22);
            this.dateTimeDOB.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(429, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 32);
            this.label11.TabIndex = 23;
            this.label11.Tag = "";
            this.label11.Text = "Ngày Sinh:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label11.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(187, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 78);
            this.panel1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(159, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "THÊM NHÂN VIÊN";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(310, 415);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 35);
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(-2, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 33);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // cbSalaryId
            // 
            this.cbSalaryId.FormattingEnabled = true;
            this.cbSalaryId.Location = new System.Drawing.Point(603, 131);
            this.cbSalaryId.Name = "cbSalaryId";
            this.cbSalaryId.Size = new System.Drawing.Size(192, 24);
            this.cbSalaryId.TabIndex = 27;
            // 
            // cbPositionId
            // 
            this.cbPositionId.FormattingEnabled = true;
            this.cbPositionId.Location = new System.Drawing.Point(603, 182);
            this.cbPositionId.Name = "cbPositionId";
            this.cbPositionId.Size = new System.Drawing.Size(192, 24);
            this.cbPositionId.TabIndex = 29;
            // 
            // cbDepartmentId
            // 
            this.cbDepartmentId.FormattingEnabled = true;
            this.cbDepartmentId.Location = new System.Drawing.Point(211, 343);
            this.cbDepartmentId.Name = "cbDepartmentId";
            this.cbDepartmentId.Size = new System.Drawing.Size(192, 24);
            this.cbDepartmentId.TabIndex = 30;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(603, 232);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(192, 24);
            this.cbGender.TabIndex = 31;
            // 
            // fCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 853);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbDepartmentId);
            this.Controls.Add(this.cbPositionId);
            this.Controls.Add(this.cbSalaryId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmployeeId);
            this.Name = "fCreateEmployee";
            this.Text = "Thêm Nhân Viên ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbSalaryId;
        private System.Windows.Forms.ComboBox cbPositionId;
        private System.Windows.Forms.ComboBox cbDepartmentId;


        /// <summary>
        /// Thêm data vào combox Position : trên UI
        /// Created By : Nguyễn Văn Hiến
        /// </summary>
        private void AddComboboxPosition()
        {
            var positions = new List<Position>();
            // lấy dữ liệu 
            positions = PositonDAO.Instance.GetPositions();

            // Đẩy dữ liệu vào combobox
            foreach (var item in positions)
            {
                cbPositionId.Items.Add(item.PositionId.ToString());
            }
        }
        /// <summary>
        /// Thêm data vào combobox department :trên UI
        /// Created By : Nguyễn Văn Hiến
        /// </summary>
        private void AddComboboxDepartment()
        {
            var deparments = new List<Department>();
            // lấy dữ liệu 
            deparments = DepartmentDAO.Instance.GetDepartments();

            // Đẩy dữ liệu vào combobox
            foreach (var item in deparments)
            {
                cbDepartmentId.Items.Add(item.DepartmentId);
            }
        }
        /// <summary>
        /// Thêm data vào combobox salary : trên UI
        /// </summary>
        private void AddComboboxSalary()
        {
            var salaries = new List<Salary>();
            // lấy dữ liệu 
            salaries = SalaryDAO.Instance.GetSalaries();

            // Đẩy dữ liệu vào combobox
            foreach (var item in salaries)
            {
                cbSalaryId.Items.Add(item.SalaryId.ToString());
            }
        }
        private void AddComboboxGender()
        {
            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");
            cbGender.Items.Add("Khác");
        }

        // Thêm dữ liệu vào combobox
        public void AddCombobox()
        {
            AddComboboxPosition();
            AddComboboxDepartment();
            AddComboboxSalary();
            AddComboboxGender();
        }

        private System.Windows.Forms.ComboBox cbGender;
    }
    
    
}