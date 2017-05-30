using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTyping
{
    class SMSTyping
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();
                int mainDigit = int.Parse(digits[0].ToString());
                int offSet = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offSet += 1;
                }

                int letterIndex = offSet + digits.Length - 1;

                if (mainDigit == 0)
                {
                    message += " ";
                }
                else
                {
                    message +=(char)(97 + letterIndex);
                }
            }
            Console.WriteLine(message);
        }
    }
}
