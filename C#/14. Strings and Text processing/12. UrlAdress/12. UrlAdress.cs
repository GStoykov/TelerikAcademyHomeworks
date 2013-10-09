using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.UrlAdress
{
    class Program
    {
        static void Main(string[] args)
        {
            // [protocol] = "http"
		    // [server] = "www.devbg.org"
		    // [resource] = "/forum/index.php"

            string protocol, server, resource;
            string url = "http://www.devbg.org/forum/index.php";

            string[] split = url.Split('/');

            int endIndex = url.IndexOf(':');
            Console.WriteLine("[protocol] = {0}", url.Substring(0, endIndex ));
            
            Console.WriteLine("[server] = {0}", split[2]);

            Console.Write("[resource] = ");
            for (int i = 3; i < split.Length-1; i++)
            {
                Console.Write(split[i]+"/");
            }
            Console.Write(split[split.Length - 1]);
            Console.WriteLine();
        }
    }
}
