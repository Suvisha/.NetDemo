using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BAL
{
   public interface IEmployeeManager
    {
       void SaveEmployee(Employee emp);
       void DeleteEmployee(Employee emp);
       void UpdateEmployee(Employee emp);
    }
}
