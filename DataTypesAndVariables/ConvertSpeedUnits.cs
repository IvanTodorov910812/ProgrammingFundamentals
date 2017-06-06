using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int timeinSeconds = hours * 3600 + minutes * 60 + seconds; // TODO ; 3600 = 60 * 60 -> 1 hour = 60Min * 60 SecInMin

            float MInSecond = (float)distance / timeinSeconds; // division only of time, cause of Seconds
            float KmInHour = ((float)distance / 1000) / ((float)timeinSeconds / 3600); // Cause of Hour 
            float MilesInHour = ((float)distance / 1609) / ((float)timeinSeconds / 3600); //  / 3600 , cause * 3600 because of time

            Console.WriteLine($"{MInSecond:0.#######}\n{KmInHour:0.#######}\n{MilesInHour:0.#######}");

        }
    }
}
