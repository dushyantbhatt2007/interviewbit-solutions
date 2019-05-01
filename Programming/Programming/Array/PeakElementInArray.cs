/*
 * Find a peak element
Given an array of integers. Find a peak element in it. An array element is peak if it is NOT smaller than its neighbors. For corner elements, we need to consider only one neighbor. For example, for input array {5, 10, 20, 15}, 20 is the only peak element. For input array {10, 20, 15, 2, 23, 90, 67}, there are two peak elements: 20 and 90. Note that we need to return any one peak element.

Following corner cases give better idea about the problem.
1) If input array is sorted in strictly increasing order, the last element is always a peak element. For example, 50 is peak element in {10, 20, 30, 40, 50}.
2) If input array is sorted in strictly decreasing order, the first element is always a peak element. 100 is the peak element in {100, 80, 60, 50, 20}.
3) If all elements of input array are same, every element is a peak element.
*/

namespace Programming.Array
{
    public class PeakElementInArray
    {
        public int FindPeakElement(int[] a)
        {
            if (a.Length > 1 && a[0] >= a[1])
                return a[0];
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] >= a[i - 1] && a[i] >= a[i + 1])
                    return a[i];
            }
            if (a[a.Length - 1] >= a[a.Length - 2])
                return a[a.Length - 1];
            return -1;
        }
        public int FindPeakElement1(int[] a)
        {
            int low = 0, high = a.Length;
            return FindPeakUntil(a, low, high);
        }
        private int FindPeakUntil(int[] a, int low, int high)
        {
            int mid = low + (high - low) / 2;
            if ((mid == 0 || a[mid - 1] <= a[mid]) && (mid == a.Length - 1 || a[mid + 1] <= a[mid]))
                return a[mid];
            else if (mid > 0 && a[mid - 1] > a[mid])
                return FindPeakUntil(a, low, mid - 1);
            else
                return FindPeakUntil(a, mid + 1, high);
        }
        /*public static void Main(string[] args)
        {
            PeakElementInArray obj = new PeakElementInArray();
            int[] a = new int[] { 10, 20, 15, 2, 23, 90, 67 };
            var result = obj.FindPeakElement1(a);
        }*/
    }
}
