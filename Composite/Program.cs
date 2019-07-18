using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("Canvas root");
            Component circle1 = new Leaf("Circle 1");
            Component rectangle = new Leaf("Rectangle x");
            root.AddChild(circle1);
            root.AddChild(rectangle);

            Component container1 = new Composite("Container 1");
            Component circle2 = new Leaf("Circle 2");
            Component circle3 = new Leaf("Circle 3");
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite("Container of triangles");
            Component t1 = new Leaf("Triangle 1");
            Component t2 = new Leaf("Triangle 2");
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);

            root.Draw("");

            Console.WriteLine($"Leaf number of root :  { root.CountLeaf() } \n");
            Console.WriteLine($"Leaf number of container 1 : { container1.CountLeaf() } \n");
            Console.WriteLine($"Leaf number of container 2 : { container2.CountLeaf() } \n");
            Console.WriteLine($"Leaf number of Triangle 1 :  { t1.CountLeaf() } \n");

            Console.WriteLine("Is binary root : " + IsBinary(root));
            Console.WriteLine("Is binary container 1: " + IsBinary(container1));

        }

        static bool IsBinary(Component c)
        {
            if (!c.IsBinary())
            {
                return false;
            }

            if (c.GetChilds() == null || c.GetChilds().Count == 0)
            {
                return true;
            }

            return IsBinary(c.GetChilds()[0]) && IsBinary(c.GetChilds()[1]);
        }
    }
}
