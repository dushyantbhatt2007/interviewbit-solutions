using System;
using System.Collections.Generic;

namespace Programming.Graph
{
    public class DFS
    {
        public void DFSAlgo(Graph g, int s)
        {
            bool[] visited = new bool[g.V];
            Stack<int> stack = new Stack<int>();
            stack.Push(s);
            while (stack.Count > 0)
            {
                var st = stack.Pop();
                if (!visited[st])
                {
                    visited[st] = true;
                    Console.WriteLine("next->" + st);
                    foreach (var i in g.adjListArray[st])
                    {
                        if (!visited[i.Item1])
                            stack.Push(i.Item1);
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            int V = 5; // Number of vertices in graph  

            Graph graph = new Graph(V);
            //graph.IsDirected = true;
            graph.addEdge(0, 3, 0);
            graph.addEdge(0, 2, 0);
            graph.addEdge(1, 2, 0);
            graph.addEdge(1, 3, 0);
            graph.addEdge(1, 4, 0);
            DFS d = new DFS();
            d.DFSAlgo(graph, 0);
        }
    }
}
