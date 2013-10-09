using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of_subset
{
    class Program
    {
        static void Main(string[] args)
        {
            /* We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
               Example: 3, -2, 1, 1, 8 -> 1+1-2=0. */
            int[] numbers = new int[5];
            int counter = 0, sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            
            }

            for (int a = 0; a < 5; a++)
            {
                for (int b = 1; b < 5; b++)
                {
                    for (int c = 2; c < 5; c++)
                    {
                        for (int d = 3; d < 5; d++)
                        {
                                sum = numbers[a] + numbers[b];
                                if (sum == 0)
                                {
                                   Console.WriteLine("{0} + {1} = 0", numbers[a], numbers[b]);
                                    return;
                                }
                                    sum = numbers[a] + numbers[b] + numbers[c];
                                    if (sum == 0)
                                    {
                                        Console.WriteLine("{0} + {1} + {2} = 0", numbers[a], numbers[b], numbers[c]);
                                        return;
                                    }
                                        sum = numbers[a] + numbers[b] + numbers[c] + numbers[d];
                                        if (sum == 0)
                                        {
                                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[a], numbers[b], numbers[c], numbers[d]);
                                            return;
                                        }                                        
                        }
                    }
                }
            }
        }
    }
}
