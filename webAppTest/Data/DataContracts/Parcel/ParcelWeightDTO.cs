using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAppTest.Data.DataContracts.Parcel
{
	public class ParcelWeightDTO
	{
		private ParcelWeightDTO()
		{

		}

		public int Id { get; set; }
		public float Weight { get; set; }
	}
}
