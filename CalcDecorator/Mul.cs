using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalculator
{
    class Mul : CalcDecoratorBasecs
    {
        public override string GetFormula()
        {
            return formula.GetFormula() + $" x {number}";
        }

        public override double GetResult()
        {
            return formula.GetResult() * number;
        }

        public Mul(IFormula nform, double num) : base(nform, num)
        {
        }
    }
}
