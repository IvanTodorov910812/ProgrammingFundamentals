using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExamSumOfRealNumbers
{
    class ExamSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0; 
            for (int i = 1; i <= n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
