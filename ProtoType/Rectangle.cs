using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Rectangle : Shape
    {
        public Point p1;
        public Point p2;
        public Point p3;
        public Point p4;

        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;

        }
        public override string ToString()
        {
            return $"Rectendle 1st {p1}, 2nd {p2}, 3rd {p3} 4th {p4}";
        }

        public override Shape clone()
        {
            return new Rectangle(p1.clone(), p2.clone(), p3.clone(), p4.clone());
        }
    }
}
