using System;

class PointInRectangle
{
    static void Main()
    {
        int x = 1;
        int y = 1;
        int c = 3;

        if (Math.Sqrt(x * x + y * y) <= c)
        { Console.WriteLine("The point is in cyrcle."); }
        else
        { Console.WriteLine("The point isn't in cyrcle."); }

        if (x < 1 || y > -1 || x > 6 || y < -3)
        { Console.WriteLine("The point is in rectangle."); }
        else
        { Console.WriteLine("The point isn't in rectangle."); }

    }

}

