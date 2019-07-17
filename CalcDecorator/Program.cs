using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("First Calculation:");
            Console.WriteLine("==================");
            IFormula formula = new StartNumber(5);

            IFormula mulFormula = new Mul(formula, 2);

            IFormula addFormula = new Add(mulFormula, 100);

            IFormula divformula = new Div(addFormula, 12);

            IFormula subFormula = new Sub(divformula, 3);

            IFormula mulFormula2 = new Mul(subFormula, 4);

            IFormula addFormula2 = new Add(mulFormula2, 7);

            Console.WriteLine("Formula: " + addFormula2.GetFormula());
            Console.WriteLine($"Result: {addFormula2.GetResult()} \n");


            Console.WriteLine("Second Calculation:");
            Console.WriteLine("==================");
            IFormula nformula = new StartNumber(30);

            IFormula nmulFormula = new Mul(nformula, 2);

            IFormula naddFormula = new Add(nmulFormula, 100);

            IFormula ndivformula = new Div(naddFormula, 12);

            IFormula nsubFormula = new Sub(ndivformula, 3);

            IFormula nmulFormula2 = new Mul(nsubFormula, 4);

            IFormula naddFormula2 = new Add(nmulFormula2, 7);

            Console.WriteLine("Formula: " + naddFormula2.GetFormula());
            Console.WriteLine($"Result: {naddFormula2.GetResult()} \n");




        }
    }
}
