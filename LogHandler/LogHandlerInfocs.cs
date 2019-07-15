using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    class LogHandlerInfo : LogHandlerBase
    {
        public override void Handle(int logLevel, string logMsg)
        {
            if (logLevel == 3)
            {
                Console.WriteLine("Info: " + logMsg + "\n");
            }
            else if (next != null)
            {
                next.Handle(logLevel, logMsg);
            }
            else
            {
                Console.WriteLine("Wrong error message! \n");
            }
        }
    }
}
