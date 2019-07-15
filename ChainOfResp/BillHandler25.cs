using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandler25 : BillHandlerBase
    {
        public override void Handle(int Amount)
        {
            if (Amount == 0)
                return;

            if (Amount >= 25)
            {
                Console.WriteLine($"Giving 25 X {Amount / 25} bills");
            }

            if (Amount % 25 > 0)
            {
                if (next != null)
                {
                    next.Handle(Amount%25);
                }
                else
                {
                    Console.WriteLine($"Cant halp you anymore, {Amount % 25} left");
                }
            }

        }
    }
}
