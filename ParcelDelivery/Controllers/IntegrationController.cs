using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcelDelivery.Data.DataContracts.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data;
using ParcelDelivery.Services;
using ParcelDelivery.Data.Entity.Routes;

namespace ParcelDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private ISegmentService segmentService;

        public IntegrationController(ApplicationDbContext context, ISegmentService segmentService)
        {
            this.context = context;
            this.segmentService = segmentService;
        }

        [HttpPost]
        [Route("Data")]
        public ActionResult GetOutPut([FromQuery]IntegrationInput integrationInput)
        {
            ICollection<RouteIntegrationDTO> routes = new List<RouteIntegrationDTO>();
            var listSegments = segmentService.FindAllSegments();
            foreach(Segment seg in listSegments)
            {
                routes.Add(new RouteIntegrationDTO
                {
                    From = seg.From.Code,
                    To = seg.To.Code,
                    IsTwoWay = true,
                    Price = 500,
                    Segments = 1,
                    Time = 8
                });
            }
            var dataOutput = new IntegrationDTO
            {
                CompanyName = "Oceanic Airline",
                ShippingType = "Sea",
                Routes = routes
            };

            return Ok(dataOutput);
        }
    }
}
