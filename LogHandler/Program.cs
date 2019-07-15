using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHandlerBase logHandlerFatal = new LogHandlerFatal();
            LogHandlerBase logHandlerError = new LogHandlerError();
            LogHandlerBase logHandlerInfo = new LogHandlerInfo();
            LogHandlerBase logHandlerDebug = new LogHandlerDebug();

            logHandlerFatal.SetNext(logHandlerError);
            logHandlerError.SetNext(logHandlerInfo);
            logHandlerInfo.SetNext(logHandlerDebug);

            LogHandlerBase root = logHandlerFatal;

            Console.WriteLine("Exercise 1: ascending order concatination");
            Console.WriteLine("=========================================\n");

            root.Handle(1, "System ig goig down!");
            root.Handle(2, "Can't write to storage machine");
            root.Handle(3, "CPU is over 70%");
            root.Handle(4, "User connected");


            LogHandlerBase logHandlerFatal2 = new LogHandlerFatal();
            LogHandlerBase logHandlerError2 = new LogHandlerError();
            LogHandlerBase logHandlerInfo2 = new LogHandlerInfo();
            LogHandlerBase logHandlerDebug2 = new LogHandlerDebug();

            logHandlerDebug2.SetNext(logHandlerInfo2);
            logHandlerInfo2.SetNext(logHandlerError2);
            logHandlerError2.SetNext(logHandlerFatal2);

            LogHandlerBase root2 = logHandlerDebug2;


            Console.WriteLine("Exercise 2: descending order concatination");
            Console.WriteLine("=========================================\n");

            root2.Handle(1, "System ig goig down!");
            root2.Handle(2, "Can't write to storage machine");
            root2.Handle(3, "CPU is over 70%");
            root2.Handle(4, "User connected");

        }
    }
}
