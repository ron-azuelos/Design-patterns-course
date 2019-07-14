using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginState
{
    class newLogin : ILoginState
    {
        public ILoginState Login(string password)
        {
            if (string.Compare("1234", password) == 0)
            {
                Console.WriteLine("Login Succeeded!");
                return new loginSucceed();
            }

            else
            {
                Console.WriteLine("Login Failed!");
                return new loginFailed();
            }
        }

        public ILoginState reStart()
        {
            Console.WriteLine("Restarting ... New Login!");
            return new newLogin();
        }
    }
}
