using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BitArray64 : IEnumerable<int>
{

    public ulong Number { get; set; }

    public BitArray64(ulong number)
    {
        this.Number = number;
    }

    public override bool Equals(object obj)
    {
        BitArray64 other = obj as BitArray64;
        return this.Number.Equals(other.Number);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return this.Number.ToString();
    }

    public static bool operator ==(BitArray64 number1, BitArray64 number2)
    {
        return number1.Equals(number2);
    }

    public static bool operator != (BitArray64 number1, BitArray64 number2)
    {
        return !number1.Equals(number2);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        int[] bits = ConvertToBits();
        for (int i = 0; i < bits.Length; i++)
        {
            yield return bits[i];
        }
    }

    private int[] ConvertToBits()
    {
        int[] bits = new int[64];
        for (int i = 0; i < bits.Length; i++)
        {
            int bit = (int)((this.Number >> i) & 1);
            bits[63 - i] = bit;
        }
        Array.Reverse(bits);
        return bits;
    }

    public int this[int index]
    {
        get
        {
            if (index < 0 || index > 63)
            {
                throw new System.IndexOutOfRangeException();
            }

            int[] bits = this.ConvertToBits();
            return bits[index];
        }
    }

}


