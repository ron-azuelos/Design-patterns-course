using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory fp = new ProxyFactory();

            ClientProxy cp = fp.Login("Ron", "1702");
            (cp as AdminProxy).CreateCompany("ELAL");
            (cp as AdminProxy).CreateCustomer("Itay");

            Console.WriteLine();

            cp = fp.Login("May", "1234");
            (cp as CustomerProxy).BuyTicket("Singapore");
            (cp as CustomerProxy).ShowMyTicket();

            Console.WriteLine();

            cp = fp.Login("UnitedArilines", "7777");
            (cp as CompanyProxy).CreateFlight("Russia");
            (cp as CompanyProxy).CencelFlight("Makadonia");

            Console.WriteLine();



            cp = fp.Login("Itay", "1702");

        }
    }
}
