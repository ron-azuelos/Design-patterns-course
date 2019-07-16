using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class MongoInsertQuery : MongoTemplateBase 
    {
        protected override void ExecuteQuery()
        {
            Console.WriteLine("Insert to Mongo .....");
        }
    }
}
