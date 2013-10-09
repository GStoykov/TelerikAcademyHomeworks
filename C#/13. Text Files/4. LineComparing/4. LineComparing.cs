using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       // Write a program that compares two text files line by line and prints the number of lines that are the same and 
       // the number of lines that are different. Assume the files have equal number of lines.
        using (StreamReader readerOne = new StreamReader("firstNumbers.txt"), readerTwo = new StreamReader("secondNumbers.txt"))
        {
            string lineFirstNumbers, lineSecondNumbers;
            int differentLinesCounter = 0, equalLinesCounter = 0;

            while ((lineFirstNumbers = readerOne.ReadLine()) != null && (lineSecondNumbers = readerTwo.ReadLine()) != null)
            {
                if (lineFirstNumbers == lineSecondNumbers)
                {
                    equalLinesCounter++;
                }
                else
                {
                    differentLinesCounter++;
                }
            }
            Console.WriteLine("Equel lines are: {0}", equalLinesCounter);
            Console.WriteLine("Different lines are: {0}", equalLinesCounter);

        } 


    }
}