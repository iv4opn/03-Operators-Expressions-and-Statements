using System;

class CheckDevidedNum
{
    static void Main()
    {
        //Console.WriteLine("Enter devide number:");
        int n = int.Parse(Console.ReadLine());
         //The result is same if divide entered number on 35
        if ((n % 5 == 0) && (n % 7 == 0))
        { int a = n;  Console.WriteLine("true {0}", n); }
        else
        { Console.WriteLine("false {0}", n); }

    }
}
