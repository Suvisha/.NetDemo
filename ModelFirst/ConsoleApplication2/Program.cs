using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication2.Models;
namespace ConsoleApplication2
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }
        public int DepartmentId { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
