using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        public void SaveEmployee(Employee emp)
        {
            DbHelper.ExecuteNonQuery
                ( "InsertEmployee", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@EmployeeName", emp.EmployeeName),
                new SqlParameter("@EmployeeTypeId", emp.EmployeeTypeId),
                new SqlParameter("@Department", emp.Department),
                new SqlParameter("@HourlyPay", emp.HourlyPay),
                new SqlParameter("@BonusRate",emp.BonusRate)
                );
        }
        public void UpdateEmployee(Employee emp)
        {
            DbHelper.ExecuteNonQuery
                ("UpdateEmployee", System.Data.CommandType.StoredProcedure,
                new SqlParameter("@EmployeeId", emp.EmployeeId),
                new SqlParameter("@EmployeeName", emp.EmployeeName),
                new SqlParameter("@EmployeeTypeId", emp.EmployeeTypeId),
                new SqlParameter("@Department", emp.Department),
                new SqlParameter("@HourlyPay", emp.HourlyPay),
                new SqlParameter("@BonusRate", emp.BonusRate)
                );
        }
        public void DeleteEmployee(Employee emp)
        {
            DbHelper.ExecuteNonQuery("DeleteEmployee",System.Data.CommandType.StoredProcedure,new SqlParameter("@EmployeeId",emp.EmployeeId));
        }
    }
}
