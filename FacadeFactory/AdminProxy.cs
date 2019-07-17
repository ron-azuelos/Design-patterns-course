using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public class AdminProxy : ClientProxy,IAdmin
    {
        public void CreateCompany(string cName)
        {
            this.fsFacade.CreateCompany(cName);
        }

        public void CreateCustomer(string cName)
        {
            this.fsFacade.CreateCustomer(cName);
        }
    }
}
