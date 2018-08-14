using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExample
{
    public class User
    {
        public  virtual int UserId()
        {
            return 5;
        }
    }
    public class Class1
    {
        public int print(User u)
        {

            return u.UserId();
        }
    }
}
