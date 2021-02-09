using QLNS_Nhom1.DAO;
using QLNS_Nhom1.Models;
using System;
using System.Collections.Generic;

namespace QLNS_Nhom1
{
    partial class fRepair
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.cbxSalaryId = new System.Windows.Forms.ComboBox();
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.cbxDepartmentId = new System.Windows.Forms.ComboBox();
            this.cbxPositionId = new System.Windows.Forms.ComboBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radKhac = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(704, 158);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 42);
            this.txtAddress.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(250, 226);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(216, 39);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(250, 154);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(216, 42);
            this.txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 39);
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
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 39);
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
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 39);
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
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(952, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 39);
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
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 39);
            this.label6.TabIndex = 11;
            this.label6.Tag = "";
            this.label6.Text = "Tên Phòng Ban :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1455, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 39);
            this.label7.TabIndex = 12;
            this.label7.Tag = "";
            this.label7.Text = "Hệ số Lương:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(952, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 39);
            this.label8.TabIndex = 14;
            this.label8.Tag = "";
            this.label8.Text = "Giới Tính:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(1654, 165);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(301, 26);
            this.dtpDateOfBirth.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1455, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 39);
            this.label11.TabIndex = 23;
            this.label11.Tag = "";
            this.label11.Text = "Ngày Sinh:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label11.UseCompatibleTextRendering = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(952, 338);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 57);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(-3, 0);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(161, 48);
            this.btnQuayLai.TabIndex = 26;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // cbxSalaryId
            // 
            this.cbxSalaryId.FormattingEnabled = true;
            this.cbxSalaryId.Location = new System.Drawing.Point(1654, 235);
            this.cbxSalaryId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxSalaryId.Name = "cbxSalaryId";
            this.cbxSalaryId.Size = new System.Drawing.Size(216, 28);
            this.cbxSalaryId.TabIndex = 27;
            // 
            // dtgvNV
            // 
            this.dtgvNV.ColumnHeadersHeight = 50;
            this.dtgvNV.Location = new System.Drawing.Point(200, 452);
            this.dtgvNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowHeadersWidth = 51;
            this.dtgvNV.Size = new System.Drawing.Size(1462, 382);
            this.dtgvNV.TabIndex = 28;
            this.dtgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNV_CellClick);
            // 
            // cbxDepartmentId
            // 
            this.cbxDepartmentId.FormattingEnabled = true;
            this.cbxDepartmentId.Location = new System.Drawing.Point(704, 235);
            this.cbxDepartmentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDepartmentId.Name = "cbxDepartmentId";
            this.cbxDepartmentId.Size = new System.Drawing.Size(216, 28);
            this.cbxDepartmentId.TabIndex = 29;
            // 
            // cbxPositionId
            // 
            this.cbxPositionId.FormattingEnabled = true;
            this.cbxPositionId.Location = new System.Drawing.Point(1148, 235);
            this.cbxPositionId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPositionId.Name = "cbxPositionId";
            this.cbxPositionId.Size = new System.Drawing.Size(235, 28);
            this.cbxPositionId.TabIndex = 30;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(1148, 154);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(85, 30);
            this.radNam.TabIndex = 31;
            this.radNam.TabStop = true;
            this.radNam.Tag = "nam";
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(1230, 154);
            this.radNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(68, 30);
            this.radNu.TabIndex = 32;
            this.radNu.TabStop = true;
            this.radNu.Tag = "nu";
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radKhac
            // 
            this.radKhac.AutoSize = true;
            this.radKhac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhac.Location = new System.Drawing.Point(1298, 154);
            this.radKhac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radKhac.Name = "radKhac";
            this.radKhac.Size = new System.Drawing.Size(92, 30);
            this.radKhac.TabIndex = 33;
            this.radKhac.TabStop = true;
            this.radKhac.Tag = "nu";
            this.radKhac.Text = "Khác";
            this.radKhac.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(794, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(348, 47);
            this.label12.TabIndex = 34;
            this.label12.Text = "SỬA NHÂN VIÊN";
            // 
            // fRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1924, 965);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radKhac);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.cbxPositionId);
            this.Controls.Add(this.cbxDepartmentId);
            this.Controls.Add(this.dtgvNV);
            this.Controls.Add(this.cbxSalaryId);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Nhân Viên ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ComboBox cbxSalaryId;
        private System.Windows.Forms.DataGridView dtgvNV;
        private System.Windows.Forms.ComboBox cbxDepartmentId;
        private System.Windows.Forms.ComboBox cbxPositionId;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radKhac;

        private void AddComboboxPosition()
        {
            var positions = new List<Position>();
            // lấy dữ liệu 
            positions = PositonDAO.Instance.GetPositions();

            // Đẩy dữ liệu vào combobox
            foreach (var item in positions)
            {
                cbxPositionId.Items.Add(item.PositionName.ToString());
            }
        }
 
        private void AddComboboxDepartment()
        {
            var deparments = new List<Department>();
            // lấy dữ liệu 
            deparments = DepartmentDAO.Instance.GetDepartments();

            // Đẩy dữ liệu vào combobox
            foreach (var item in deparments)
            {
                cbxDepartmentId.Items.Add(item.DepartmentIdName.ToString());
            }
        }
        
        private void AddComboboxSalary()
        {
            var salaries = new List<Salary>();
            // lấy dữ liệu 
            salaries = SalaryDAO.Instance.GetSalaries();

            // Đẩy dữ liệu vào combobox
            foreach (var item in salaries)
            {
                cbxSalaryId.Items.Add(item.LevelSalary);
            }
        }
       

        // Thêm dữ liệu vào combobox
        public void AddCombobox()
        {
            AddComboboxPosition();
            AddComboboxDepartment();
            AddComboboxSalary();
        }

        private System.Windows.Forms.Label label12;
    }
}
