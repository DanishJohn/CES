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

namespace ParcelDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RoutesController : ControllerBase
    {
        private readonly ISegmentService _segmentService;
        private readonly IRouteService _routeService;
        private readonly ICityService _cityService;

        public RoutesController(ISegmentService segmentService, IRouteService routeService,ICityService cityService)
        {
            _segmentService = segmentService;
            _routeService = routeService;
            _cityService = cityService;
        }

        // GET: api/Routes/Calculate?fromId=xxx&toId=yyy
        [Route("Calculate")]
        [HttpGet]
        public List<SegmentResult> GetResult(int fromId, int toId)
        {
            City city1 = _cityService.GetCity(fromId);
            City city2 = _cityService.GetCity(toId);
            return _routeService.SearchRoute(city1, city2);
        }
    }
}
