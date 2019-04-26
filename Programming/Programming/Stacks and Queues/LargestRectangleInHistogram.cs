/*
Largest Rectangle in Histogram
Asked in:  
Google
Facebook
Given n non-negative integers representing the histogram’s bar height where the width of each bar is 1, find the area of largest rectangle in the histogram.

Largest Rectangle in Histogram: Example 1

Above is a histogram where width of each bar is 1, given height = [2,1,5,6,2,3].

Largest Rectangle in Histogram: Example 2

The largest rectangle is shown in the shaded area, which has area = 10 unit.

For example,
Given height = [2,1,5,6,2,3],
return 10.
*/
using System;
using System.Collections.Generic;

namespace Programming.Stacks_and_Queues
{
    public class LargestRectangleInHistogram
    {
        public int LargestRectangleArea(List<int> A)
        {
            int max_area = 0, current_area = 0, top = 0, i = 0;
            Stack<int> stack = new Stack<int>();
            while (i < A.Count)
            {
                if (stack.Count == 0 || A[stack.Peek()] <= A[i])
                    stack.Push(i++);
                else
                {
                    top = stack.Pop();
                    current_area = A[top] * (stack.Count == 0 ? i : i - stack.Peek() - 1);
                    max_area = Math.Max(current_area, max_area);
                }
            }
            while (stack.Count > 0)
            {
                top = stack.Pop();
                current_area = A[top] * (stack.Count == 0 ? i : i - stack.Peek() - 1);
                max_area = Math.Max(current_area, max_area);
            }
            return max_area;
        }
        /*public static void Main(string[] args)
        {
            LargestRectangleInHistogram obj = new LargestRectangleInHistogram();
            var result = obj.LargestRectangleArea(new List<int> { 2, 1, 5, 6, 2, 3 });
        }*/
    }
}
