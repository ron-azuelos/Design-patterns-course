using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginState
{
    public interface ILoginState
    {
        ILoginState Login(string password);

        ILoginState reStart();

    }
}
