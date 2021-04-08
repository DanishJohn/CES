using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Entity.Routes;

namespace ParcelDelivery.Routing
{
    public class Graph
    {
        public HashSet<City> vertices { get; set; }
        public Dictionary<City,LinkedList<Node>> adjacencyList { get; set; }

        public Graph(HashSet<City> vertices)
        {
            this.vertices = vertices;
            adjacencyList = new Dictionary<City, LinkedList<Node>>();
            foreach (City i in  vertices)
            {
                adjacencyList[i] = new LinkedList<Node>();
            }
        }

        public void addEdge(City source, City destination)
        {
            Node node = new Node(source, destination);
            //add edge
            adjacencyList[source].AddLast(node);
        }
    }
}
