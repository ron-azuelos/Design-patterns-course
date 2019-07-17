using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class FlightDAO
    {
        public void BuyTicket(string dest)
        {
            Console.WriteLine($"Ticket to {dest} is bought!");
        }

        public void CencelFlight(string dest)
        {
            Console.WriteLine($"Flight to {dest} was cenceled!");
        }

        public void CreateCompany(string cName)
        {
            Console.WriteLine($"Company {cName} was created!");
        }

        public void CreateCustomer(string cName)
        {
            Console.WriteLine($"Customer {cName} was created!");
        }

        public void CreateFlight(string dest)
        {
            Console.WriteLine($"Flight to {dest} was created!");
        }

        public void ShowMyTicket()
        {
            Console.WriteLine("NAME: Ron Azuelos");
            Console.WriteLine("=================");
            Console.WriteLine("25/07/19- London Luton");
            Console.WriteLine("30/08/19- New York JFK");
            Console.WriteLine("05/10/19- Bangkok");
        }
    }
}
