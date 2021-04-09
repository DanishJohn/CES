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
using ParcelDelivery.Data.DataContracts.City;
using ParcelDelivery.Data.Models.Parcel;

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

        public List<RouteResult> SearchRoute(City source, City end, double price, ParcelCategory category )
        {
            var citiesByName = context.City.Where(x => x.IsActive).ToList().ToDictionary(x => x.Name);
            var routes = GetAllRoutes();
            var extraCharge = category.ExtraCharge;
            var graph = BuildGraph(routes);
            var result = new List<RouteResult>();

            double WeightByTime(TaggedEdge<string, string> edge)
            {
                return 8;
            }
            IEnumerable<IEnumerable<TaggedEdge<string, string>>> shortestPath = null;

            try
            {
                shortestPath = graph.RankedShortestPathHoffmanPavley(WeightByTime, source.Name, end.Name, 4);
            }
            catch
            {

            }


            foreach (var shortPath in shortestPath)
            {
                var parts = new List<SegmentResult>();
                var route = new RouteResult();
                double time = 0.0;
                double returnPrice = 0.0;
                foreach(var edge in shortPath)
                {
                    parts.Add(new SegmentResult
                    {
                        Departure = new Data.DataContracts.City.CityDTO { Name = edge.Source.ToString() },
                        Destination = new Data.DataContracts.City.CityDTO { Name = edge.Target.ToString()},
                        EstimatedDuration = 8,
                        TransportationCompany = TransportationCompany.OA
                    });
                    time += WeightByTime(edge);
                    returnPrice += price;
                }
                route.Segments = parts;
                route.TotalDuration = time;
                route.TotalPrice = returnPrice*(1+ extraCharge/100);
                route.Departure = new CityDTO { Name = source.Name };
                route.Destination = new CityDTO { Name = end.Name };
                route.GetDistinctTransportationCompany();

                result.Add(route);
            }
            return result;
        }
    }
}
