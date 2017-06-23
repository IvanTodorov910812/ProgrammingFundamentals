using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, decimal>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var resource = line;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                
                resources[resource] += quantity;

                line = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                var resourceName = resource.Key;
                var resourceQuantity = resource.Value;
                Console.WriteLine($"{resourceName} -> {resourceQuantity}");
            }

        }
    }
}
