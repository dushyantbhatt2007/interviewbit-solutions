using System;
using System.Collections.Generic;

namespace Programming.Graph
{
    public class BFS
    {
        public void BFSAlgo(Graph g,int s)
        {
            bool[] visited = new bool[g.V];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);
            while (queue.Count > 0)
            {
                var q = queue.Dequeue();
                if (!visited[q])
                {
                    visited[q] = true;
                    Console.WriteLine("next->" + q);
                    foreach(var i in g.adjListArray[q])
                    {
                        if (!visited[i.Item1])
                            queue.Enqueue(i.Item1);
                    }
                }
            }
        }
        /*public static void Main(string[] args)
        {
            int V = 5; // Number of vertices in graph  

            Graph graph = new Graph(V);
            //graph.IsDirected = true;
            graph.addEdge(0, 3, 0);
            graph.addEdge(0, 2, 0);
            graph.addEdge(1, 2, 0);
            graph.addEdge(1, 3, 0);
            graph.addEdge(1, 4, 0);
            BFS b = new BFS();
            b.BFSAlgo(graph, 0);
        }*/
    }
}
