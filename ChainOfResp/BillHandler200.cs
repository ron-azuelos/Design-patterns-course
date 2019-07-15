using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    public class BillHandler200 : BillHandlerBase
    {
        public override void Handle(int Amount)
        {
            if (Amount == 0)
                return;

            if (Amount >= 200)
            {
                Console.WriteLine($"Giving 200 X {Amount / 200} bills");
            }

            if (Amount % 200 > 0)
            {
                if (next != null)
                {
                    next.Handle(Amount%200);
                }
                else
                {
                    Console.WriteLine($"Cant halp you anymore, {Amount % 200} left");
                }
            }

        }
    }
}
