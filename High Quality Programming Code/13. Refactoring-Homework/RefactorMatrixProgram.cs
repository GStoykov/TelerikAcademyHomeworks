using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFifteen
{
    class RefactorMatrixProgram
    {
        static void Main(string[] args)
        {
            int size = GetInput();

            WalkInMatrix walk = new WalkInMatrix(size);

            walk.FillMatrix();

            Console.WriteLine(walk.ToString());

        }

        private static int GetInput()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number = 0;
            while (!int.TryParse(input, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }
            return number;
        }
    }
}
