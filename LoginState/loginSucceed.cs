using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginState
{
    class loginSucceed : ILoginState
    {
        public ILoginState Login(string password)
        {
            Console.WriteLine("Already logged in ....");
            return this;
        }

        public ILoginState reStart()
        {
            Console.WriteLine("Restarting ... New Login!");
            return new newLogin();
        }
    }
}
