using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int firstDigit = i / 10;
                int lastDigit = i % 10;
                int sum = firstDigit + lastDigit;

                bool isTrue = (sum == 5 || sum == 7 || sum == 11);

                Console.WriteLine(i + " -> " + isTrue);
            }
        }
    }
}
