using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAL
{
    public class EmployeeManager
    {
        private readonly IEmployeeCommandRepository commandRepository=null;
        private readonly IEmployeeQueryRepository queryRepository = null;
        public EmployeeManager()
        {
            commandRepository = new EmployeeCommandRepository();
            queryRepository = new EmployeeQueryRepository();
        }
        public void SaveEmployee(Employee emp)
        {
            if (emp.EmployeeTypeId == 1)
            {
                PermanentEmployeeSalaryManager pe = new PermanentEmployeeSalaryManager();
                emp.HourlyPay = pe.CalculateHourlyPay();
                emp.BonusRate = pe.CalculateBonusRate();
            }
            else if (emp.EmployeeTypeId == 2)
            {
                ContractEmployeeSalaryManager ce = new ContractEmployeeSalaryManager();
                emp.HourlyPay = ce.CalculateHourlyPay();
                emp.BonusRate = ce.CalculateBonusRate();
            }
            commandRepository.SaveEmployee(emp);
        }
        public void DeleteEmployee(Employee emp)
        {
            commandRepository.DeleteEmployee(emp);
        }
        public void UpdateEmployee(Employee emp)
        {
            if (emp.EmployeeTypeId == 1)
            {
                PermanentEmployeeSalaryManager pe = new PermanentEmployeeSalaryManager();
                emp.HourlyPay = pe.CalculateHourlyPay();
                emp.BonusRate = pe.CalculateBonusRate();
            }
            else if (emp.EmployeeTypeId == 2)
            {
                ContractEmployeeSalaryManager ce = new ContractEmployeeSalaryManager();
                emp.HourlyPay = ce.CalculateHourlyPay();
                emp.BonusRate = ce.CalculateBonusRate();
            }
            commandRepository.UpdateEmployee(emp);
        }
        public DataTable GetAllEmployee()
        {
            DataTable dt;
            dt = queryRepository.GetAllEmployee();
            return dt;
        }
    }
}