using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke
                (
                    () => PrintEmployeeDetails(),
                    () => PrintStudentDetails()
                );
            Console.ReadLine();
        }

        private static void PrintStudentDetails()
        {
            Singleton FromStudent = Singleton.GetInstance;
            FromStudent.printDetails("FromStudent");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton FromEmployee = Singleton.GetInstance;
            FromEmployee.printDetails("FromEmployee");
        }
    }
}
