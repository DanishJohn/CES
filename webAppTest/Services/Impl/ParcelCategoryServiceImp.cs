using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data;
using webAppTest.Data.Models.Parcel;

namespace webAppTest.Services.Impl
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
