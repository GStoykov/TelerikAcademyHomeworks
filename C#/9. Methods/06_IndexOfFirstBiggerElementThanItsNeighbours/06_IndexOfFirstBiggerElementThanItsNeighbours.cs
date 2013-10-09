using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_IsElementBiggerThanItsNeighbours;

namespace _06_IndexOfFirstBiggerElementThanItsNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that returns the index of the first element in array that is bigger than its neighbors,
            // or -1, if there’s no such element. Use the method from the previous exercise.

            int[] arr = { 4, 13, 23, 66, 67, 68, 100, 200, 1000, 400, 500, 600, 700, 800 };
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if(Program5.IsElemBiggerThanHisNeighbours(i, arr) > 0)
                {
                    Console.WriteLine("First element which is bigger than his neighbours has index: {0}", Program5.IsElemBiggerThanHisNeighbours(i, arr));
                    return;
                }
                else if (Program5.IsElemBiggerThanHisNeighbours(i, arr) == -1 && i == arr.Length -2)
                {
                    Console.WriteLine("There is no such element");
                }
                
                                
            }

        }

        

        
    }
}
