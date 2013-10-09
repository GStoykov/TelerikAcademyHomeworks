using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IsExpressionCorrect
{
    static void Main()
    {
        // Write a program to check if in a given expression the brackets are put correctly.

        string equation = "((2+3)/5*(2*4))";
        int brecketsCounter = 0;
        
        for (int i = 0; i < equation.Length; i++)
		{
            if (equation[i] == ')' && brecketsCounter == 0)
            {
                Console.WriteLine("Incorect!");
                return;
            }

            if (equation[i] =='(' && (i != equation.Length - 1))
            {
                brecketsCounter++;
            }
            else if (equation[i] =='(' && (i == equation.Length - 1))
            {
                Console.WriteLine("Incorect!");
                return;
            }

            if (equation[i] == ')')
            {
                brecketsCounter--;
            }
		}
        if (brecketsCounter == 0)
        {
            Console.WriteLine("Correct!");            
        }
        else
        {
            Console.WriteLine("Incorect!");
        }
    }
}