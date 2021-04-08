using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Data.DataContracts.Parcel
{
	public class ParcelTypeDTO
	{

		public ParcelTypeDTO() { }

		public ParcelTypeDTO(ParcelPrice parcelPrice)
		{
			Name = parcelPrice.Size.Name;
			Size = new ParcelSizeDTO(parcelPrice.Size);
			Weight = new ParcelWeightDTO(parcelPrice.Weight);
		}

		public String Name { get; set; }

		public ParcelSizeDTO Size { get; set; }

		public ParcelWeightDTO Weight { get; set; }

	}

}
