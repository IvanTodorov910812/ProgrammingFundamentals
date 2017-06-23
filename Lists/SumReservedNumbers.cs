using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumReservedNumbers
{
   public class SumReservedNumbers
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split();

            int sum = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                string currentNumber = inputNumbers[i];

                List<char> reversedNumbers = currentNumber.Reverse().ToList();

                string reversedNumberString = string.Join("" ,reversedNumbers);
                int resultNumber = int.Parse(reversedNumberString);
                sum += resultNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
