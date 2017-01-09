using System;

class CalcReactArea
{
    static void Main()
    {
        //Console.WriteLine("Enter the side hight.");
        float a = float.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the side lenght.");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2} {1:F2}", (a * b), (2*a+2*b));

    }
}

