using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class circle : Shape
    {
        public Point center;

        public double area;
        public circle(Point center, double area)
        {
            this.area = area;
            this.center = center;
        }

        public override string ToString()
        {
            return $"Circle center {center} area = {area}";
        }

        public override Shape clone()
        {
            return new circle(center.clone(), area);
        }

    }
}
