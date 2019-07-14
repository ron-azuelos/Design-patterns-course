using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginState
{
    class Context
    {

        ILoginState state;

        public Context(ILoginState state)
        {
            this.state = state;
        }

        public void Login(string password)
        {
            this.state = state.Login(password);
        }

        public void reStart()
        {
            this.state = state.reStart();
        }
    }
}
