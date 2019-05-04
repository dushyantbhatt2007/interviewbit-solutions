/*
 * Two elements whose sum is closest to zero
Question: An Array of integers is given, both +ve and -ve. You need to find the two elements such that their sum is closest to zero.

For the below array, program should print -80 and 85.
input array = {1, 60, -10, 70, -80, 85}
*/
using System;

namespace Programming.Array
{
    public class TwoElementSumIsClosestToZero
    {
        public Tuple<int, int> FindElementsWithSumClosestToZero(int[] a)
        {
            int min_l = 0, min_r = 1, sum;
            int min_sum = a[0] + a[1];
            if (a.Length < 2)
                return null;
            for (int l = 0; l < a.Length - 1; l++)
            {
                for (int r = l + 1; r < a.Length; r++)
                {
                    sum = a[l] + a[r];
                    if (Math.Abs(min_sum) > Math.Abs(sum))
                    {
                        min_sum = sum;
                        min_l = l;
                        min_r = r;
                    }
                }
            }
            return new Tuple<int, int>(a[min_l], a[min_r]);
        }
        public Tuple<int, int> FindElementsWithSumClosestToZero1(int[] a)
        {
            int sum, min_sum = int.MaxValue, min_l = 0, min_r = 0;
            System.Array.Sort(a);
            int l = 0, r = a.Length - 1;
            while (l < r)
            {
                sum = a[l] + a[r];
                if (Math.Abs(sum) < Math.Abs(min_sum))
                {
                    min_sum = sum;
                    min_l = l;
                    min_r = r;
                }
                if (sum < 0)
                    l++;
                else
                    r++;
            }
            return new Tuple<int, int>(a[min_l], a[min_r]);
        }
        /*public static void Main(string[] args)
        {
            TwoElementSumIsClosestToZero obj = new TwoElementSumIsClosestToZero();
            int[] a = new int[] { 1, 60, -10, 70, -80, 85 };
            var result = obj.FindElementsWithSumClosestToZero(a);
        }*/
    }
}
