using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.DataContracts.City;

namespace webAppTest.Data.DataContracts.Segment
{
	public class SegmentDTO
	{

		public String Id { get; set; }
		public CityDTO Departure { get; set; }
		public CityDTO Destination { get; set; }
		public float Duration { get; set; }
	}
}
