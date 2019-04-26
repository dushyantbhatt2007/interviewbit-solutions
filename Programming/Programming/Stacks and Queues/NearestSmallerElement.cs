/*
Nearest Smaller Element
Asked in:  
Amazon
Microsoft
Given an array, find the nearest smaller element G[i] for every element A[i] in the array such that the element has an index smaller than i.

More formally,

G[i] for an element A[i] = an element A[j] such that 
    j is maximum possible AND 
    j < i AND
    A[j] < A[i]
Elements for which no smaller element exist, consider next smaller element as -1.

Example:

Input : A : [4, 5, 2, 10, 8]
Return : [-1, 4, -1, 2, 2]

Example 2:

Input : A : [3, 2, 1]
Return : [-1, -1, -1]*/
using System.Collections.Generic;

namespace Programming.Stacks_and_Queues
{
    public class NearestSmallerElement
    {
        public List<int> prevSmaller(List<int> A)
        {
            var stack = new Stack<int>();
            for (int i = 0; i < A.Count; i++)
            {
                var n = A[i];
                while (stack.Count > 0 && stack.Peek() >=   n)
                    stack.Pop();
                A[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(n);
            }
            return A;
        }
        /*public static void Main(string[] args)
        {
            NearestSmallerElement obj = new NearestSmallerElement();
            var result = obj.prevSmaller(new List<int> { 4, 5, 2, 10, 8 });
        }*/
    }
}
