using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace Employees_Data_UI
{
    public partial class ViewAll : Form
    {
        public ViewAll()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();      
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            EmployeeManager em = new EmployeeManager();
            dataGridView1.DataSource = em.GetAllEmployee();
        }
    }
}
