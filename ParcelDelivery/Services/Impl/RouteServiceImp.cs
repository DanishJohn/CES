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
using ParcelDelivery.Data.DataContracts.Route;

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

        public List<RouteResult> SearchRoute(City source, City end)
        {
            var citiesByName = context.City.Where(x => x.IsActive).ToList().ToDictionary(x => x.Name);
            var routes = GetAllRoutes();

            var graph = BuildGraph(routes);

            double WeightByTime(TaggedEdge<string, string> edge)
            {
                return 8;
            }

                var shortestPath = graph.RankedShortestPathHoffmanPavley(WeightByTime, source.Name, end.Name, 2);

            var result = new List<RouteResult>();

            foreach (var shortPath in shortestPath)
            {
                var parts = new List<SegmentResult>();
                var route = new RouteResult();
                double time = 0.0;
                foreach(var edge in shortPath)
                {
                    parts.Add(new SegmentResult
                    {
                        Departure = new Data.DataContracts.City.CityDTO { Name = edge.Source.ToString() },
                        Destination = new Data.DataContracts.City.CityDTO { Name = edge.Target.ToString()},
                        EstimatedDuration = 8
                    });
                    time += WeightByTime(edge);
                }
                route.Segments = parts;
                route.TotalDuration = time;

                result.Add(route);
            }
            return result;
        }
    }
}
