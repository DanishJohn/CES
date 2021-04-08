using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Data.DataContracts.Parcel
{
	public class ParcelInput
	{

		public ParcelInput() { }
		public ParcelCategoryDTO ParcelCategory { get; set; }
		public ParcelWeightDTO Weight { get; set; }
		public ParcelSize size { get; set; }
	}
}
