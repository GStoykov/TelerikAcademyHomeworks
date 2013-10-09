using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TenRandomValues
{
    class TenRandomValues
    {
        private static Random rnd = new Random();
       
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(100, 200));                
            }
        }
    }
}
