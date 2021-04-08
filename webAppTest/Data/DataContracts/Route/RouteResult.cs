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
		public Decimal TotalPrice { get; set; }
		public float TotalDuration { get; set;  }
		public CityDTO Departure { get; set; } 
		public CityDTO Destination { get; set; }


	}
}
