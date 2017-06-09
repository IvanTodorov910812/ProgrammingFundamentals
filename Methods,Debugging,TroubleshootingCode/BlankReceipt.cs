
namespace _01.BlankReceipt
{
    using System;

    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }

        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9" + " " + "SoftUni");
        }

        public static void PrintReceipt()
        {
            PrintReceiptHeader();
            Body();
            Footer();
        }
    }
}
