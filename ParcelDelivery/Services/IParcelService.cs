using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.Parcel;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Services
{
	public interface IParcelService 
	{
		public List<ParcelWeight> FindAllParcelWeights();
		public List<ParcelSize> FindAllParcelSizes();
		
	}
}
