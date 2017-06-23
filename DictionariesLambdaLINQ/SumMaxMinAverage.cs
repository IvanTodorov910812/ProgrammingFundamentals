using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMaxMinAverage
{
    class SumMaxMinAverage
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 1; i <= n; i++)
            {
                nums[n] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Average = {0}", nums.Average());
        }
    }
}
