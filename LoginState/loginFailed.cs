using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginState
{
    class loginFailed : ILoginState
    {
        private int failCount = 2;
        public ILoginState Login(string password)
        {
            if (failCount > 0)
            {
                if (string.Compare("1234", password) == 0)
                {
                    Console.WriteLine("Login Succeeded!");
                    return new loginSucceed();
                }

                else
                {
                    Console.WriteLine("Login Failed!");
                    failCount--;
                    if (failCount == 0)
                    {
                        Console.WriteLine("You have locked the system.");
                    }
                    return this;
                }
            }

            else
            {
                Console.WriteLine("You Failed 3 times. System is Locked!");
                return this;
            }
        }

        public ILoginState reStart()
        {
            Console.WriteLine("Restarting ... New Login!");
            return new newLogin();
        }
    }
}
