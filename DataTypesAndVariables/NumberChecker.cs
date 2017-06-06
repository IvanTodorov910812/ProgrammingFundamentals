using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            try
            {
                long.Parse(numberString);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                try
                {
                    decimal.Parse(numberString);
                    Console.WriteLine("floating-point");
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
