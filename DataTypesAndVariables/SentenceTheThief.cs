using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            long maxValue = 0l;

            switch (type)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    maxValue = long.MaxValue;
                    break;
            }

            int n = int.Parse(Console.ReadLine());
            long thiefsId = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long tempId = long.Parse(Console.ReadLine());
                if (tempId >= thiefsId && tempId <= maxValue)
                {
                    thiefsId = tempId;
                }
            }

            double num = 0;

            if (thiefsId < 0)
            {
                num = sbyte.MinValue;
            }
            else
            {
                num = sbyte.MaxValue;
            }
            double years = Math.Ceiling(thiefsId / num);
            string yearToPrint = years > 1 ? "years" : "year";  // smart writting (if & else) 
            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}",
                thiefsId, years, yearToPrint);

        }
    }
}
