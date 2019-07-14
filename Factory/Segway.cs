using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Segway : Vehicle
    {
        protected string indianWhoSoldIt;

        public Segway(string model, float cylinder, string color, int numberOfWheels, string indianWhoSoldIt) : base(model, cylinder, color, numberOfWheels)
        {
            this.indianWhoSoldIt = indianWhoSoldIt;
        }

        public override string ToString()
        {
            return "Segway  " + base.ToString() + ", The indian guy who sold us the segway:" + $" {indianWhoSoldIt}";
        }
    }
}