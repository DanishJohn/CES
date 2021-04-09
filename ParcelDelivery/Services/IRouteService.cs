using ParcelDelivery.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Entity.Routes;
using QuickGraph;
using ParcelDelivery.Data.DataContracts.Segment;
using ParcelDelivery.Data.DataContracts.Route;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Services
{
    public interface IRouteService
    {
        BidirectionalGraph<string, TaggedEdge<string, string>> BuildGraph(List<Segment> route);
        List<RouteResult> SearchRoute(City source, City end, double price, ParcelCategory category);
    }
}
