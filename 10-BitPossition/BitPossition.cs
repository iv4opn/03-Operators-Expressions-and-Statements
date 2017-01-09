using System;

class BitPossition
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position:");
        int bPosition = int.Parse(Console.ReadLine());
        int mask = 1 << bPosition;
        Console.WriteLine((n & mask) != 0 ? true : false);

    }
}

