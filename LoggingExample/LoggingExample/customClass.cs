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
    class customClass
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public static void Disp()
        {
            _log.Debug("Iam Debugging");
            _log.Info("info");
            _log.Warn("Warn");
            _log.Error("error");
            _log.Fatal("fatal");
            
        }
    }
}
