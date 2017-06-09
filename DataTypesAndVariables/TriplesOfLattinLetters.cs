using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLattinLetters
{
    class TriplesOfLattinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int h = 0; h < n; h++)
                    {
                        char letter = (char)('a' + i);
                        char letter1 = (char)('a' + j);
                        char letter2 = (char)('a' + h);
                        Console.WriteLine("{0}{1}{2}",letter, letter1, letter2);
                    }
                } 
            }
        }
    }
}
