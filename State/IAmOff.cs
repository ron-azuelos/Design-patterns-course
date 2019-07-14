using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class IAmOff : ILightStatecs
    {
        public ILightStatecs Fix()
        {
            Console.WriteLine("Nothing to fix [OFF]");
            return new IAmOff();
        }

        public ILightStatecs turnOff()
        {
            Console.WriteLine("Already off...");
            return new IAmOff();
        }



        public ILightStatecs turnOn()
        {
            Console.WriteLine("Turning ON.. ");
            return new IAmOn();
        }
    }
}
