using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.City;
using ParcelDelivery.Data.DataContracts.Segment;

namespace ParcelDelivery.Data.DataContracts.Route
{
	public class RouteResult
	{
		public List<SegmentResult> Segments { get; set; }

		public List<TransportationCompany> TransportationCompanies { get; set; }
		public double TotalPrice { get; set; }
		public double TotalDuration { get; set;  }
		public CityDTO Departure { get; set; } 
		public CityDTO Destination { get; set; }

		public void GetDistinctTransportationCompany()
		{
			TransportationCompanies = Segments.Select(x => x.TransportationCompany).Distinct().ToList();
		}

	}
}
