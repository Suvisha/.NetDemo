namespace Employees_Data_UI
{
    partial class Insert
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
            this.BACK = new System.Windows.Forms.Button();
            this.EmployeeDetails = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Dept_txt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.EType_txt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(311, 274);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(75, 23);
            this.BACK.TabIndex = 0;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeDetails
            // 
            this.EmployeeDetails.AutoSize = true;
            this.EmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDetails.Location = new System.Drawing.Point(199, 49);
            this.EmployeeDetails.Name = "EmployeeDetails";
            this.EmployeeDetails.Size = new System.Drawing.Size(150, 20);
            this.EmployeeDetails.TabIndex = 1;
            this.EmployeeDetails.Text = "EmployeeDetails";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSize = true;
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(114, 129);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(107, 16);
            this.EmployeeName.TabIndex = 2;
            this.EmployeeName.Text = "EmployeeName";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(113, 160);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(78, 16);
            this.Department.TabIndex = 3;
            this.Department.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Type";
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(286, 123);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(100, 20);
            this.Name_txt.TabIndex = 7;
            // 
            // Dept_txt
            // 
            this.Dept_txt.Location = new System.Drawing.Point(286, 153);
            this.Dept_txt.Name = "Dept_txt";
            this.Dept_txt.Size = new System.Drawing.Size(100, 20);
            this.Dept_txt.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(163, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EType_txt
            // 
            this.EType_txt.FormattingEnabled = true;
            this.EType_txt.Items.AddRange(new object[] {
            "Permenent",
            "Contract"});
            this.EType_txt.Location = new System.Drawing.Point(286, 194);
            this.EType_txt.Name = "EType_txt";
            this.EType_txt.Size = new System.Drawing.Size(100, 21);
            this.EType_txt.TabIndex = 15;
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 376);
            this.Controls.Add(this.EType_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dept_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.EmployeeDetails);
            this.Controls.Add(this.BACK);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Label EmployeeDetails;
        private System.Windows.Forms.Label EmployeeName;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Dept_txt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox EType_txt;
    }
}