using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace TestingLog4Net
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            log.Info("Start testing");
            log.Debug("Fist log message");
        }
    }
}
