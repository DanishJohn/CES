using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Entity.Routes;

namespace ParcelDelivery.Services
{
    public interface ICityService
    {
        public List<City> FindAllCities();
        public City GetCity(int id);
    }
}
