using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcelDelivery.Data;
using ParcelDelivery.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IPriceService priceService;
        private readonly IParcelService parcelService;
        private readonly ApplicationDbContext context;

        public TestController(IPriceService service, IParcelService parcelService, ApplicationDbContext context)
        {
            this.priceService = service;
            this.parcelService = parcelService;
            this.context = context;
        }

        [Route("GetPrice")]
        [HttpGet]
        public double GetPrice(int weightId, int sizeId)
        {
            var weight = context.ParcelWeight.Find(weightId);
            var size = context.ParcelSize.Find(sizeId);
            return priceService.GetPrice(weight, size);
        }

    }
}
