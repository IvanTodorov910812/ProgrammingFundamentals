
namespace _03.EnglishNameOfLastDigit
{
    using System;

    class EnglishNameOfLastDigit
    {
       public static void Main()
        { 
            var num = long.Parse(Console.ReadLine());

            var lastDigit = GetLastDigit(num);
            var lastDigitAsWord = ConvertDigitToWord(lastDigit);

            Console.WriteLine(lastDigitAsWord);
        }

        public static int GetLastDigit(long num)
        {
            var lastDigit = num % 10;
            return (int)Math.Abs(lastDigit);
        }

        public static string ConvertDigitToWord(int lastDigit)
        {
            var digitAsWord = string.Empty;
            switch (lastDigit)
            {
                case 0:
                    digitAsWord = "zero";
                    break;
                case 1:
                    digitAsWord = "one";
                    break;
                case 2:
                    digitAsWord = "two";
                    break;
                case 3:
                    digitAsWord = "three";
                    break;
                case 4:
                    digitAsWord = "four";
                    break;
                case 5:
                    digitAsWord = "five";
                    break;
                case 6:
                    digitAsWord = "six";
                    break;
                case 7:
                    digitAsWord = "seven";
                    break;
                case 8:
                    digitAsWord = "eight";
                    break;
                case 9:
                    digitAsWord = "nine";
                    break;
            }
            return digitAsWord;
        }
    }
}
