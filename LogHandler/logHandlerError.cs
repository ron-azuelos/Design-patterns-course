using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    class LogHandlerError : LogHandlerBase
    {
        public override void Handle(int logLevel, string logMsg)
        {
            if (logLevel == 2)
            {
                Console.WriteLine("Error: " + logMsg + "\n");
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
