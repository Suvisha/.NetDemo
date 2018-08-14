using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        //public List<Employee> GetAllEmployees()
        //{
        //    List<Employee> employees = new List<Employee>();
        //    SqlDataReader reader = DbHelper.ExecuteReader("GetEmployee", System.Data.CommandType.StoredProcedure);
        //    while (reader.Read())
        //    {
        //        employees.Add(new Employee()
        //            {
        //                EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
        //                EmployeeName = reader["EmployeeName"].ToString(),
        //                Department = reader["Department"].ToString(),
        //                HourlyPay = Convert.ToInt32(reader[" HourlyPay"]),
        //                BonusRate = Convert.ToInt32(reader["BonusRate"]),
        //                EmployeeTypeId = Convert.ToInt32(reader["EmployeeTypeId"])
        //            }
        //         );
        //    }
        //    return employees;
        //}
        //public List<Employee> GetEmployee()
        //{
        //    List<Employee> emp = new List<Employee>();
        //    SqlDataReader reader = DbHelper.ExecuteReader("EmployeeDetails", System.Data.CommandType.StoredProcedure);
        //    while (reader.Read())
        //    {
        //        emp.Add(new Employee()
        //        {
        //            EmployeeName = reader["EmployeeName"].ToString(),
        //            Department = reader["Department"].ToString()
        //        }
        //        );
        //    }
        //    return emp;
        //}
        public DataTable GetAllEmployee()
        {
            DataTable dt = new DataTable();
            SqlDataReader sr = DbHelper.ExecuteReader("GetEmployee", System.Data.CommandType.StoredProcedure);
            dt.Load(sr);
            return dt;
        }      
    }
}