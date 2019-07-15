using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandler100 : BillHandlerBase
    {
        public override void Handle(int Amount)
        {
            if (Amount == 0)
                return;

            if (Amount >= 100)
            {
                Console.WriteLine($"Giving 100 X {Amount / 100} bills");
            }

            if (Amount % 100 > 0)
            {
                if (next != null)
                {
                    next.Handle(Amount%100);
                }
                else
                {
                    Console.WriteLine($"Cant halp you anymore, {Amount % 100} left");
                }
            }

        }
    }
}
