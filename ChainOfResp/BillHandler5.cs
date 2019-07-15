using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandler5 : BillHandlerBase
    {
        public override void Handle(int Amount)
        {
            if (Amount == 0)
                return;

            if (Amount >= 5)
            {
                Console.WriteLine($"Giving 5 X {Amount / 5} bills");
            }

            if (Amount % 5 > 0)
            {
                if (next != null)
                {
                    next.Handle(Amount%5);
                }
                else
                {
                    Console.WriteLine($"Cant halp you anymore, {Amount % 5} left");
                }
            }

        }
    }
}
