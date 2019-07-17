using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SusuBuilder : HamburgerBuilder
    {
        protected override void PrepareBun()
        {
            hamburger.PrepareBun("Briosh");
        }

        protected override void PrepareMain()
        {
            hamburger.PrepareMain("Ribeye");
        }

        protected override void PrepareTopping()
        {
            hamburger.PrepareTopping("Chedder & Mushrooms");
        }

        protected override void PrepareVegg()
        {
            hamburger.PrepareVegg("Tomato and cucumber");
        }

        protected override void PreparePriceLabel()
        {
            hamburger.PreparePriceLabel("Today sale - 65 ILS");
        }
    }
}