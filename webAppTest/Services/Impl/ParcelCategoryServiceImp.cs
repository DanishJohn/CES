using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Services.Impl
{
	public class ParcelCategoryServiceImp : IParcelCategoryService
	{

		private ApplicationDbContext _context;

		public ParcelCategoryServiceImp(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<ParcelCategory> FindAllCategories()
		{
			return _context.ParcelCategory.ToList();
		}
	}
}
