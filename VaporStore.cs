using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var initialBudget = budget;
            var input = Console.ReadLine();
            var currentPrice = 0.0;

            while (input != "Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                        currentPrice = 39.99;
                        break;
                    case "CS: OG":
                        currentPrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        currentPrice = 19.99;
                        break;
                    case "Honored 2":
                        currentPrice = 59.99;
                        break;
                    case "RoverWatch":
                        currentPrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        currentPrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        input = Console.ReadLine(); 
                        break;
                }

                if (currentPrice > budget)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    budget -= currentPrice;
                    Console.WriteLine($"Bought {input}");
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: {(initialBudget - budget):F2}. Remaining: {budget:F2}");
        }
    }
}
