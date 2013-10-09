// 2. Implement a set of extension methods for IEnumerable<T> that implement
//    the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SetOfExtensionMethods
{
    public static T Sum<T>(this IEnumerable<T> array)
    {
        dynamic sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum;
    }

    public static T Product<T>(this IEnumerable<T> array)
    {
        dynamic product = 0;
        foreach (var item in array)
        {
            product *= item;
        }
        return product;
    }

    public static T Min<T>(this IEnumerable<T> array)
    {
        dynamic min = array.ElementAt<T>(0);
        foreach (var item in array)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }

    public static T Max<T>(this IEnumerable<T> array)
    {
        dynamic max = array.ElementAt<T>(0);
        foreach (var item in array)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    public static T Average<T>(this IEnumerable<T> array)
    {
        if (array.Count<T>() == 0)
        {
            throw new ArgumentException("There is no element!");
        }
        
        dynamic sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum / array.Count<T>();
    }

}
