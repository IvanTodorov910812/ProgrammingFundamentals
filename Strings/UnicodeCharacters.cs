namespace _03.UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public  class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            foreach (var letter in input)
            {
                Console.Write($"\\u{(int)letter:x4}");
            }

            Console.WriteLine();
        }
    }
}
