using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface ILightStatecs
    {
        ILightStatecs turnOn();
        ILightStatecs turnOff();

        ILightStatecs Fix();
    }
}
