using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Models.Parcel;

namespace webAppTest.Data.DataContracts.Parcel
{
	public class ParcelDTO {

		private ParcelDTO() { }

		public String Name { get; set; }
		public ParcelSize Size { get; set;}

		public Dictionary<ParcelWeight, ParcelPrice> SizeByWeight { get; set; }
    
	}	

}
