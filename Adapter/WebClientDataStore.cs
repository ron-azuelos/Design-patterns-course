using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClientDataStore : IDBWebDate
    {
        public void BadStore(WebClientData wbData)
        {
            Console.WriteLine("Bad Store Storing");
            Console.WriteLine("=====================");
            Console.WriteLine("ERROR! Try another store \n");
            
        }

        public void store(WebClientData wbData)
        {

            clientData cData = new clientData(wbData.Name, wbData.ID);
            PerfectStore pStore = new PerfectStore();
            Console.WriteLine("ADAPTATION!");
            pStore.store(cData);
        }
    }
}
