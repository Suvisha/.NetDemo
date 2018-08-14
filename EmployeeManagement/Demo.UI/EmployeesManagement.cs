using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.UI
{
    public partial class EmployeesManagement : Form
    {
        public EmployeesManagement()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            Employee emp = new Employee()
            {
                EmployeeName = txtEmployeeName.Text,
                Designation = txtDesignation.Text,
                EmployeeType = new EmployeeType()
                {
                       EmployeeTypeId = combEmployeeTypes.SelectedIndex + 1,
                       EmployeeTypeName = combEmployeeTypes.SelectedItem.ToString()
                }
            };

            int id = client.SaveEmployee(emp);
            txtEmployeeId.Text = id.ToString();
            MessageBox.Show("Employee Saved...");
            txtEmployeeId.Text = "";
            txtEmployeeName.Text = "";
            txtDesignation.Text = "";
            lalBonus.Text = "";
            lalHourly.Text = "";
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text != string.Empty)
            {
                EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
                int employeeIdToDelete = Convert.ToInt32(txtEmployeeId.Text);

                if (employeeIdToDelete > 0)
                {
                    client.DeleteEmployee(employeeIdToDelete);
                    MessageBox.Show("Employee Deleted...");
                }
            }
            txtEmployeeId.Text = "";
        }

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            Employee emp = client.GetEmployeeById(Convert.ToInt32(txtEmployeeId.Text));

            if (emp != null)
            {
                txtEmployeeName.Text = emp.EmployeeName;
                txtDesignation.Text = emp.Designation;
                combEmployeeTypes.SelectedIndex = emp.EmployeeType.EmployeeTypeId - 1;
                lalBonus.Text = emp.BonusRate.ToString();
                lalHourly.Text = emp.HourlyPay.ToString();
            }        
        }
        
    }
}
