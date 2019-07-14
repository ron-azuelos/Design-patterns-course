using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class IAmBroken : ILightStatecs
    {
        public ILightStatecs Fix()
        {
            Console.WriteLine("FIXED! Whatch out next time! ");
            return new IAmOff();
        }

        public ILightStatecs turnOff()
        {
            Console.WriteLine("Can't help you Sir. You Broke it. [OFF]");
            return new IAmBroken();
        }

        public ILightStatecs turnOn()
        {
            Console.WriteLine("Can't help you Sir. You Broke it. [ON]");
            return new IAmBroken();
        }
    }
}
