using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulation
{
    class BoatSimulation
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string condition = Console.ReadLine().ToLower().Trim();
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            string message = String.Empty;

            if (condition == "odd")
            {
                result = 1;
            }
            for (int i = 1; i <= n; i++)
            {
                string tempString = Console.ReadLine();
                if (i % 2 == result)
                {
                    message += tempString + delimeter;
                }
            }
            Console.WriteLine(message.Substring(0, message.Length - 1));
        }
    }
}
