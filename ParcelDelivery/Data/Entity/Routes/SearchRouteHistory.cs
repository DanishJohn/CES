using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.Entity.Routes
{
    public class SearchRouteHistory
    {
        private SearchRouteHistory() { }

        public int Id { get; set; }
        public City Departure { get; set; }
        public City Destination { get; set; }
        public int Count { get; set; }
        public DateTime createdDate { get; set; }
    }
}
