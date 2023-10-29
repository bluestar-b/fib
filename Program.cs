using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Improper input. Exiting.");
            return;
        }

        if (!BigInteger.TryParse(args[0], out BigInteger limit))
        {
            Console.WriteLine("Invalid input. Exiting.");
            return;
        }

        BigInteger a = 1;
        BigInteger b = 0;
        BigInteger c;

        DateTime startTime = DateTime.Now;

        for (BigInteger i = 0; i < limit; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }

        DateTime endTime = DateTime.Now;

        Console.WriteLine($"Fibonacci Number {limit}: {b}");

        double timeTaken = (endTime - startTime).TotalSeconds;
        Console.WriteLine($"Calculation Time: {timeTaken} seconds");
    }
}

