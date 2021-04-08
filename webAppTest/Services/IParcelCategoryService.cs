using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Services
{
	public interface IParcelCategoryService
	{
		public List<ParcelCategory> FindAllCategories();
	}
}
