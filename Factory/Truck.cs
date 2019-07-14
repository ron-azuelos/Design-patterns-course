using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Truck : Vehicle
    {
        protected string driverCigaretteType;

        public Truck(string model, float cylinder, string color, int numberOfWheels, string driverCigaretteType) : base(model, cylinder, color, numberOfWheels)
        {
            this.driverCigaretteType = driverCigaretteType;
        }

        public override string ToString()
        {
            return "Truck  " + base.ToString() +", Driver Smokes" + $" {driverCigaretteType}";
        }
    }
}