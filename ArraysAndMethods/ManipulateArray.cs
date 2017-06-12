using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int numberOfCommands = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfCommands; i++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    string command = input[0];

                    switch (command)
                    {
                        case "Distinct":
                            arr = arr.Distinct().ToArray();
                            break;

                        case "Reverse":
                            Array.Reverse(arr);
                            break;

                        case "Replace":
                            int replaceElement = int.Parse(input[1]);
                            string replaceWord = input[2];
                        if (replaceElement < 0 || replaceElement >= arr.Length)
                        {
                            break;
                        }
                        else
                        {
                            arr[replaceElement] = replaceWord;
                        }
                        break;
                        default:
                            break;
                    }
                }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
