using ParcelDelivery.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Entity.Routes;

namespace ParcelDelivery.Services.Impl
{
    public class RouteServiceImp : IRouteService
    {
        public string Print(Graph graph, City start, City end, string path, Dictionary<City,bool> visited)
        {
            string newPath = path + "->" + start;
            visited[start] = true;
            LinkedList<Node> list = graph.adjacencyList[start];
            foreach (Node node in list)
            {
                if (node.destination != end && visited[node.destination] == false)
                {
                    return Print(graph, node.destination, end, newPath, visited);
                }
                else if (node.destination == end)
                {
                    return $"{newPath} ->{node.destination}";
                }
            }
            //remove from path
            visited[start] = false;
            return "Not supported";
        }

        public string PrintAllPaths(Graph graph, City start, City end)
        {
            Dictionary<City, bool> visited = new Dictionary<City,bool>();
            visited[start] = true;
            return Print(graph, start, end, "", visited);
        }
    }
}
