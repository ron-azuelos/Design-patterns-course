using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class FlightSystemFaceadecs : IAdmin, ICompany, Icustomer
    {
        private FlightDAO dao = new FlightDAO();
        public void BuyTicket(string dest)
        {
            dao.BuyTicket(dest);
        }

        public void CencelFlight(string dest)
        {
            dao.CencelFlight(dest);
        }

        public void CreateCompany(string cName)
        {
            dao.CreateCompany(cName);
        }

        public void CreateCustomer(string cName)
        {
            dao.CreateCustomer(cName);
        }

        public void CreateFlight(string dest)
        {
            dao.CreateFlight(dest);
        }

        public void ShowMyTicket()
        {
            dao.ShowMyTicket();
        }
    }
}
