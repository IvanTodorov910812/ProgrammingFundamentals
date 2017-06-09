
namespace _04.DrawAFilledSquare
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTheFigure(number);
        }

        public static void PrintHeaderRow(int number)
        {
            Console.Write(new string('-', number * 2));
        }

        public static void PrintMiddleRow(int number)
        {
            Console.Write("-");
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        public static void PrintTheFigure(int number)
        {
            PrintHeaderRow(number);
            Console.WriteLine();
            for (int i = 0; i < number - 2; i++)
            {
                PrintMiddleRow(number);
            }
            PrintHeaderRow(number);
            Console.WriteLine();
        }
    }
}
