using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double pricePackage = 0.0;
            double discountPackage = 0.0;

            switch (package)
            {
                case "Normal":
                    pricePackage = 500;
                    discountPackage = 0.05;
                        break;
                case "Gold":
                    pricePackage = 750;
                    discountPackage = 0.10;
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    discountPackage = 0.15;
                    break;
            }

            int smallHallPrice = 2500;
            int terracePrice = 5000;
            int greatHall = 7500;

            double price = 0.0;
            double discount = 0.0;
            double endprice = 0.0;

            if (guests <= 50)
            {
                discount = (smallHallPrice + pricePackage) * discountPackage;
                price = (smallHallPrice + pricePackage - discount);
                endprice = price / guests;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine("The price per person is {0:F2}$", endprice);
            }
            else if (guests > 50 && guests <= 100)
            {
                discount = (terracePrice + pricePackage) * discountPackage;
                price = (terracePrice + pricePackage - discount);
                endprice = price / guests;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine("The price per person is {0:F2}$", endprice);
            }
            else if (guests > 100 && guests <= 120)
            {
                discount = (greatHall + pricePackage) * discountPackage;
                price = (greatHall + pricePackage - discount);
                endprice = price / guests;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine("The price per person is {0:F2}$", endprice);
            }
            else if (guests > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
