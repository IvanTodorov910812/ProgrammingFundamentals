using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] filteredArray = initialArray
                .Where(a => a % 2 == 0)
                .ToArray();

            int[] finalArray = filteredArray
                .Select(a => a >= filteredArray.Average() ? ++a : --a)
                .ToArray();

            Console.WriteLine(string.Join(" ", finalArray));

        }
    }
}
