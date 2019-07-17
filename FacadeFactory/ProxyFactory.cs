using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class ProxyFactory
    {
        public ClientProxy Login(string uName, string password)
        {
            if (uName == "May" && password == "1234")
            {
                Console.WriteLine("Logged as Customer: May");
                return new CustomerProxy();
            }
            else if (uName == "UnitedArilines" && password == "7777")
            {
                Console.WriteLine("Logged as Company: UnitedAirlines");
                return new CompanyProxy();
            }
            else if (uName == "Ron" && password == "1702")
            {
                Console.WriteLine("Logged as Administrator: Ron");
                return new AdminProxy();
            }
            else
            {
                Console.Write("Cannot connect... \n");
                return null;
            }
        }
    }
}
