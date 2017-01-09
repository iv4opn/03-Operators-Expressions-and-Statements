using System;

class BitExchange
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Before exchange positions of binary number are:\n{0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        int bit3 = n & 1 << 3;
        int bit4 = n & 1 << 4;
        int bit5 = n & 1 << 5;
        int bit24 = n & 1 << 24;
        int bit25 = n & 1 << 25;
        int bit26 = n & 1 << 26;

        if (bit3 != 0)
        { n = n | (1 << 24); }
        else
        { n = n & (~(1 << 24)); }
        if (bit4 != 0)
        { n = n | (1 << 25); }
        else
        { n = n & (~(1 << 25)); }
        if (bit5 != 0)
        { n = n | (1 << 26); }
        else
        { n = n & (~(1 << 26)); }
        if (bit24 != 0)
        { n = n | (1 << 3); }
        else
        { n = n & (~(1 << 3)); }
        if (bit25 != 0)
        { n = n | (1 << 4); }
        else
        { n = n & (~(1 << 4)); }
        if (bit26 != 0)
        { n = n | (1 << 5); }
        else
        { n = n & (~(1 << 5)); }

        Console.WriteLine("{0}, \n{1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}

