using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalNumbers
{
    class IntervalNumbers
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            if (from < to)
            {
                for (int i = from; i <= to; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = to; i <= from; i++)
                {
                    
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}
