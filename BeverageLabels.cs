using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var ml = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:", ml, name);

            var calories = energy / 100.0 * ml;
            var sugars = sugar / 100.0 * ml;

            Console.WriteLine($"{calories}kcal, {sugars}g sugars");
            Console.WriteLine();
        }
    }
}
