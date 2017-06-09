namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Linq;
    using System.Numerics;

    class FactorialTrailingZeroes
    {
        static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            var factorial = GetFactorial(num);
            var trailingZeroes = CalcTrailingZeroes(factorial);

            Console.WriteLine(trailingZeroes);
        }

        static BigInteger GetFactorial(BigInteger num)
        {
            BigInteger factorial = 1;
            for (var i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static BigInteger CalcTrailingZeroes(BigInteger factorial)
        {
            int zeroes = 0;
            while (factorial % 10 == 0)
            {
                zeroes++;
                factorial /= 10;
            }

            return zeroes;
        }
    }
}