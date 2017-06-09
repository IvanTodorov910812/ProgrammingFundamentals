using System;

class Program
{
    public static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double fibNumber = Fibonacci(n);
        Console.WriteLine(fibNumber);
    }
    public static double Fibonacci(double n)
    {
        double fibN = 1;
        double fib1 = 0;
        double fib2 = 1;
        for (double i = 0; i < n; i++)
        {
            fibN = fib1 + fib2;
            fib1 = fib2;
            fib2 = fibN;
        }
        return fibN;
    }
}
