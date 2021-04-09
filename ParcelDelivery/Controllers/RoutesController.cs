using Microsoft.AspNetCore.Mvc;
using ParcelDelivery.Routing;
using ParcelDelivery.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data;
using ParcelDelivery.Data.Entity.Routes;
using ParcelDelivery.Data.DataContracts.Segment;
using ParcelDelivery.Data.DataContracts.Route;

namespace ParcelDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RoutesController : ControllerBase
    {
        private readonly ISegmentService _segmentService;
        private readonly IRouteService _routeService;
        private readonly ICityService _cityService;
        private readonly IPriceService priceService;
        private readonly ApplicationDbContext context;

        public RoutesController(ISegmentService segmentService, IRouteService routeService,ICityService cityService,
                IPriceService priceService, ApplicationDbContext context)
        {
            _segmentService = segmentService;
            _routeService = routeService;
            _cityService = cityService;
            this.priceService = priceService;
            this.context = context;
        }

        // GET: api/Routes/Calculate?fromId=xxx&toId=yyy
        [Route("Calculate")]
        [HttpGet]
        public List<RouteResult> GetResult(int fromId, int toId, int weightId, int sizeId)
        {
            City city1 = _cityService.GetCity(fromId);
            City city2 = _cityService.GetCity(toId);
            var price = priceService.GetPrice(fromId, sizeId);
            return _routeService.SearchRoute(city1, city2, price);
        }
    }
}
