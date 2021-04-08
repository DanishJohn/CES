using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.Entity.Routes
{
    public class SearchedCityHistory
    {
        private SearchedCityHistory()
        {

        }
        public int Id { get; set; }
        public City City { get; set; }
        public int Count { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
