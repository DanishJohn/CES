using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.Enums;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Data.DataContracts.Parcel
{
	public class ParcelWeightDTO
	{
		public ParcelWeightDTO()
		{

		}

		public ParcelWeightDTO(ParcelWeight parcelWeight)
        {
			Id = parcelWeight.Id;
			Weight = parcelWeight.Weight;
        }

		public int Id { get; set; }
		public WeightEnum Weight { get; set; }
	}
}
