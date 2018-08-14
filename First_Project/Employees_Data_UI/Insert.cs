using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BAL;


namespace Employees_Data_UI
{
    public partial class Insert : Form
    {
        private readonly IEmployeeManager Manager = null;
        public Insert()
        {
            InitializeComponent();
        }     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeName =Name_txt.Text;
            emp.Department = Dept_txt.Text;
            emp.EmployeeType = EType_txt.Text;
            EmployeeManager Manager = new EmployeeManager();
            Manager.SaveEmployee(emp);
            Name_txt.Text = "";
            Dept_txt.Text = "";
            EType_txt.Text = "";
        }        
    }
}
