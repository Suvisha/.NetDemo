using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggingExample
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
             XmlConfigurator.Configure();
             _log.Debug("Iam Debugging");
             _log.Info("info");
             _log.Warn("Warn");
             _log.Error("error");
             _log.Fatal("fatal");
            print();
            customClass.Disp();
            Console.ReadLine();
        }
        public static void print()
        {
            string text = System.IO.File.ReadAllText(@"C:\\Users\Public\Testfolder\log.txt");
            System.Console.WriteLine("Contents of log.txt = {0}", text);
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\Public\Testfolder\log.txt");
            System.Console.WriteLine("Contents of log.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
    }
}
