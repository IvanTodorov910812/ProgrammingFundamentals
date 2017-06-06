using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexeDecimalFormat
{
    class VariableInHexeDecimalFormat
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(value, 16));
        }
    }
}
