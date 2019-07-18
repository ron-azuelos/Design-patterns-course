using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : Component
    {
        IList<Component> childs = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }

        public override void Draw(string space)
        {
            Console.WriteLine(space + this.name);
            foreach (Component c in childs)
            {
                c.Draw(space + "    ");
            }
        }

        public override int CountLeaf()
        {
            int count = 0;
            foreach (Component child in childs)
            {
                count += child.CountLeaf();
            }
            return count;
        }

        public override bool IsBinary()
        {
            if ((childs.Count == 2) || (childs.Count == 0))
            {
                return true;
            }

            return false;
        }
    }
}
