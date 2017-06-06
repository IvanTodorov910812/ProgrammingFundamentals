using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            byte beginChar = byte.Parse(Console.ReadLine());
            byte endChar = byte.Parse(Console.ReadLine());

            for (int i = beginChar; i <= endChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
