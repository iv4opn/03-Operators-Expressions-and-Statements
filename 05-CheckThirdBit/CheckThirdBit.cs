using System;

class CheckThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        int checkVar = 8;
        if ((n & checkVar) != 0)
        { Console.WriteLine("The third bite of the number " + n + " is: 1"); }
        else
        { Console.WriteLine("The third bite of the number " + n + " is: 0"); }

    }
}

