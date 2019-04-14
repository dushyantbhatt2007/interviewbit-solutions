/*
 * iven a binary tree, return the level order traversal of its nodes’ values. (ie, from left to right, level by level).
 * 
 Example :
 Given binary tree
 
 3
 / \
 9  20
 /  \
 15   7
 return its level order traversal as:
 
 [
 [3],
 [9,20],
 [15,7]
 ]
 Also think about a version of the question where you are asked to do a level order traversal of the tree when depth of the tree is much greater than number of nodes on a level.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Graph
{
    public class LevelOrder
    {

        public void LevelOrderTraversal(Graph g)
        {
            bool[] visited = new bool[g.V];
            for (int i = 0; i < g.V; i++)
            {
                if (!visited[i])
                {
                    LevelOrderTraversalhelp(g, visited, i);
                }
            }
        }
        public void LevelOrderTraversalhelp(Graph g, bool[] visited, int s)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(s);
            while (queue.Count > 0)
            {
                var q = queue.Dequeue();
                if (!visited[q])
                {
                    visited[q] = true;
                    Console.WriteLine("next->" + q);
                    foreach (var e in g.adjListArray[q])
                    {
                        if (!visited[e.Item1])
                            queue.Enqueue(e.Item1);
                    }
                }

            }
        }

        /*public static void Main(string[] args)
        {
            int V = 5; // Number of vertices in graph  

            Graph graph = new Graph(V);
            //graph.IsDirected = true;
            graph.addEdge(0, 4, 0);
            graph.addEdge(0, 3, 0);
            graph.addEdge(1, 2, 0);
            graph.addEdge(2, 0, 0);
            graph.addEdge(3, 3, 0);


            LevelOrder l = new LevelOrder();
            l.LevelOrderTraversal(graph);
        }*/
    }


}
