using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            int index = 0;

            string orderedProduct = Console.ReadLine();

            while (orderedProduct != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (orderedProduct == products[i])
                    {
                        index = i;
                    }
                }

                int orderedIndex = Array.IndexOf(products, orderedProduct);
                Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");

                orderedProduct = Console.ReadLine();
            }
        }
    }
}
