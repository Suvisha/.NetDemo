using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoApp
{
    class Employee
    {
        private string _ename;
        private int _eid;

        public int Eid
        {
            get 
            { 
                return _eid; 
            }
            set 
            {   if(value<0)
                    Console.WriteLine("value less than zero");
                else
                    _eid = value; 
            }
        }
        public string Ename
        {
            get
            {
                return _ename;
            }
            set
            {
                    _ename = value;
            }
        }
    }
}
