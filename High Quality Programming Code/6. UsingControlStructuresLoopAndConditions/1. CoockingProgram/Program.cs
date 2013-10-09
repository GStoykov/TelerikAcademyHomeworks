using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Cook();
    }

    private static void Cook()
    {
        Chief chief = new Chief();
        Bowl bowl = chief.GetBowl();        

        Potato potato = chief.GetPotato();
        chief.Peel(potato);
        chief.Cut(potato);
        bowl.Add(potato);

        Carrot carrot = chief.GetCarrot();
        chief.Cut(carrot);
        chief.Peel(carrot);
        bowl.Add(carrot);
    
    }
}