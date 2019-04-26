/*
Rain Water Trapped
Asked in:  
Qualcomm
Amazon
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.

Example :

Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.

Rain water trapped: Example 1

The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1].
In this case, 6 units of rain water (blue section) are being trapped.*/

using System.Collections.Generic;

namespace Programming.Stacks_and_Queues
{
    public class RainWaterTrapped
    {
        public int WaterTrapped(List<int> A)
        {
            int low = 0, high = A.Count - 1, result = 0;
            int left_max = 0, right_max = 0;
            while (low <= high)
            {
                if (A[low] < A[high]) { 
                    if (A[low] > left_max)
                        left_max = A[low];
                    else
                        result += left_max - A[low];
                low++;
                }
                else
                {
                    if (A[high] >= right_max)
                        right_max = A[high];
                    else
                        result += right_max - A[high];

                    high--;
                }
            }
            return result;
        }
        /*public static void Main(string[] args)
        {
            RainWaterTrapped obj = new RainWaterTrapped ();
            var result = obj.WaterTrapped(new List<int> { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        }*/
    }
}
