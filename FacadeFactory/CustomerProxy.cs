using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class CustomerProxy : ClientProxy, Icustomer
    {
        public void BuyTicket(string dest)
        {
            this.fsFacade.BuyTicket(dest);
        }

        public void ShowMyTicket()
        {
            this.fsFacade.ShowMyTicket();
        }
    }
}
