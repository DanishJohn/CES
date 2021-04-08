using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data;
using webAppTest.Data.Entity.Routes;

namespace webAppTest.Services.Impl
{
    public class CityServiceImp : ICityService
    {

        ApplicationDbContext _context;

        public CityServiceImp(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<City> FindAllCities()
        {
            return _context.City.ToList();
        }
    }
}
