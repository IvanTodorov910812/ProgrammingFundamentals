namespace _10.CubeProperties
{
    using System;

    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            double result = 0;

            switch (property)
            {
                case "face":
                    result = Math.Sqrt(Calculate(side, 2));
                    break;
                case "space":
                    result = Math.Sqrt(Calculate(side, 3));
                    break;
                case "volume":
                    result = Calculate(side, side);
                    break;
                case "area":
                    result = Calculate(side, 6);
                    break;
            }
            Console.WriteLine(result.ToString("F"));
        }

        static double Calculate(double side, double a)
        {
            return a * (side * side);
        }
    }
}