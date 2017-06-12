
namespace _08.CenterPodouble
{
    using System;

    class CenterPodouble
    {
       public static void Main()
        {
            var xOne = double.Parse(Console.ReadLine());
            var yOne = double.Parse(Console.ReadLine());

            var xTwo = double.Parse(Console.ReadLine());
            var yTwo = double.Parse(Console.ReadLine());

            var betweenOne = DistanceMath(xOne, xTwo, yOne, yTwo);
            var betweenTwo = DistanceMath(xOne, xTwo, yOne, yTwo);

            if (betweenOne >= betweenTwo)
            {
                ClosestPodouble(xOne, yOne, xTwo, yTwo);
            }
            else
            {
                ClosestPodouble(xOne, yOne, xTwo, yTwo);
            }
        }

        public static double DistanceMath(double xfirst, double yfirst, double xSecond, double ySecond)
        {
            var calculationLength = Math.Sqrt(Math.Pow((xSecond - xfirst), 2) + (Math.Pow((ySecond - yfirst), 2)));
            return calculationLength;
        }

        public static void ClosestPodouble(double firstX, double firstY, double secondX, double secondY)
        {
            if (Math.Abs(firstX) <= Math.Abs(secondX) && Math.Abs(firstY) <= Math.Abs(secondY))
            {
                Console.WriteLine($"({firstX}, {firstY})");
            }
            else
            {
                Console.WriteLine($"({secondX}, {secondY})");
            }
        }
    }
}
