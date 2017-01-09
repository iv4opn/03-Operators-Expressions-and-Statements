using System;

class PointInCyrcle
{
    static void Main()
    {
        int x = 0;
        int y = 5;
        Console.WriteLine("Point place is:");
        int pointPlace = int.Parse(Console.ReadLine());
        if (Math.Sqrt(x * x + y * y) <= pointPlace)
        { Console.WriteLine("The point is in cyrcle."); }
        else
        { Console.WriteLine("The point isn't in cyrcle."); }
    }
}

