using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            BillHandlerBase billHandler100 = new BillHandler100();
            BillHandlerBase billHandler200 = new BillHandler200();
            BillHandlerBase billHandler25 = new BillHandler25();
            BillHandlerBase billHandler5 = new BillHandler5();
            BillHandlerBase billHandler500 = new BillHandler500();
            BillHandlerBase billHandler1 = new BillHandler1();

            billHandler500.SetNext(billHandler200);
            billHandler200.SetNext(billHandler100);
            billHandler100.SetNext(billHandler25);
            billHandler25.SetNext(billHandler5);
            billHandler5.SetNext(billHandler1);

            BillHandlerBase root = billHandler500;

            Console.WriteLine("Amount: 200");
            Console.WriteLine("===========");
            root.Handle(200);

            Console.WriteLine("Amount: 100");
            Console.WriteLine("===========");
            root.Handle(100);

            Console.WriteLine("Amount: 25");
            Console.WriteLine("===========");
            root.Handle(25);

            Console.WriteLine("Amount: 10");
            Console.WriteLine("===========");
            root.Handle(10);

            Console.WriteLine("Amount: 4");
            Console.WriteLine("===========");
            root.Handle(4);

            Console.WriteLine("Amount: 183");
            Console.WriteLine("===========");
            root.Handle(183);

            Console.WriteLine("Amount: 7");
            Console.WriteLine("===========");
            root.Handle(7);

            Console.WriteLine("Amount: 5");
            Console.WriteLine("===========");
            root.Handle(5);

            Console.WriteLine("Amount: 10000");
            Console.WriteLine("===========");
            root.Handle(10000);


            Console.ReadLine();


        }
    }
}
