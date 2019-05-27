/*
 * Longest path in an undirected tree
Given an undirected tree, we need to find the longest path of this tree where a path is defined as a sequence of nodes.
Example:

Input : Below shown Tree using adjacency list 
        representation:
Output : 5
In below tree longest path is of length 5
from node 5 to node 7

*/

using System;
using System.Collections.Generic;

namespace Programming.Graph
{
    public class LongestPathInUndirectedTree
    {
        public int LongestPath(Graph g, int v)
        {
            var result = 0;
            bool[] visited = new bool[v];
            for (int i = 0; i < v; i++)
            {
                result = Math.Max(result, FindLongestPath(g, i, visited, 0));
            }
            return result;
        }
        public int FindLongestPath(Graph g, int s, bool[] visited, int count)
        {
            visited[s] = true;
            int result = 0;
            foreach (var t in g.adjListArray[s])
            {
                if (!visited[t.Item1])
                    result=Math.Max(FindLongestPath(g, t.Item1, visited, ++count),count);
            }
            return result;
        }
        /*public static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input.Add(-1);
            input.Add(0);
            input.Add(0);
            input.Add(0);
            input.Add(3);
            Graph g = new Graph(input.Count);
            for(int i=0;i<input.Count;i++)
            {
                if (input[i] != -1)
                    g.addEdge(input[i], i, 0);
            }
            LongestPathInUndirectedTree obj = new LongestPathInUndirectedTree();
            var result = obj.LongestPath(g, 5);
        }*/
    }
}
