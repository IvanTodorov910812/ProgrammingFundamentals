namespace _01.DaysOfWeek
{
    using System;

   public class DaysOfWeek
    {
        public static void Main()
        {
            int dayNumbers = int.Parse(Console.ReadLine());
            string[] daysInTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayNumbers > 0 && dayNumbers <= 7)
            {
                Console.WriteLine(daysInTheWeek[dayNumbers - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
