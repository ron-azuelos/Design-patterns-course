using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalculator
{
    public abstract class CalcDecoratorBasecs : IFormula
    {
        protected IFormula formula;
        protected double number;

        public CalcDecoratorBasecs(IFormula nformula, double num)
        {
            this.formula = nformula;
            this.number = num;
        }
        public abstract string GetFormula();

        public abstract double GetResult();
    }
}
