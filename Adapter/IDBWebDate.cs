using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IDBWebDate
    {
        void store(WebClientData wbData);

        void BadStore(WebClientData wbData);
    }
}
