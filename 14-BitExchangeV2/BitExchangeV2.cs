using System;

class BitExchangeV2
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the start possition of the first group bits:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the start possition of the second group bits:");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of bits for exchange:");
        int k = int.Parse(Console.ReadLine());
        int lenght = p + k;
        Console.WriteLine("Before exchange positions binary number are:\n{0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        
        for (; p < lenght; p++, q++)
        {
            int mask1 = n & 1 << p;
            int mask2 = n & 1 << q;

            if (mask1 != 0)
            { 
                n = n | 1 << q; 
            }
            else
            { 
                n = n & (~(1 << q)); 
            }
            if (mask2 != 0)
            { 
                n = n | 1 << p; 
            }
            else
            { 
                n = n & (~(1 << p)); 
            }

        }
        Console.WriteLine("After exchange the natural number is: {0}, and binary number is:\n{1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

    }
}

