using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    public abstract class LogHandlerBase
    {
        protected LogHandlerBase next;

        public abstract void Handle(int logLevel, string logMsg);

        public void SetNext(LogHandlerBase next)
        {
            this.next = next;
        }

    }
}
