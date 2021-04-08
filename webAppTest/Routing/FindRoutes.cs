using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Routing
{
    public class FindRoutes
    {
        public void Print(Graph graph, int start, int end, string path, bool[] visited)
        {
            string newPath = path + "->" + start;
            visited[start] = true;
            LinkedList<Node> list = graph.adjacencyList[start];
            foreach (Node node in list)
            {
                if (node.destination != end && visited[node.destination] == false)
                {
                    Print(graph, node.destination, end, newPath, visited);
                }
                else if (node.destination == end)
                {
                    Console.WriteLine(newPath + "->" + node.destination);
                }
            }
            //remove from path
            visited[start] = false;
        }

        public void PrintAllPaths(Graph graph, int start, int end)
        {
            bool[] visited = new bool[graph.vertices];
            visited[start] = true;
            Print(graph, start, end, "", visited);
        }
    }
}
