using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BAL
{
    public class PermanentEmployeeSalaryManager : IEmployeeSalaryManager
    {
        public int HourlyPay { set; get; }
        public int BonusRate { get; set; }
        public int CalculateHourlyPay()
        {
            HourlyPay = 30;
            return HourlyPay;
        }
        public int CalculateBonusRate()
        {
            BonusRate = 7;
            return BonusRate;
        }
        public int GetEmployeeTypeId()
        {
            return 1;
        }
    }
    
}
