using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Store regular data: ");
            clientData dbData = new clientData("BLA", 1);
            PerfectStore pStore = new PerfectStore();
            pStore.store(dbData);

            Console.WriteLine("Store bad web data: ");
            WebClientData wData = new WebClientData("BLA", 1, "12345", true);
            WebClientDataStore wdStore = new WebClientDataStore();
            wdStore.BadStore(wData);
            wdStore.store(wData);
        }
    }
}
