﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IEmployeeSalaryManager
    {
          int CalculateHourlyPay();
          int CalculateBonusRate();
          int GetEmployeeTypeId();  
    }
}
