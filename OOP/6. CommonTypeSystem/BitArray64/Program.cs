using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        // TASK 4
        BitArray64 num1 = new BitArray64(15);
        BitArray64 num2 = new BitArray64(1);
        Console.WriteLine(num1.Equals(num2));
        Console.WriteLine(num1 == num2);
        Console.WriteLine(num1 != num2);

        int bit = num1[4];
        Console.WriteLine(bit);

    }
}