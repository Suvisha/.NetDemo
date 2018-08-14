using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public int HourlyPay { get; set; }
        public int BonusRate { get; set; }
        public int EmployeeTypeId { get; set;}
        public string EmployeeType { get; set; }
    }
}
