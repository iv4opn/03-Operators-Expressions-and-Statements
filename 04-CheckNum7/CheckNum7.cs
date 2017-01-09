using System;

class CheckNum7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n / 100;
        a = a % 10;
        bool checkVar = (a == 7);
        if (checkVar)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", a );
        }


    }
}

