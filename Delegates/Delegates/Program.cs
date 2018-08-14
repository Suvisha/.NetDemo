using System;

namespace Delegates
{
    delegate void print(String st);
    class Program
    {
        static void Main(string[] args)
        {
            print p = delegate(string j)
            {
                Console.WriteLine(j);
            };
            print del = (n) => { string st ="world"; 
                               Console.WriteLine(st); };
            // Lambda statement
            p("Using direct Delegates");
            p = new print(Program.NamedMethod);
            p("Using Named Method");
            
        }
        static void NamedMethod(string s)
        {
            Console.WriteLine(s);
        }
    }
}
