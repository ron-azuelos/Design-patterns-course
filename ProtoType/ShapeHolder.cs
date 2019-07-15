using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class ShapeHolder : IPrototype<ShapeHolder>
    {

        public List<Shape> shapeList = new List<Shape>();
        public ShapeHolder clone()
        {
            ShapeHolder sh = new ShapeHolder();
            
            foreach (Shape s in shapeList)
            {
                sh.shapeList.Add(s.clone());
            }

            return sh;
        }
    }
}
