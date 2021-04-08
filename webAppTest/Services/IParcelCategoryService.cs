using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Models.Parcel;

namespace webAppTest.Services
{
	public interface IParcelCategoryService
	{
		public List<ParcelCategory> FindAllCategories();
	}
}
