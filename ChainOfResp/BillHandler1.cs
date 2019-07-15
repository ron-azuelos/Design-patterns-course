using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandler1 : BillHandlerBase
    {
        public override void Handle(int Amount)
        {
            if (Amount == 0)
                return;

            if (Amount >= 1)
            {
                Console.WriteLine($"Giving 1 X {Amount / 1} bills");
            }

            if (Amount % 1 > 0)
            {
                if (next != null)
                {
                    next.Handle(Amount%1);
                }
                else
                {
                    Console.WriteLine($"Cant halp you anymore, {Amount % 1} left");
                }
            }

        }
    }
}
