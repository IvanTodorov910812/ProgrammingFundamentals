using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;

                    if (nights > 7)
                    {
                        studioPrice *= 0.95; 
                    }   
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;

                    if (nights > 14)
                    {
                        doublePrice *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;

                    if (nights > 14)
                    {
                        suitePrice *= 0.85;
                    }
                    break;
                default:
                    break;
            }

            double studioPriceNights = studioPrice * nights;
            double doublePriceNights = doublePrice * nights;
            double suitePriceNights = suitePrice * nights;

            if (nights > 7 && (month == "September" || month == "October"))
            {
                studioPriceNights -= studioPrice; 
            }

            Console.WriteLine("Studio: {0:F2} lv.", studioPriceNights);
            Console.WriteLine("Double: {0:F2} lv.", doublePriceNights);
            Console.WriteLine("Suite: {0:F2} lv.", suitePriceNights);
        }
    }
}
