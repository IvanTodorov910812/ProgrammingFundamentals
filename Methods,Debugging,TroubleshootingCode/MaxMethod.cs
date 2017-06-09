
namespace _02.MaxMethod
{
    using System;

    class MaxMethod
    {
       public static void Main()
        {
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            var c = long.Parse(Console.ReadLine());
            GetMax(a, b, c);
        }

        public static int GetMax(long a, long b, long c)
        {
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine(c);
            }
            return 0;
        }
    }
}
