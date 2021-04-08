using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace ParcelDelivery.Data.DataContracts.Integration
{
    public class IntegrationDTO
    {
        public string CompanyName { get; set; }
        public string ShippingType { get; set; }
        public RouteIntegrationDTO Route { get; set; }
    }
}
