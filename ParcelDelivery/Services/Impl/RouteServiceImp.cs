using ParcelDelivery.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Entity.Routes;
using QuickGraph;
using QuickGraph.Algorithms;
using ParcelDelivery.Data;
using ParcelDelivery.Data.DataContracts.Segment;

namespace ParcelDelivery.Services.Impl
{
    public class RouteServiceImp : IRouteService
    {
        private readonly ApplicationDbContext context;

        public RouteServiceImp(ApplicationDbContext context)
        {
            this.context = context;
        }
        public BidirectionalGraph<string, TaggedEdge<string, string>> BuildGraph(List<Segment> route)
        {
            {
                var graph = new BidirectionalGraph<string, TaggedEdge<string, string>>();
                route.ForEach(r =>
                {
                    graph.AddVertex(r.From.Name);
                    graph.AddVertex(r.To.Name);
                    graph.AddEdge(new TaggedEdge<string, string>(r.From.Name, r.To.Name, "AirPlane"));
                });

                return graph;
            }
        }

        private List<Segment> GetAllRoutes()
        {
            var outPutRoute = new List<Segment>();
            var routes = context.Segment.Where(x => x.IsActive).ToList();
            return routes;
        }

        public List<SegmentResult> SearchRoute(City source, City end)
        {
            var citiesByName = context.City.Where(x => x.IsActive).ToList().ToDictionary(x => x.Name);
            var routes = GetAllRoutes();

            var graph = BuildGraph(routes);

            double WeightByTime(TaggedEdge<string, string> edge)
            {
                return 8;
            }

                var shortestPath = graph.RankedShortestPathHoffmanPavley(WeightByTime, source.Name, end.Name, 2);

            var result = new List<SegmentResult>();

            foreach (var shortPath in shortestPath)
            {
                var parts = new List<SegmentDTO>();
                var route = new SegmentResult();
                double time = 0.0;
                foreach(var edge in shortPath)
                {
                    parts.Add(new SegmentDTO
                    {
                        Departure = new Data.DataContracts.City.CityDTO { Name = edge.Source.ToString() },
                        Destination = new Data.DataContracts.City.CityDTO { Name = edge.Target.ToString()}
                    });
                    time += WeightByTime(edge);
                }
                route.Parts = parts;
                route.EstimatedDuration = time;

                result.Add(route);
            }
            return result;
        }

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
