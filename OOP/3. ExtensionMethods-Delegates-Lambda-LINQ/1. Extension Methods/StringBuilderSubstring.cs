using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringBuilderSubstring
{
    public static StringBuilder Substring(this StringBuilder str,int index, int length)
    {
        if (index >= str.Length || (index + length) >= str.Length ||
            length >= str.Length || index < 0 || length < 0)
        {
            throw new IndexOutOfRangeException("Invalid index");
        }

        StringBuilder result = new StringBuilder();
        for (int i = index; i < index + length; i++)
        {
            result.Append(str[i]);
        }

        return result;
    }
}

