using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginState
{
    class Locked : ILoginState
    {
        public ILoginState Login(string password)
        {
            Console.WriteLine("system is locked. restart to continue");
            return this;
        }

        public ILoginState reStart()
        {
            Console.WriteLine("Restarting ... New Login!");
            return new newLogin();
        }
    }
}
