using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mycontext context = new Mycontext();
            Employee emp = new Employee()
            {
                EmpId = 1,
                EmpName = "sush",
                EmpAddress ="Banglore"
            };
            context.Employees.Add(emp);
            context.SaveChanges();
        }
    }
}
