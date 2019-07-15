using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Shape c = new circle(new Point(5, 5), 50.5);

            Console.WriteLine("First circle:");
            Console.WriteLine("=============");

            Console.WriteLine(c + "\n");

            DoStuffWithCircle(c.clone() as circle);

            Console.WriteLine("First circle after change:");
            Console.WriteLine("==========================");

            Console.WriteLine(c + "\n");


            Shape r = new Rectangle(new Point(0, 0), new Point(0, 2), new Point(2, 4), new Point(0, 4));

            Console.WriteLine("First Rectangle:");
            Console.WriteLine("===============");
            Console.WriteLine(r + "\n");
            DoStuffWithRectangle(r.clone() as Rectangle);

            Console.WriteLine("First Rectangle after change:");
            Console.WriteLine("=============================");
            Console.WriteLine(r + "\n");

            ShapeHolder container1 = new ShapeHolder();
            container1.shapeList.Add(c);
            container1.shapeList.Add(r);

            ShapeHolder container2 = container1.clone();

            Console.WriteLine("First Container:");
            Console.WriteLine("================");
            foreach (Shape s in container1.shapeList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Second Container:");
            Console.WriteLine("=================");
            foreach (Shape s in container2.shapeList)
            {
                Console.WriteLine(s);
            }

            (c as circle).area = 30;

            Console.WriteLine("First Container after change:");
            Console.WriteLine("=============================");
            foreach (Shape s in container1.shapeList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Second Container after change:");
            Console.WriteLine("==============================");

            foreach (Shape s in container2.shapeList)
            {
                Console.WriteLine(s);
            }


        }

        public static void DoStuffWithCircle(circle c)
        {
            c.center.X = 15;
            c.area = -5;
        }

        public static void DoStuffWithRectangle(Rectangle r)
        {
            r.p1.X = 8;
            r.p3.Y = 7;
        }
    }
}
