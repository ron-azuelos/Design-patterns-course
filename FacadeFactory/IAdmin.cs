using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyFacade
{
    public interface IAdmin
    {
        void CreateCustomer(string cName);
        void CreateCompany(string cName);

    }
}
