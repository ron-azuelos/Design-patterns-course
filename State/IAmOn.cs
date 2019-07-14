using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class IAmOn : ILightStatecs
    {
        public ILightStatecs Fix()
        {
            Console.WriteLine("Nothing to fiz [ON]");
            return new IAmOff();
        }

        public ILightStatecs turnOff()
        {
            Console.WriteLine("Turning off.. ");
            return new IAmOff();
        }

        public ILightStatecs turnOn()
        {
            Console.WriteLine("You Broke it! Noob ");
            return new IAmBroken();
        }
    }
}
