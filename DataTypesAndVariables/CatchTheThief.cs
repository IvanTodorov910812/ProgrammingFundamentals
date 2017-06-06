using System;
namespace CatchTheThief
    {
        class CatchTheThief
        {
            static void Main(string[] args)
            {
                string type = Console.ReadLine();
                long maxValue = 0l;

                switch (type)
                {
                    case "sbyte":
                        maxValue = sbyte.MaxValue;
                        break;
                    case "int":
                        maxValue = int.MaxValue;
                        break;
                    case "long":
                        maxValue = long.MaxValue;
                        break;
                }

                int n = int.Parse(Console.ReadLine());
                long thiefsId = long.MinValue;
                for (int i = 0; i < n; i++)
                {
                    long tempId = long.Parse(Console.ReadLine());
                    if (tempId >= thiefsId && tempId <= maxValue)
                    {
                        thiefsId = tempId;
                    }
                }
                Console.WriteLine(thiefsId);
            }
        }
    }

