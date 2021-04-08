using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.DataContracts.City;
using webAppTest.Data.DataContracts.Segment;

namespace webAppTest.Data.DataContracts.Route
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
