using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            try
            {
                long weather = long.Parse(Console.ReadLine());
                if (weather >= sbyte.MinValue && weather <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (weather >= int.MinValue && weather <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
            }
            catch
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
