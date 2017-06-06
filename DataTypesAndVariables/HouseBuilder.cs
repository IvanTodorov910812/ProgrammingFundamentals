using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());

            long totalPrice = price1 > price2 ? price1 * 10 + price2 * 4 : price1 * 4 + price2 * 10;
            Console.WriteLine(totalPrice);
        }
    }
}
