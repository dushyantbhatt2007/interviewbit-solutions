/*
Check if two nodes are on same path in a tree
Given a tree (not necessarily a binary tree) and a number of queries such that every query takes two nodes of tree as parameters. For every query pair, find if two nodes are on the same path from root to the bottom.

For example, consider the below tree, if given queries are (1, 5), (1, 6) and (2, 6), then answers should be true, true and false respectively.
        
        1
      / | \
     2  3  4
    /   |   \
   5    6    7

Check if two nodes are on same path in a tree
Note that 1 and 5 lie on same root to leaf path, so do 1 and 6, but 2 and 6 are not on same root to leaf path.
*/

using System;

namespace Programming.Graph
{
    public class TwoNodesOntheSamePathofTree
    {
        int timer = 0;
        int[] InTime;
        int[] OutTime;
        void DFS(Graph g, int v, bool[] visited, int[] InTime, int[] OutTime)
        {
            visited[v] = true;
            ++timer;
            InTime[v] = timer;
            foreach (var i in g.adjListArray[v])
            {
                if (!visited[i.Item1])
                    DFS(g, i.Item1, visited, InTime, OutTime);
            }
            ++timer;
            OutTime[v] = timer;
        }
        bool Query(int u, int v)
        {
            return ((InTime[u] < InTime[v] && OutTime[u] > OutTime[v]) || (InTime[v] < InTime[u] && OutTime[v] > OutTime[u]));
        }
        public static void Main(string[] args)
        /*{
            int n = 8;
            Graph g = new Graph(n);
            g.addEdge(1, 2, 0);
            g.addEdge(1, 3, 0);
            g.addEdge(1, 4, 0);
            g.addEdge(2, 5, 0);
            g.addEdge(3, 6, 0);
            g.addEdge(4, 7, 0);
            TwoNodesOntheSamePathofTree obj = new TwoNodesOntheSamePathofTree();
            bool[] visited = new bool[n];
            obj.InTime = new int[n];
            obj.OutTime = new int[n];
            obj.DFS(g, 1, visited, obj.InTime, obj.OutTime);
            Console.WriteLine(obj.Query(1, 5));
            Console.WriteLine(obj.Query(2, 5));
            Console.WriteLine(obj.Query(2, 6));
        }*/
    }
}
