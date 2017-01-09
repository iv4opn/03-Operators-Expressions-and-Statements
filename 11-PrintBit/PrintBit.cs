using System;

class PrintBit
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position:");
        int possition = int.Parse(Console.ReadLine());
        int mask = 1 << possition;
        Console.WriteLine("The bit of the possition is: {0}", (n & mask) != 0 ? 1 : 0);

    }
}

