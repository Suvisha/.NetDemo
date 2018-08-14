using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromDatabase
{
    class Program
    {
        static void Main(string[] args)
        { 
            using(var db=new SampleSqlEntities())
            {
                var query = from b in db.Customers orderby b.customer_id select b;
                Console.WriteLine("All Customers:");
                foreach(var item in query)
                {
                    Console.WriteLine(item.first_name+" "+item.last_name);
                }
            }
        }
    }
}
