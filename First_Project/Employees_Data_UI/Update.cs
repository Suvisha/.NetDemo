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
    public partial class Update : Form
    {
        private readonly IEmployeeManager employeeManager = null;
        public Update()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBox3.Text);
            emp.EmployeeName = textBox1.Text; 
            emp.Department = textBox2.Text;
            emp.EmployeeType=comboBox1.Text;
            EmployeeManager em = new EmployeeManager();
            em.UpdateEmployee(emp);
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }  
    }
}
