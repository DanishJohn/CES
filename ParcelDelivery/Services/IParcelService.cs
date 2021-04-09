using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.Enums;
using ParcelDelivery.Data.DataContracts.Parcel;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Services
{
	public interface IParcelService 
	{
		 List<ParcelWeight> FindAllParcelWeights();
		List<ParcelSize> FindAllParcelSizes();
		 List<ParcelPrice> FindAllParcelPrices();
		ParcelWeight ParseWeight(int weight);
		ParcelSize ParseSize(float breadth, float height, float depth);
		
	}
}
