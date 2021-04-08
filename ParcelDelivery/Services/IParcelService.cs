using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.DataContracts.Parcel;

namespace ParcelDelivery.Services
{
	public interface IParcelService 
	{
		public List<ParcelTypeDTO> FindAllParcelTypes();
		
	}
}
