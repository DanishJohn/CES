using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Routing
{
    public class Graph
    {
        public int vertices { get; set; }
        public LinkedList<Node>[] adjacencyList { get; set; }

        public Graph(int vertices)
        {
            this.vertices = vertices;
            adjacencyList = new LinkedList<Node>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new LinkedList<Node>();
            }
        }

        public void addEdge(int source, int destination)
        {
            Node node = new Node(source, destination);
            //add edge
            adjacencyList[source].AddLast(node);
        }
    }
}
