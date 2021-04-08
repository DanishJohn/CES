using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.DataContracts.City;
using webAppTest.Data.DataContracts.Parcel;

namespace webAppTest.Data.DataContracts.Search
{
	public class SearchInput
	{
		public SearchInput() { }

		public ParcelInput Parcel { get; set; }

		public CityDTO Departure { get; set; }
		public CityDTO Destination { get; set; }
	}
}
