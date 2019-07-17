using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public interface ICompany
    {
        void CreateFlight(string dest);
        void CencelFlight(string dest);
    }
}
