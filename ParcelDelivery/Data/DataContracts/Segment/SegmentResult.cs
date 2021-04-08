using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.City;

namespace ParcelDelivery.Data.DataContracts.Segment
{
	public class SegmentResult
	{
		public TransportationCompany TransportationCompany { get; set; }
		public double EstimatedDuration { get; set; }
		public Decimal Price { get; set; }
		public Decimal ExtraFee { get; set; }
		public Decimal TotalPrice { get; set; }
		public CityDTO Departure { get; set; }
		public CityDTO Destination { get; set; }
		public List<SegmentDTO> RouteResult { get; set; }

	}
}
