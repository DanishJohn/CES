using ParcelDelivery.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Entity.Routes;
using QuickGraph;
using ParcelDelivery.Data.DataContracts.Segment;
using ParcelDelivery.Data.DataContracts.Route;

namespace ParcelDelivery.Services
{
    public interface IRouteService
    {
        public string Print(Graph graph, City start, City end, string path, Dictionary<City, bool> visited);
        public string PrintAllPaths(Graph graph, City start, City end);
        BidirectionalGraph<string, TaggedEdge<string, string>> BuildGraph(List<Segment> route);
        List<RouteResult> SearchRoute(City source, City end);

    }
}
