using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using webAppTest.Data.Models.Parcel;

namespace webAppTest.Data.DataContracts.Parcel
{
	public class ParcelInput
	{

		public ParcelInput() { }
		public ParcelCategoryDTO ParcelCategory { get; set; }
		public ParcelWeightDTO Weight { get; set; }
		public ParcelSize size { get; set; }
	}
}
