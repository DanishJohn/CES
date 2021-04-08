using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data.DataContracts.Search
{
	public class CityReportInput
	{
		public DateTime fromDate { get; set; }
		public DateTime toDate { get; set; }

	}
}
