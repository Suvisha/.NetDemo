using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class EmployeeManagerFactory
    {
        public IEmployeeSalaryManager GetEmployeeSalaryManager(String emptype)
        {
            IEmployeeSalaryManager ReturnValue = null;
            if(emptype=="permanent")
            {
                ReturnValue =new PermanentEmployeeSalaryManager();
            }
            if(emptype=="contract")
            {
                ReturnValue = new ContractEmployeeSalaryManager();
            }
            return ReturnValue;
        }
    }
}
