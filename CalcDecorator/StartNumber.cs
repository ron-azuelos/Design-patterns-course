using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalculator
{
    public class StartNumber : IFormula
    {
        double number;

        public StartNumber (double num)
        {
            this.number = num;
        }

        public string GetFormula()
        {
            return number.ToString();
        }

        public double GetResult()
        {
            return number;
        }
    }
}
