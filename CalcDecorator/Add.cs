using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalculator
{
    class Add : CalcDecoratorBasecs
    {
        public override string GetFormula()
        {
            return formula.GetFormula() + $" + {number}";
        }

        public override double GetResult()
        {
            return formula.GetResult() + number;
        }

        public Add(IFormula nform, double num) : base(nform, num)
        {
        }
    }
}
