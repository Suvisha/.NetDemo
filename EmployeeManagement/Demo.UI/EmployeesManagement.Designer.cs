namespace Demo.UI
{
    partial class EmployeesManagement
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
            this.lalEmployeeId = new System.Windows.Forms.Label();
            this.lalEmployeeName = new System.Windows.Forms.Label();
            this.lalDesignation = new System.Windows.Forms.Label();
            this.btnViewEmployee = new System.Windows.Forms.Button();
            this.lalEmployeeTypes = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.combEmployeeTypes = new System.Windows.Forms.ComboBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lalHourlyPay = new System.Windows.Forms.Label();
            this.lalBounuRate = new System.Windows.Forms.Label();
            this.lalHourly = new System.Windows.Forms.Label();
            this.lalBonus = new System.Windows.Forms.Label();
            this.btnViewAllEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalEmployeeId
            // 
            this.lalEmployeeId.AutoSize = true;
            this.lalEmployeeId.Location = new System.Drawing.Point(17, 34);
            this.lalEmployeeId.Name = "lalEmployeeId";
            this.lalEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.lalEmployeeId.TabIndex = 0;
            this.lalEmployeeId.Text = "Employee Id";
            // 
            // lalEmployeeName
            // 
            this.lalEmployeeName.AutoSize = true;
            this.lalEmployeeName.Location = new System.Drawing.Point(15, 82);
            this.lalEmployeeName.Name = "lalEmployeeName";
            this.lalEmployeeName.Size = new System.Drawing.Size(81, 13);
            this.lalEmployeeName.TabIndex = 1;
            this.lalEmployeeName.Text = "EmployeeName";
            // 
            // lalDesignation
            // 
            this.lalDesignation.AutoSize = true;
            this.lalDesignation.Location = new System.Drawing.Point(13, 134);
            this.lalDesignation.Name = "lalDesignation";
            this.lalDesignation.Size = new System.Drawing.Size(63, 13);
            this.lalDesignation.TabIndex = 2;
            this.lalDesignation.Text = "Designation";
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.Location = new System.Drawing.Point(242, 28);
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.Size = new System.Drawing.Size(105, 23);
            this.btnViewEmployee.TabIndex = 3;
            this.btnViewEmployee.Text = "View Employee";
            this.btnViewEmployee.UseVisualStyleBackColor = true;
            this.btnViewEmployee.Click += new System.EventHandler(this.btnViewEmployee_Click);
            // 
            // lalEmployeeTypes
            // 
            this.lalEmployeeTypes.AutoSize = true;
            this.lalEmployeeTypes.Location = new System.Drawing.Point(14, 181);
            this.lalEmployeeTypes.Name = "lalEmployeeTypes";
            this.lalEmployeeTypes.Size = new System.Drawing.Size(82, 13);
            this.lalEmployeeTypes.TabIndex = 4;
            this.lalEmployeeTypes.Text = "EmployeeTypes";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(101, 34);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.TabIndex = 5;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(101, 77);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 6;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(101, 129);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(100, 20);
            this.txtDesignation.TabIndex = 7;
            // 
            // combEmployeeTypes
            // 
            this.combEmployeeTypes.FormattingEnabled = true;
            this.combEmployeeTypes.Items.AddRange(new object[] {
            "Permenent",
            "Contract"});
            this.combEmployeeTypes.Location = new System.Drawing.Point(101, 173);
            this.combEmployeeTypes.Name = "combEmployeeTypes";
            this.combEmployeeTypes.Size = new System.Drawing.Size(100, 21);
            this.combEmployeeTypes.TabIndex = 8;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(6, 299);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(93, 23);
            this.btnSaveEmployee.TabIndex = 9;
            this.btnSaveEmployee.Text = "Save Employee";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(129, 299);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteEmployee.TabIndex = 10;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(245, 299);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateEmployee.TabIndex = 11;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(245, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lalHourlyPay
            // 
            this.lalHourlyPay.AutoSize = true;
            this.lalHourlyPay.Location = new System.Drawing.Point(17, 222);
            this.lalHourlyPay.Name = "lalHourlyPay";
            this.lalHourlyPay.Size = new System.Drawing.Size(58, 13);
            this.lalHourlyPay.TabIndex = 13;
            this.lalHourlyPay.Text = "Hourly Pay";
            // 
            // lalBounuRate
            // 
            this.lalBounuRate.AutoSize = true;
            this.lalBounuRate.Location = new System.Drawing.Point(17, 260);
            this.lalBounuRate.Name = "lalBounuRate";
            this.lalBounuRate.Size = new System.Drawing.Size(63, 13);
            this.lalBounuRate.TabIndex = 14;
            this.lalBounuRate.Text = "Bouns Rate";
            // 
            // lalHourly
            // 
            this.lalHourly.AutoSize = true;
            this.lalHourly.Location = new System.Drawing.Point(107, 222);
            this.lalHourly.Name = "lalHourly";
            this.lalHourly.Size = new System.Drawing.Size(16, 13);
            this.lalHourly.TabIndex = 15;
            this.lalHourly.Text = "...";
            // 
            // lalBonus
            // 
            this.lalBonus.AutoSize = true;
            this.lalBonus.Location = new System.Drawing.Point(107, 260);
            this.lalBonus.Name = "lalBonus";
            this.lalBonus.Size = new System.Drawing.Size(16, 13);
            this.lalBonus.TabIndex = 16;
            this.lalBonus.Text = "...";
            // 
            // btnViewAllEmployees
            // 
            this.btnViewAllEmployees.Location = new System.Drawing.Point(6, 338);
            this.btnViewAllEmployees.Name = "btnViewAllEmployees";
            this.btnViewAllEmployees.Size = new System.Drawing.Size(117, 23);
            this.btnViewAllEmployees.TabIndex = 17;
            this.btnViewAllEmployees.Text = "View All Employees";
            this.btnViewAllEmployees.UseVisualStyleBackColor = true;
            // 
            // EmployeesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 373);
            this.Controls.Add(this.btnViewAllEmployees);
            this.Controls.Add(this.lalBonus);
            this.Controls.Add(this.lalHourly);
            this.Controls.Add(this.lalBounuRate);
            this.Controls.Add(this.lalHourlyPay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.combEmployeeTypes);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lalEmployeeTypes);
            this.Controls.Add(this.btnViewEmployee);
            this.Controls.Add(this.lalDesignation);
            this.Controls.Add(this.lalEmployeeName);
            this.Controls.Add(this.lalEmployeeId);
            this.Name = "EmployeesManagement";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalEmployeeId;
        private System.Windows.Forms.Label lalEmployeeName;
        private System.Windows.Forms.Label lalDesignation;
        private System.Windows.Forms.Button btnViewEmployee;
        private System.Windows.Forms.Label lalEmployeeTypes;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.ComboBox combEmployeeTypes;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lalHourlyPay;
        private System.Windows.Forms.Label lalBounuRate;
        private System.Windows.Forms.Label lalHourly;
        private System.Windows.Forms.Label lalBonus;
        private System.Windows.Forms.Button btnViewAllEmployees;
    }
}

