namespace ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}
