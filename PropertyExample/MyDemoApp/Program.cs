using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            { 
               new Employee(){
                Eid = 2,
                Ename = "suvisha"
               },
               new Employee(){
                   Eid = 3,
                   Ename = "Aangi"
                }
            };
            foreach(Employee e in emp)
            { 
                Console.WriteLine("eid : {0}\n ename  : {1}",e.Eid,e.Ename);
            }
        }
    }
}
