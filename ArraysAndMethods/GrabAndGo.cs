using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab_and_Go
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numToSearch = int.Parse(Console.ReadLine());

            int index = 0;
            bool isFound = false;
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] == numToSearch)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }
            long sum = 0;

            if (isFound)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
