using Microsoft.Extensions.DependencyInjection;
using ParcelDelivery.Services;
using ParcelDelivery.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Data
{
    public static class ServiceConfigure
    {
        public static IServiceCollection RegisterService(this IServiceCollection servicecollection)
        {
            servicecollection.AddScoped<IAccountService, AccountService>();
            servicecollection.AddScoped<ICityService, CityServiceImp>();
            servicecollection.AddScoped<IParcelCategoryService, ParcelCategoryServiceImp>();
            servicecollection.AddScoped<IRouteService, RouteServiceImp>();
            servicecollection.AddScoped<ISegmentService, SegmentServieImp>();
            servicecollection.AddScoped<IParcelService, ParcelServiceImp>();
            servicecollection.AddScoped<IPriceService, PriceService>();

            return servicecollection;
        }
    }
}
