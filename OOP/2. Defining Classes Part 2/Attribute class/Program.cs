using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Version(1.1)]
class Patch
{

}


class Program
{
    static void Main()
    {
        Patch patch = new Patch();
        Type type = typeof(Patch);

        Console.WriteLine(type);

        object[] allAttributes = type.GetCustomAttributes(false);
        foreach (VersionAttribute attribute in allAttributes)
        {
            Console.WriteLine("{0} version is {1}", attribute, attribute.version);            
        }


    }
}