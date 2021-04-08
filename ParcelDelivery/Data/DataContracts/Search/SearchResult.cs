using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.Route;

namespace ParcelDelivery.Data.DataContracts.Search
{
	public class SearchResult
	{
        public SearchResult(List<RouteResult> routes)
        {
            this.routes = routes;
        }

        public List<RouteResult> routes { get; set; }

	}
}
