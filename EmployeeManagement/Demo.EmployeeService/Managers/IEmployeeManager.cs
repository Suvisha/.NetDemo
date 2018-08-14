using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EmployeeService.Managers
{
    public interface IEmployeeManager
    {
        int GetBonusRate();
        int GetHourlyPay();
    }
}
