using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginState
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context(new newLogin());
            ctx.Login("1234"); // Should print secceeded || newLogin.login
            ctx.Login("12345"); // Should print already logged in | loginSucceed.login
            ctx.reStart(); // Should restart || loginSucceed.restart
            ctx.reStart(); // should restart || newLogin.restart
            ctx.Login("12345"); // Should print failure || newLogin.login
            ctx.Login("1234"); // Should print secceeded || loginFail.login
            ctx.reStart(); // Should restart || loginFail.restart
            ctx.Login("12345"); // Should print failure || loginFail.login
            ctx.Login("12345"); // Should print failure || loginFail.login
            ctx.Login("12345"); // Should lock || loginFail.login
            ctx.Login("1234"); // Shouldn't do a thing|| Locked.login
            ctx.reStart(); // Should restart || Locked.restart



            Console.ReadLine();

        }
    }
}
