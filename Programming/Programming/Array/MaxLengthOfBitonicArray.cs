/*
 * Maximum Length Bitonic Subarray | Set 1 (O(n) tine and O(n) space)
Given an array A[0 … n-1] containing n positive integers, a subarray A[i … j] is bitonic if there is a k with i <= k <= j such that A[i] <= A[i + 1] … = A[k + 1] >= .. A[j – 1] > = A[j]. Write a function that takes an array as argument and returns the length of the maximum length bitonic subarray.
Expected time complexity of the solution is O(n)

Simple Examples
1) A[] = {12, 4, 78, 90, 45, 23}, the maximum length bitonic subarray is {4, 78, 90, 45, 23} which is of length 5.

2) A[] = {20, 4, 1, 2, 3, 4, 2, 10}, the maximum length bitonic subarray is {1, 2, 3, 4, 2} which is of length 5.

Extreme Examples
1) A[] = {10}, the single element is bitnoic, so output is 1.

2) A[] = {10, 20, 30, 40}, the complete array itself is bitonic, so output is 4.

3) A[] = {40, 30, 20, 10}, the complete array itself is bitonic, so output is 4.
*/
using System;

namespace Programming.Array
{
    public class MaxLengthOfBitonicArray
    {
        public int FindMaxLenOfBitonicArray(int[] a)
        {
            int n = a.Length;
            int[] inc = new int[n];
            int[] dec = new int[n];
            int max;
            inc[0] = 1;
            dec[n - 1] = 1;
            for (int i = 1; i < n; i++)
                inc[i] = a[i] >= a[i - 1] ? inc[i - 1] + 1 : 1;

            for (int i = n - 2; i >= 0; i--)
                dec[i] = a[i] >= a[i + 1] ? dec[i + 1] + 1 : 1;

            max = inc[0] + dec[0] - 1;
            for (int i = 1; i < n; i++)
                max = Math.Max(max, inc[i] + dec[i] - 1);

            return max;
        }
        /*public static void Main(string[] args)
        {
            MaxLengthOfBitonicArray obj = new MaxLengthOfBitonicArray();
            int[] a = new int[] { 12, 4, 78, 90, 45, 23 };
            var result = obj.FindMaxLenOfBitonicArray(a);
        }*/
    }
}
