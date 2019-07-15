
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WebProtoType;

namespace WebProtoType
{
    class Program
    {
        

        static void Main(string[] args)
        {
            WebInfoFactory wif = new WebInfoFactory(); 
            string url1 = "http://www.IntelliTect.com";
            string url2 = "http://www.IntelliTect.com";
            string url3 = "http://www.IntelliTect.com";

            Console.Write(url1);

           WebInfo w1=  wif.createWebInfo(url1);
           WebInfo w2 = wif.createWebInfo(url2);
           WebInfo w3 = wif.createWebInfo(url3);


        }
    }
}