using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        List<TextMemento> lMemento = new List<TextMemento>();
        int index = -1;

        public void AddMemento(TextMemento memento)
        {
            if ((lMemento.Count > 1) & (index < lMemento.Count - 1))
            {
                lMemento.RemoveRange(index + 1, lMemento.Count - index - 1);
            }
            
            this.lMemento.Add(memento);
            index++;
        }

        public TextMemento GetLast()
        {

            if ((index > -1) & (lMemento.Count > 0))
            {
                index--;
                return this.lMemento[index + 1];
            }

            return new TextMemento("Error you can't do undo !");
            
            
        }

        public TextMemento GetNext()
        {

            if((index < lMemento.Count - 1 ) & ((lMemento.Count > 0)))
            {
                index++;
                return this.lMemento[index];
            }

            return new TextMemento("Error you can't do redo !");
            
        }
    }
}
