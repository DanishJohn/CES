using ParcelDelivery.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Entity.Routes;

namespace ParcelDelivery.Services
{
    public interface IRouteService
    {
        public string Print(Graph graph, City start, City end, string path, Dictionary<City, bool> visited);
        public string PrintAllPaths(Graph graph, City start, City end);
    }
}
