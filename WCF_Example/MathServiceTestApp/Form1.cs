using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceTestApp.MathService;

namespace MathServiceTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           SimpleServiceClient loclient = new SimpleServiceClient();
           int num1 = Convert.ToInt32(txtnum1.Text);
           int num2 = Convert.ToInt32(txtnum2.Text);
           if(comboBox1.Text=="ADD")
           {
               textBox1.Text =(loclient.Add(num1,num2)).ToString();
           }
           else if(comboBox1.Text=="SUBSTRACT")
           {
               textBox1.Text =loclient.Substract(num1,num2).ToString();
           }
           else if (comboBox1.Text == "MULTIPLY")
           {
               textBox1.Text =loclient.Multiply(num1,num2).ToString();
           }
           else if (comboBox1.Text == "DIVIDE")
           {
               textBox1.Text = loclient.Divide(num1,num2).ToString();
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



