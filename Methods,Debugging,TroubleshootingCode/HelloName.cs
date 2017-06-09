
namespace _01.Hello_Name
{
    using System;

    class HelloName
    {
        public static void Main()
        {
            string yourName = Console.ReadLine();
            Name(yourName);
        }

        public static void Name(string yourName)
        { 
            Console.WriteLine("Hello, {0}!",yourName);
        }
    }
}
