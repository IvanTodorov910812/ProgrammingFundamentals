using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsSharpIntroApplication
{
    class CharacterStatus
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var momentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var momentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|",
                new string('|', momentHealth), new string('.', maxHealth - momentHealth));
            Console.WriteLine("Energy: |{0}{1}|",
                new string('|', momentEnergy), new string('.', maxEnergy - momentEnergy));
        }
    }
}
