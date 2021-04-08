using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.DataContracts.Integration
{
    public class RouteIntegrationDTO
    {
        public string From { get; set; }
        public string To { get; set; }
        public bool IsTwoWay { get; set; }
        public decimal Price { get; set; }
        public float Time { get; set; }
        public int Segments { get; set; }
    }
}
