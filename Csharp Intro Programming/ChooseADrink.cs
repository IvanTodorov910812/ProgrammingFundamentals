using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());


            double water = (double)0.70 * quantity;
            double coffee = (double)1.00 * quantity;
            double beer = (double)1.70 * quantity;
            double tea = (double)1.20 * quantity;


            if (proffession == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", proffession, water);
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", proffession, coffee);
            }
            else if (proffession == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", proffession,beer);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", proffession,tea);
            }
        }
    }
}
