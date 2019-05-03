/*
 * Print missing elements that lie in range 0 – 99
Given an array of integers print the missing elements that lie in range 0-99. If there are more than one missing, collate them, otherwise just print the number.
Note that the input array may not be sorted and may contain numbers outside the range [0-99], but only this range is to be considered for printing missing elements.

Examples :

Input: {88, 105, 3, 2, 200, 0, 10}
Output: 1
        4-9
        11-87
        89-99


Input: {9, 6, 900, 850, 5, 90, 100, 99}
Output: 0-4
        7-8
        10-89
        91-98
*/
using System;

namespace Programming.Array
{
    public class MissingElementsFrom0To99
    {
        public void PrintMissingElements(int[] a)
        {
            int LIMIT = 100;
            bool[] seen = new bool[LIMIT];
            for (int k = 0; k < a.Length; k++)
            {
                if (a[k] < LIMIT)
                    seen[a[k]] = true;
            }
            int i = 0;
            while (i < LIMIT)
            {
                if (seen[i] == false)
                {
                    int j = i + 1;
                    while (j < LIMIT && seen[j] == false)
                    {
                        j++;
                    }
                    int p = j - 1;
                    Console.WriteLine(i + 1 == j ? i.ToString() : i.ToString() + " - " + p.ToString());
                    i = j;
                }
                else
                    i++;
            }
        }

       /*public static void Main(string[] args)
        {
            int[] a = new int[] { 88, 105, 3, 2, 200, 0, 10 };
            MissingElementsFrom0To99 obj = new MissingElementsFrom0To99();
            obj.PrintMissingElements(a);
        }*/
    }
}
