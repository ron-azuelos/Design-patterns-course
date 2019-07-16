using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PerfectStore : IDBData
    {
        public void store(clientData cData)
        {
            Console.WriteLine("Perfect Store Storing");
            Console.WriteLine("=====================");
            Console.WriteLine($"Details- Name: {cData.Name}");
            Console.WriteLine($"         ID: {cData.ID}");
            Console.WriteLine("STORED! \n");
        }
    }
}
