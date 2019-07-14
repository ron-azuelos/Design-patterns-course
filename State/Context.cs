using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        ILightStatecs state;

        public Context(ILightStatecs state)
        {
            this.state = state;
        }

        public void pressedOn()
        {
            this.state = state.turnOn();
        }

        public void pressedOff()
        {
            this.state = state.turnOff();
        }

        public void fixLight()
        {
            this.state = state.Fix();
        }
    }
}