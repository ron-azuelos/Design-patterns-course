using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProtoType
{
    public interface IProtoType<TWebInfo>
    {
        WebInfo clone();
    }
}
