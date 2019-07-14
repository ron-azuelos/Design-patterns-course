using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClock
{
    class clock
    {
        private static clock INSTANCE;
        private static object key = new object();

        private clock()
        { }

        public static clock getInstance()
        {
            if (INSTANCE != null)
            {
               return INSTANCE;
            }
            lock (key)
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new clock();
                }

                return INSTANCE;
            }
        }

        public void printTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}

