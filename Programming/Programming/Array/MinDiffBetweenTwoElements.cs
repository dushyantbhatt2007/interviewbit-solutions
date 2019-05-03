/*
 * Find minimum difference between any two elements
Given an unsorted array, find the minimum difference between any pair in given array.

Examples :

Input  : {1, 5, 3, 19, 18, 25};
Output : 1
Minimum difference is between 18 and 19

Input  : {30, 5, 20, 9};
Output : 4
Minimum difference is between 5 and 9

Input  : {1, 19, -4, 31, 38, 25, 100};
Output : 5
Minimum difference is between 1 and -4
*/
using System;

namespace Programming.Array
{
    public class MinDiffBetweenTwoElements
    {
        public int MinDifference(int[] a)
        {
            int diff = int.MaxValue;
            System.Array.Sort(a);
            for (int i = 0; i < a.Length - 1; i++)
            {
                diff = Math.Min((a[i + 1] - a[i]), diff);
            }
            return diff;
        }
        /*public static void Main(string[] args)
        {
            MinDiffBetweenTwoElements obj = new MinDiffBetweenTwoElements();
            int[] a = new int[] { 30, 5, 20, 9 };
            var result = obj.MinDifference(a);
        }*/
    }
}
