using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class CompanyProxy : ClientProxy, ICompany
    {
        public void CencelFlight(string dest)
        {
            this.fsFacade.CencelFlight(dest);
        }

        public void CreateFlight(string dest)
        {
            this.fsFacade.CreateFlight(dest);
        }
    }
}
