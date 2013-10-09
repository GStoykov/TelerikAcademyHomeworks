using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            Frog[] frogs = {
                               new Frog("Jaba", Sex.male, 3),
                               new Frog("Jabka", Sex.female, 1),
                               new Frog("Dqdo Jaba", Sex.male, 5),
                           };

            Cat[] cats = {
                             new Kitten("Pisence", Sex.female, 1),
                             new Cat("Grumpy", Sex.male, 2),
                             new Tomcat("Tom", Sex.male, 3),
                         };

            Dog[] dogs = {
                             new Dog("Sharo", Sex.male , 2),
                             new Dog("Gosho", Sex.male, 4),
                             new Dog("Amy", Sex.female, 1),
                         };

            Console.WriteLine("The {0} frog {1} said \"{2}\".", frogs[0].Sex , frogs[0].Name, frogs[0].ProduceSound());
            Console.WriteLine("The {0} cat {1} said \"{2}\".", cats[0].Sex, cats[0].Name, cats[0].ProduceSound());
            Console.WriteLine("The {0} dog {1} said \"{2}\".", dogs[0].Sex, dogs[0].Name, dogs[0].ProduceSound());

            Console.WriteLine("Average age of frogs is {0}.", Animals.AverageAge(frogs));
            Console.WriteLine("Average age of cats is {0}.", Animals.AverageAge(cats));
            Console.WriteLine("Average age of dogs is {0:0.0}.", Animals.AverageAge(dogs));


        }
    }
}
