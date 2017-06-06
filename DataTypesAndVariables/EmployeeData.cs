using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string secondName = "Jonson";
            byte age = 27;
            string gender = "f";
            long ID = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}", secondName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", ID);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);

        }
    }
}
