using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClock
{
    class Program
    {
        static void Main(string[] args)
        {
            clock c1 = clock.getInstance();
            clock c2 = clock.getInstance();
            clock c3 = clock.getInstance();
            Console.Write("By c1, the time is: ");
            c1.printTime();

            Console.Write("By c2, the time is: ");
            c2.printTime();

            Console.Write("By c3, the time is: ");
            c3.printTime();


        }
    }
}
