/*
Given an array A[] and a number x, check for pair in A[] with sum as x
Write a program that, given an array A[] of n numbers and another number x, determines whether or not there exist two elements in S whose sum is exactly x.
*/
using System.Collections.Generic;

namespace Programming.Array
{
    public class PairInArrayWithSumX
    {
        public int HasPairWithSumX(int[] a, int sum)
        {
            System.Array.Sort(a);
            int l = 0, r = a.Length - 1;
            while (l < r)
            {
                if (a[l] + a[r] == sum)
                    return 1;
                if (a[l] + a[r] < sum)
                    l++;
                else
                    r--;
            }
            return 0;
        }
        public int HasPairWithSumX1(int []a,int sum)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i = 0; i < a.Length; i++)
            {
                if (set.Contains(sum - a[i]))
                    return 1;
                else
                    set.Add(a[i]);
            }
            return 0;
        }
        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 45, 10, 6, -10 };
            PairInArrayWithSumX obj = new PairInArrayWithSumX();
            var result = obj.HasPairWithSumX1(a, 16);
        }*/
    }
}
