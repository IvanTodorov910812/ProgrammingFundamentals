namespace FoldandSum
{
    using System;
    using System.Linq;

    public class FoldandSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = arr.Length / 4;

            var leftArr = new int[k];
            var rightArr = new int[2 * k];
            var middleArr = new int[k];

            var resultArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                leftArr[i] = arr[i];
                rightArr[i] = arr[3 * k + i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                middleArr[i] = arr[k + i];
            }

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            for (int i = 0; i < k; i++)
            {
                resultArray[i] += middleArr[i] + leftArr[i];
                resultArray[i + k] += middleArr[i + k] + rightArr[i];
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
