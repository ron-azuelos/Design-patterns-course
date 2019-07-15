using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProtoType
{
    public class WebInfo : IProtoType<WebInfo>
    {
        public DateTime timestamp;
        public string size;
        public string url;

        public WebInfo(DateTime ts, string url, string sz)
        {
            this.size = sz;
            this.timestamp = ts;
            this.url = url;
        }
        public WebInfo clone()
        {
            WebInfo newInfo = new WebInfo(timestamp, size, url);
            return newInfo;
        }
    }

}
