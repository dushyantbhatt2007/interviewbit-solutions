/*Commutable Islands
Asked in:  
Amazon
Problem Setter: amitkgupta94 Problem Tester: archit.rai
There are n islands and there are many bridges connecting them.Each bridge has some cost attached to it.

We need to find bridges with minimal cost such that all islands are connected.

It is guaranteed that input data will contain at least one possible scenario in which all islands are connected with each other.

Example :
Input

         Number of islands (n ) = 4
         1 2 1 
         2 3 4
         1 4 3
         4 3 2
         1 3 10
In this example, we have number of islands(n) = 4.Each row then represents a bridge configuration. In each row first two numbers represent the islands number which are connected by this bridge and the third integer is the cost associated with this bridge.

In the above example, we can select bridges 1(connecting islands 1 and 2 with cost 1), 3(connecting islands 1 and 4 with cost 3), 4(connecting islands 4 and 3 with cost 2). Thus we will have all islands connected with the minimum possible cost(1+3+2 = 6). 
In any other case, cost incurred will be more.

Seen this question in a real interview before*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Graph
{
    public class UnionFind
    {
        private int count = 0;
        private int[] parent, rank;
        public UnionFind(int n)
        {
            count = n;
            parent = new int[n];
            rank = new int[n];
            for (int i = 0; i < parent.Length; i++)
                parent[i] = i;
        }
        public int Find(int p)
        {
            while (p != parent[p])
            {
                parent[p] = parent[parent[p]];
                p = parent[p];
            }
            return p;
        }
        public bool Union(int p, int q)
        {
            int rootP = Find(p);
            int rootQ = Find(q);
            if (rootP == rootQ) return false;
            if (rank[rootP] > rank[rootQ])
                parent[rootP] = rootQ;
            else
            {
                parent[rootQ] = rootP;
                if (rank[rootP] == rank[rootQ])
                    rank[rootP]++;
            }
            count--;
            return true;
        }
    }

    public class CommutableIslands
    {
        public int CommIslands(int A, List<List<int>> B)
        {
            UnionFind obj = new UnionFind(A);
            B.Sort((i1, i2) => { return i1[2] - i2[2]; });
            int ans = 0;
            for (int i = 0; i < B.Count; i++)
            {
                if (obj.Find(B[i][0] - 1) != obj.Find(B[i][1] - 1))
                {
                    obj.Union(B[i][0] - 1, B[i][1] - 1);
                    ans += B[i][2];
                }
            }
            return ans;
        }
        /*public static void Main(string[] args)
        {
            CommutableIslands s = new CommutableIslands();
            List<List<int>> B = new List<List<int>>();
            B.Add(new List<int> { 1, 2, 1 });
            B.Add(new List<int> { 2, 3, 4 });
            B.Add(new List<int> { 1, 4, 3 });
            B.Add(new List<int> { 4, 3, 2 });
            B.Add(new List<int> { 1, 3, 10 });
            var res = s.CommIslands(4, B);
        }*/
    }

}
