using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
                int totalWater = 0;
                for (int i = 0; i < n; i++)
                {
                    int waterInput = int.Parse(Console.ReadLine());

                    if (totalWater + waterInput <= 255)
                    {
                        totalWater += waterInput;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient capacity!");
                    }
                }
                Console.WriteLine(totalWater);
            }
        }
    }
