﻿namespace RemoveNegativesandReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesandReverse
    {
        public static void Main()
        {
            List<string> listStr = Console.ReadLine().Split(' ').ToList();
            List<int> listInts = new List<int>();

            foreach (string element in listStr)
            {
                listInts.Add(int.Parse(element));
            }

            for (int i = 0; i < listInts.Count; i++)
            {
                if (listInts[i] < 0)
                {
                    listInts.Remove(listInts[i]);
                    i--;
                }
            }

            if (listInts.Count != 0)
            {
                listInts.Reverse();
                Console.WriteLine(string.Join(" ", listInts));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
