/*
 * Given three prime number(p1, p2, p3) and an integer k. Find the first(smallest) k integers which have only p1, p2, p3 or a combination of them as their prime factors.

Example:

Input : 
Prime numbers : [2,3,5] 
k : 5

If primes are given as p1=2, p2=3 and p3=5 and k is given as 5, then the sequence of first 5 integers will be: 

Output: 
{2,3,4,5,6}

Explanation : 
4 = p1 * p1 ( 2 * 2 )
6 = p1 * p2 ( 2 * 3 )

Note: The sequence should be sorted in ascending order
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Graph
{
    public class Smallest_Sequence_With_Given_Primes
    {
        public List<int> solve(int A, int B, int C, int D)
        {
            List<int> res = new List<int>();
            res.Add(1);
            int posA = 0, posB = 0, posC = 0;
            int nextEle;
            for (int i = 0; i < D; i++)
            {
                nextEle = Math.Min(Math.Min(res[posA] * A, res[posB] * B), res[posC] * C);
                res.Add(nextEle);
                if (res[posA] * A == nextEle)
                    posA++;
                if (res[posB] * B == nextEle)
                    posB++;
                if (res[posC] * C == nextEle)
                    posC++;
            }
            res.RemoveAt(0);
            return res;

        }
        /*public static void Main(string[] args)
        {
            Smallest_Sequence_With_Given_Primes s = new Smallest_Sequence_With_Given_Primes();
            var res = s.solve(2, 3, 5, 5);
        }*/
    }
}
