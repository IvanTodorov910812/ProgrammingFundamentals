using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNum} -> {isTrue}");
                sum = 0;
                i = currentNum;
            }
        }
    }
}
