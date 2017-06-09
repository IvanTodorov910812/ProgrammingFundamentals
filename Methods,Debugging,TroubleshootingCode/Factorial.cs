namespace _13.Factorial
{
    using System;
    using System.Numerics; // only using by BigInterger data

    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(num));
        }

        static BigInteger GetFactorial(BigInteger num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}