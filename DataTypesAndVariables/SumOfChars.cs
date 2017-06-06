using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long totalSum = 0l;
            for (int i = 0; i < n; i++)
            {
                char tempChar = char.Parse(Console.ReadLine());
                totalSum += tempChar;
            }
            Console.WriteLine("The sum equals: " + totalSum);
        }
    }
}
