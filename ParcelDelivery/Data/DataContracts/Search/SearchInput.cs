using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.City;
using ParcelDelivery.Data.DataContracts.Parcel;

namespace ParcelDelivery.Data.DataContracts.Search
{
	public class SearchInput
	{
		public SearchInput() { }

		public ParcelInput Parcel { get; set; }

		public CityDTO Departure { get; set; }
		public CityDTO Destination { get; set; }
	}
}
