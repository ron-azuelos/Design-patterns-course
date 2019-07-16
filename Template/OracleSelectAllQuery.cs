using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class OracleSelectAllQuery : OracleTemplateBase
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Select * from gv$session Oracle .....");
        }
    }
}