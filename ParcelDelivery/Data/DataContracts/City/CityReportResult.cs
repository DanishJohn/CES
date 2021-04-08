using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace ParcelDelivery.Data.DataContracts.City
{
	public class CityReportResult
	{
		public List<CityDTO> Cities { get; set; }
		public Dictionary<CityDTO, float> sortedCitiesWithPercentage { get; set; }

	}
}
