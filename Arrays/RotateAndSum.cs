    namespace _02.RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rotationCount = int.Parse(Console.ReadLine());

            var sumArray = new int[arr.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                RotateArray(arr);

                for (int j = 0; j < arr.Length; j++)
                {
                    sumArray[j] += arr[j];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static void RotateArray(int[] arr)
        {
            var lastEmenet = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = lastEmenet;
        }
    }
}
