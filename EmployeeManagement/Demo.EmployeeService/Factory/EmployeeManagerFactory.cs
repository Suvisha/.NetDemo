using Demo.EmployeeService.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.EmployeeService.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetManager(int EmployeeTypeId)
        {
            IEmployeeManager Manager = null;
            if(EmployeeTypeId==1)
            {
                Manager = new PermanentEmployeeManager();
            }
            else if(EmployeeTypeId==2)
            {
                Manager = new ContractEmployeeManager();
            }
            return Manager;
        }
    }
}