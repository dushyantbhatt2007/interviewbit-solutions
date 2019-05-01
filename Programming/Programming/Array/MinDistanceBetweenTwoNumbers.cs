/*
Find the minimum distance between two numbers
Given an unsorted array arr[] and two numbers x and y, find the minimum distance between x and y in arr[]. The array might also contain duplicates. You may assume that both x and y are different and present in arr[].

Examples:
Input: arr[] = {1, 2}, x = 1, y = 2
Output: Minimum distance between 1 and 2 is 1.

Input: arr[] = {3, 4, 5}, x = 3, y = 5
Output: Minimum distance between 3 and 5 is 2.

Input: arr[] = {3, 5, 4, 2, 6, 5, 6, 6, 5, 4, 8, 3}, x = 3, y = 6
Output: Minimum distance between 3 and 6 is 4.

Input: arr[] = {2, 5, 3, 5, 4, 4, 2, 3}, x = 3, y = 2
Output: Minimum distance between 3 and 2 is 1.
*/
using System;

namespace Programming.Array
{
    public class MinDistanceBetweenTwoNumbers
    {
        public int MinDistance(int[] a, int b, int c)
        {
            int min_distance = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if ((b == a[i] && c == a[j] || c == a[i] && b == a[j]) && min_distance > Math.Abs(i - j))
                        min_distance = Math.Abs(i - j);
                }
            }
            return min_distance;
        }
        public int MinDistance1(int[] a, int b, int c)
        {
            int min_distance = int.MaxValue, prev = 0, i = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (b == a[i] || c == a[i])
                {
                    prev = i;
                    break;
                }
            }
            for (; i < a.Length; i++)
            {
                if (b == a[i] || c == a[i])
                {
                    // If the current element matches with any of the two then 
                    // check if current element and prev element are different 
                    // Also check if this value is smaller than minimum distance so far 
                    if (a[prev] != a[i] && i - prev < min_distance)
                    {
                        min_distance = i - prev;
                        prev = i;
                    }
                }
            }
            return min_distance;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[12] { 3, 5, 4, 2, 6, 5, 6, 6, 5, 4, 8, 3 };
            int b = 3, c = 6;
            MinDistanceBetweenTwoNumbers obj = new MinDistanceBetweenTwoNumbers();
            var result = obj.MinDistance1(a, b, c);
        }*/
    }
}
