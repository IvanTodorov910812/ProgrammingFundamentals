using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var emailAdresses = new Dictionary<string, string>();
            var line = Console.ReadLine();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                emailAdresses[name] = email;

                line = Console.ReadLine();
            }

            var fixedEmails = emailAdresses.Where(a => !a.Value.ToLower().EndsWith("us")
            && !a.Value.ToLower().EndsWith("uk"))
            .ToDictionary(p => p.Key, p => p.Value);

            foreach (var pair in fixedEmails)
            {
                var name = pair.Key;
                var email = pair.Value;

                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}
