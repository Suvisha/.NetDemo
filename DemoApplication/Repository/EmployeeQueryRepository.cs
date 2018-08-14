using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeQueryRepository
    {
        public Employees SearchResult(int EmpId)
        {
            SqlDataReader sdr = DbClass.ExecuteReader("SearchEmployeeData", System.Data.CommandType.StoredProcedure,
                                                        new SqlParameter("@EmployeeId",EmpId)
                                                     );
            Employees emp=new Employees();
            while(sdr.Read())
            {
                emp.EmployeeName = sdr["EmployeeName"].ToString();
                emp.Department = sdr["Department"].ToString();
                emp.EmployeeTypeId = Convert.ToInt32(sdr["EmployeeTypeId"]);
            }
            return emp;
        }
        public DataTable ShowEmployees()
        {
            SqlDataReader sdr = DbClass.ExecuteReader("ShowEmployeeData", System.Data.CommandType.StoredProcedure);
            DataTable listEmployee = new DataTable();
            listEmployee.Load(sdr);
            return listEmployee;
        }
    }
}
