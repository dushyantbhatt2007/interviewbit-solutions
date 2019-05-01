/*
 * Count Strictly Increasing Subarrays
Given an array of integers, count number of subarrays (of size more than one) that are strictly increasing.
Expected Time Complexity : O(n)
Expected Extra Space: O(1)

Examples:

Input: arr[] = {1, 4, 3}
Output: 1
There is only one subarray {1, 4}

Input: arr[] = {1, 2, 3, 4}
Output: 6
There are 6 subarrays {1, 2}, {1, 2, 3}, {1, 2, 3, 4}
                      {2, 3}, {2, 3, 4} and {3, 4}

Input: arr[] = {1, 2, 2, 4}
Output: 2
There are 2 subarrays {1, 2} and {2, 4}
*/

namespace Programming.Array
{
    public class StrictlyIncreasingSubArray
    {
        public int CountStrictlyIncSubArrary(int[] a)
        {
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j - 1] < a[j])
                        result++;
                    else
                        break;
                }
            }
            return result;
        }

        public int CountStrictlyIncSubArrary1(int[] a)
        {
            int result = 0, len = 1;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] > a[i])
                    len++;
                else
                {
                    result += ((len - 1) * len) / 2;
                    len = 1;
                }
            }
            if (len > 1)
                result += ((len - 1) * len) / 2;

            return result;
        }

        /*public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            StrictlyIncreasingSubArray obj = new StrictlyIncreasingSubArray();
            var result = obj.CountStrictlyIncSubArrary1(a);
        }*/
    }
}
