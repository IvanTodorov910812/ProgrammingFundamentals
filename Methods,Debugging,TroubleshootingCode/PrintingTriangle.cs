
namespace _03.PrintingTriangle
{
    using System;

    class PrintingTriangle
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        public static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col}"+ " ");
            }
            Console.WriteLine();
        }

        public static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col}" + " ");
                }
                Console.WriteLine();
            }
            for (int row = number - 1; row >- 1; row--)
            {
                PrintColumns(row);
            }
        }
    }
}
