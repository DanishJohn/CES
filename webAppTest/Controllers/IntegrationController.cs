using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParcelDelivery.Data.DataContracts.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAppTest.Data;

namespace ParcelDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public IntegrationController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route("Data")]
        public ActionResult GetOutPut([FromQuery]IntegrationInput integrationInput)
        {
            var dataOutput = new IntegrationDTO
            {
                CompanyName = "Oceanic Airline",
                ShippingType = "Sea",
                Route = new RouteIntegrationDTO
                {
                    From = "ADAB",
                    To = "WAAI",
                    IsTwoWay = false,
                    Price = 500,
                    Segments = 4,
                    Time = 32
                }
            };

            return Ok(dataOutput);
        }
    }
}
