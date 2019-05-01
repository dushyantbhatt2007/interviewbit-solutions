/*Longest Span with same Sum in two Binary arrays
Given two binary arrays arr1[] and arr2[] of same size n. Find length of the longest common span (i, j) where j >= i such that arr1[i] + arr1[i+1] + …. + arr1[j] = arr2[i] + arr2[i+1] + …. + arr2[j].

Expected time complexity is Θ(n).

Examples :

Input: arr1[] = {0, 1, 0, 0, 0, 0};
       arr2[] = {1, 0, 1, 0, 0, 1};
Output: 4
The longest span with same sum is from index 1 to 4.

Input: arr1[] = {0, 1, 0, 1, 1, 1, 1};
       arr2[] = {1, 1, 1, 1, 1, 0, 1};
Output: 6
The longest span with same sum is from index 1 to 6.

Input: arr1[] = {0, 0, 0};
       arr2[] = {1, 1, 1};
Output: 0

Input: arr1[] = {0, 0, 1, 0};
       arr2[] = {1, 1, 1, 1};
Output: 1*/
namespace Programming.Array
{
    public class LargestSpanWithSameSumTwoArray
    {
        public int LargestSpanWithSameSum(int[] a, int[] b)
        {
            int max_len = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int sum1 = 0, sum2 = 0;
                for (int j = i; j < b.Length; j++)
                {
                    sum1 += a[j];
                    sum2 += b[j];
                    if (sum1 == sum2)
                    {
                        int len = j - i + 1;
                        if (len > max_len)
                            max_len = len;
                    }
                }
            }
            return max_len;
        }
        public int LargestSpanWithSameSum1(int[] a, int[] b)
        {
            int max_len = 0, n = a.Length;
            int sum1 = 0, sum2 = 0;
            int[] diff = new int[2 * n + 1];
            for (int i = 0; i < diff.Length; i++)
                diff[i] = -1;

            for (int i = 0; i < n; i++)
            {
                sum1 += a[i];
                sum2 += b[i];
                // Comput current diff and index to be used in diff array. 
                // Note that diff can be negative and can have minimum value as -1. 
                int curr_diff = sum1 - sum2;
                int diffIndex = n - curr_diff;

                // If current diff is 0, then there are same number of 1's so far in  
                // both arrays, i.e., (i+1) is maximum length. 
                if (curr_diff == 0)
                    max_len = i + 1;

                // If current diff is seen first time, then update starting index of diff.
                else if (diff[diffIndex] == -1)
                    diff[diffIndex] = i;

                // Current diff is already seen
                else
                {
                    // Find lenght of this same sum common span 
                    int len = i - diff[diffIndex];

                    // Update max len if needed 
                    if (len > max_len)
                        max_len = len;
                }
            }
            return max_len;
        }
        /*public static void Main(string[] args)
        {
            LargestSpanWithSameSumTwoArray obj = new LargestSpanWithSameSumTwoArray();
            int[] a = new int[7] { 1, 1, 0, 1, 1, 0, 0 };
            int[] b = new int[7] { 0, 0, 1, 0, 1, 0, 0 };
            var result = obj.LargestSpanWithSameSum1(a, b);
        }*/
    }

}
