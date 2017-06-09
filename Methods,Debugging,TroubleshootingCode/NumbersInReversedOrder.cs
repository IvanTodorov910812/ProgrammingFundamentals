
namespace _04.NumbersInReversedOrder
{
    using System;

    class NumbersInReversedOrder
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(num));
        }

        public static double ReversedNum(double num)
        {
            var numString = num.ToString();

            var reversedString = string.Empty;

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedString += numString[i];
            }

            var reversedNum = double.Parse(reversedString);
            return reversedNum;
        }

    }
}
