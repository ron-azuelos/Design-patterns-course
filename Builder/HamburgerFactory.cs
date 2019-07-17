using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HamburgerFactory
    {
        public Hamburger createBurger(string burgerType)
        {
            if (burgerType == "veggie light")
            {
                VeggHambBuilderLettuce vb = new VeggHambBuilderLettuce();
                vb.BuildHamburger();
                Console.WriteLine("Creating veggie light burger");
                return vb.GetHamburger();
            }
            else if (burgerType == "veggie")
            {
                VeggHamburgerBuilder v = new VeggHamburgerBuilder();
                v.BuildHamburger();
                Console.WriteLine("Creating veggie burger");
                return v.GetHamburger();
            }
            else if (burgerType == "susu")
            {
                SusuBuilder s = new SusuBuilder();
                s.BuildHamburger();
                Console.WriteLine("Creating susu burger");
                return s.GetHamburger();
            }
            else if (burgerType == "susu lettuce")
            {
                SusuBuilderLettuce sl = new SusuBuilderLettuce();
                sl.BuildHamburger();
                Console.WriteLine("Creating susu lettuce burger");
                return sl.GetHamburger();
            }
            else
                return null;
        }
    }
}
