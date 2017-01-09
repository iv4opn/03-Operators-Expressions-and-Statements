using System;

class PrimeNumber
{
    static void Main()
    {
        //Console.WriteLine("Enter number between '1' and '100' ");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n == 1) { isPrime = false; }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine("Is the number {0} prime ? {1}", n, isPrime);

    }

}