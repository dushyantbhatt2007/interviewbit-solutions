namespace Programming.Graph
{
    using System;
    using System.Collections.Generic;
    // A class to represent a connected, directed and weighted graph  
    public  class Graph
    {
        
        public int V;
        public LinkedList<Tuple<int,int>>[] adjListArray;
        public bool IsDirected;
        // constructor  
        public Graph(int V)
        {
            this.V = V;

            // define the size of array as  
            // number of vertices 
            adjListArray = new LinkedList<Tuple<int, int>>[V];

            // Create a new list for each vertex 
            // such that adjacent nodes can be stored 
            for (int i = 0; i < V; i++)
            {
                adjListArray[i] = new LinkedList<Tuple<int, int>>();
            }
        }
        public  void addEdge(int src, int dest,int weight)
        {
            // Add an edge from src to dest.  
            adjListArray[src].AddLast(new Tuple<int,int>(dest,weight));

            if(!IsDirected)
                adjListArray[dest].AddLast(new Tuple<int, int>(src, weight));
        }

        // A utility function to print the adjacency list  
        // representation of graph 
        public  void printGraph()
        {
            for (int v = 0; v < V; v++)
            {
                Console.WriteLine("Adjacency list of vertex " + v);
                Console.Write("head");
                foreach(var pCrawl in adjListArray[v])
                {
                    Console.Write(" -> " + pCrawl);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
