using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            var bpm = double.Parse(Console.ReadLine());
            var beats = double.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0, 1);

            double secondsForOneBeat = 60 / bpm;
            double totalSeconds = secondsForOneBeat * beats;
            int minutes = (int)totalSeconds / 60;
            int seconds = (int)totalSeconds % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
