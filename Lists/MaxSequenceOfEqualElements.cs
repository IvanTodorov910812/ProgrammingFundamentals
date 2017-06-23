namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {

            var inputArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var maxSequenceOfEqualElements = FindMaxSequenceOfEqualElements(inputArr);

            Console.WriteLine(string.Join(" ", maxSequenceOfEqualElements));
        }

        static int[] FindMaxSequenceOfEqualElements(int[] arr)
        {
            var longestSequence = new List<int>();
            var currentSequence = new List<int>();
            currentSequence.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var searchNum = currentSequence[0];

                if (currentNum == searchNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence); // this line will take all the elements from currentSequence and add it in longestSequence 
                    }
                    currentSequence.Clear(); // Delete all elements from the List -> Same like currentSequence = new List<int>();
                    currentSequence.Add(currentNum);
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence); // this line will take all the elements from currentSequence and add it in longestSequence 
            }

            return longestSequence.ToArray();
        }
    }
}
