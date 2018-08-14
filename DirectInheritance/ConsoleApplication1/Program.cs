using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class House
    {
        public virtual void show()
        {
            Console.WriteLine("Base Class");
        }
      /*  public override string ToString()
        {
            string disp="Name is"+name+",location="+location.ToString();
            return disp;
        }*/
    }
    class room:House
    {
        public void showMe()
        {
            System.Console.WriteLine("Me!");
        }
        public override void show()
        {
            Console.WriteLine("Child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            room r = new room();
            r.show();
            r.showMe();
            System.Console.Read();
        }
    }
}
