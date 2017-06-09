
namespace _06.MathPower
{
    using System;

    class MathPower
    {
       public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        public static double RaiseToPower(double number, double power)
        {
            double result = Math.Pow(number,power);
            return result;
        }
    }
}
