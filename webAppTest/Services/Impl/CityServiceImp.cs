﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data;
using ParcelDelivery.Data.Entity.Routes;

namespace ParcelDelivery.Services.Impl
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
