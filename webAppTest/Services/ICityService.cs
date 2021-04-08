using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data.Entity.Routes;

namespace webAppTest.Services
{
    public interface ICityService
    {
        public List<City> FindAllCities();
    }
}
