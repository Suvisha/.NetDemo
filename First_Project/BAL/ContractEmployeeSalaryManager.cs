using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ContractEmployeeSalaryManager: IEmployeeSalaryManager
    {
        public int HourlyPay { set; get; }
        public int BonusRate { get; set; }
        public int CalculateHourlyPay() 
        {
            HourlyPay = 23;
            return HourlyPay;
        }
        public int CalculateBonusRate()
        {
            BonusRate = 5;
            return BonusRate;
        }
        public int GetEmployeeTypeId()
        {
            return 2;
        }
    }
}
