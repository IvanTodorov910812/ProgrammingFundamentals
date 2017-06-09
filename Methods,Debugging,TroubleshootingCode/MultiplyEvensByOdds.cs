
namespace _08.MultiplyEvensByOdds
{
    using System;

    class MultiplyEvensByOdds
    {
        public static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            var result = GetMultipleOfEvensAndOdds(numbers);
            Console.WriteLine(result);
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
            var sumOfEvenDigits = GetSumOfEvenDigits(number);
            var sumOfOddDigits = GetSumOfOddDigits(number);

            var result = Math.Abs(sumOfEvenDigits * sumOfOddDigits);

            return result;
        }

        public static int GetSumOfOddDigits(int number)
        {
            var result = GetSumOfDigits(number, 1);
            return result;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            var result = GetSumOfDigits(number, 0);
            return result;
        }

        public static int GetSumOfDigits(int number, int reminder)
        {
            var result = 0;

            foreach (var symbol in number.ToString()) // -> To find the Even Digits! New trick :L :) <-
            {
                var digit = symbol - '0';
                if (digit % 2 == reminder)
                {
                    result += digit;
                }
            }
            return result;
        }
    }
}
