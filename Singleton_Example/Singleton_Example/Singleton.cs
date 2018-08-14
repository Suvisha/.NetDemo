using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Example
{
    //public sealed class Singleton  // Sealed keyword prevent inheritance  nested class inheritance
    //{
    //    private static int counter = 0;
    //    private static readonly object obj = new object();
    //    private static Singleton Instance = null;
    //    public static Singleton GetInstance
    //    {
    //        get
    //        {
    //            if (Instance == null)  // double checked locking
    //            {
    //                lock (obj)          // prevent multi threading
    //                {
    //                    if (Instance == null)
    //                        Instance = new Singleton();
    //                }
    //            }
    //            return Instance;

    //        }
    //    }
    //    private Singleton()
    //    {
    //        counter++;
    //        Console.WriteLine("Counter Value " + counter.ToString());
    //    }
    //    public void printDetails(string Message)
    //    {
    //        Console.WriteLine(Message);
    //    }
    //}


    // Lazy vs eager

    public sealed class Singleton  // Sealed keyword prevent inheritance  nested class inheritance
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(()=>new Singleton());  // Lazy singleton
        public static Singleton GetInstance
        {
            get
            {
            
                return Instance.Value;

            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void printDetails(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
