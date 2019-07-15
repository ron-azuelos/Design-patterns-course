using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandler500 : BillHandlerBase
    {
        public override void Handle(int Amount)
        {
            if (Amount == 0)
                return;

            if (Amount >= 500)
            {
                Console.WriteLine($"Giving 500 X {Amount / 500} bills");
            }

            if (Amount % 500 > 0)
            {
                if (next != null)
                {
                    next.Handle(Amount%500);
                }
                else
                {
                    Console.WriteLine($"Cant halp you anymore, {Amount % 500} left");
                }
            }

        }
    }
}
