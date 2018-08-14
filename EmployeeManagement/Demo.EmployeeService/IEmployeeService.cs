using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Demo.EmployeeService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployeeById(int employeeId);

        [OperationContract]
        List<Employee> GetAllEmployees();

        [OperationContract]
        int SaveEmployee(Employee employee);

        [OperationContract]
        void DeleteEmployee(int id);
    }
}
