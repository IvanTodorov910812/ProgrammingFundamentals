
namespace _02.SignOfIntegerNummer
{
    using System;

    class SignOfIntegerNummer
    {
       public static void Main()
        {
            int numberGiven = int.Parse(Console.ReadLine());
            PrintSign(numberGiven);
        }

        public static int PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }

            return number;
        }
    }
}
