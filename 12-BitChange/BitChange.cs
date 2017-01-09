using System;

class BitChange
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter '0' or  '1' ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Before change bit the binary number is:\n{0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        int mask = 1 << p;

        if (v == 0)
        { Console.WriteLine("After change bit the natural number is: {0}, and binary number is:\n{1}", n = n & (~mask), Convert.ToString(n, 2).PadLeft(32, '0')); }
        else
        { Console.WriteLine("After change bit the natural number is: {0}, and binary number is:\n{1}", n = (n | mask), Convert.ToString(n, 2).PadLeft(32, '0')); }
    }
}

