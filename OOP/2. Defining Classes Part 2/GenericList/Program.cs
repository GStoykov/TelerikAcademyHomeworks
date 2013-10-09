using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>(5);
        list.Add(1);
        list.Add(3);
        list.Add(5);
        list.Add(7);
        list.Add(9);
        //Console.WriteLine(list);

        //list.FindElementWithValue(2);
        //list.FindElementWithValue(3);
        //Console.WriteLine();

        //list.RemoveElementAtIndex(4);
        //Console.WriteLine(list);

        //list.InsertElementAtIndex(1, 2);
        //list.InsertElementAtIndex(5, 1);
        //Console.WriteLine(list);

        //list.ClearList();
        //Console.WriteLine(list);
        
        // Min() and Max() Test
        Console.WriteLine(list.Min<int>());
        Console.WriteLine(list.Max<int>());
    }
}