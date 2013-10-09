// Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
// Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
// Implement methods for:
//  -adding element
//  -accessing element by index
//  -removing element by index
//  -inserting element at given position
//  -clearing the list
//  -finding element by its value and ToString().
// Check all input parameters to avoid accessing elements at invalid positions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GenericList<T> where T: IComparable
{
    //FIELDS
    private T[] list;
    private int elemIndex;

    // CONSTRUCTORS
    public GenericList(int capacity)
    {
        list = new T[capacity];
    }

    public T this[int elemIndex]
    {
        get
        {
            return list[elemIndex];
        }
        set
        {
            this.list[elemIndex] = value;
        }
    }

    // METHODS
    public void Add(T element)
    {
        if (elemIndex >= list.Length)
        {
            T[] newList = new T[list.Length * 2];
            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            if (elemIndex == list.Length)
            {
                elemIndex++;
            }

            list = newList;

        }
        list[elemIndex] = element;
        elemIndex++;
    }

    public void RemoveElementAtIndex(int index)
    {
        if (index >= list.Length)
        {
            Console.WriteLine("Index was outside the bounds of the array.");
            return;
        }
        T[] newList = new T[list.Length - 1];
        bool isElemRemoved = true;
        for (int i = 0; i < newList.Length; i++)
        {
            if (i == index)
            {
                isElemRemoved = false;
            }

                if (isElemRemoved)
                {
                    newList[i] = list[i];                    
                }
                else
                {
                    newList[i] = list[i + 1];
                }
            
        }
        list = newList;
    }

    public void InsertElementAtIndex(int index, T element)
    {
        if (index > list.Length)
        {
            Console.WriteLine("Index was outside the bounds of the array.");
            return;
        }
        else
        {
            T[] newList = new T[list.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }

            // Adding the new element
            newList[index] = element;

            for (int i = index + 1; i < newList.Length; i++)
            {
                newList[i] = list[i - 1];
            }
            list = newList;
        }
    }

    public void ClearList()
    {
        list = new T[list.Length];
    }

    public void FindElementWithValue(T element)
    {
        List<int> indexes = new List<int>();
        
        // Finding element`s indexes
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i].Equals(element))
            {
                indexes.Add(i);
            }
        }

        // Output
        if (indexes.Count == 0)
        {
            Console.WriteLine("Element not found.");
        }
        else
        {
            Console.Write("Element found at index: ");
            for (int i = 0; i < indexes.Count - 1; i++)
            {
                Console.Write("{0}, ", indexes[i]);
            }
            Console.Write(indexes[indexes.Count - 1]);
        }
        
    }

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        foreach (var itemT in list)
        {
            text.AppendFormat("{0} ", itemT); 
        }
        return text.ToString();
    }

    // GENERIC Methods

    // Create generic methods Min<T>() and Max<T>() for finding the minimal and
    // maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.

    public T Min<T>() where T: IComparable<T>
    {
        dynamic minValue = list.Min();
        return minValue;
    }

    public T Max<T>() where T : IComparable<T>
    {
        dynamic maxValue = list.Max();
        return maxValue;
    }

}




