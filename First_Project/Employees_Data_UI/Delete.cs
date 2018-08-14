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
    public partial class Delete : Form
    {
        private readonly IEmployeeManager Manager = null;
        public Delete()
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
            emp.EmployeeId = Convert.ToInt32(Id_txt.Text);
            EmployeeManager Manager = new EmployeeManager();
            Manager.DeleteEmployee(emp);
            Id_txt.Text = "";
        }    
    }
}
