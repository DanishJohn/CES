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
        private IPriceService priceService;
        private IParcelService parcelService;
        private const string otherCategory = "other";

        public IntegrationController(ApplicationDbContext context, 
            ISegmentService segmentService,
            IPriceService priceService,
            IParcelService parcelService)
        {
            this.context = context;
            this.segmentService = segmentService;
            this.priceService = priceService;
            this.parcelService = parcelService;
        }

        [HttpPost]
        [Route("Data")]
        public ActionResult GetOutPut([FromQuery]IntegrationInput integrationInput)
        {
            ICollection<RouteIntegrationDTO> routes = new List<RouteIntegrationDTO>();
            var listSegments = segmentService.FindAllSegments();

            var parcelWeight = parcelService.ParseWeight(integrationInput.Weight);
            var parcelSize = parcelService.ParseSize(integrationInput.Breadth, integrationInput.Height, integrationInput.Height);

            var price = priceService.GetPrice(parcelWeight.Id, parcelSize.Id);

            if(string.IsNullOrEmpty(integrationInput.Category))
            {
                integrationInput.Category = otherCategory;
            }

            var parcelCategory = parcelService.GetCategoryByCode(integrationInput.Category);
            if (parcelCategory == null)
            {
                return NotFound("Category is not supported");
            }
           
            foreach(Segment seg in listSegments)
            {
                routes.Add(new RouteIntegrationDTO
                {
                    From = seg.From.Code,
                    To = seg.To.Code,
                    IsTwoWay = true,
                    Price = (Decimal)(price*(1 + parcelCategory.ExtraCharge/100)),
                    Segments = 1,
                    Time = 8,
                });
            }
            var dataOutput = new IntegrationDTO
            {
                CompanyName = "Oceanic Airline",
                ShippingType = "Air",
                Routes = routes
            };

            return Ok(dataOutput);
        }
    }
}
