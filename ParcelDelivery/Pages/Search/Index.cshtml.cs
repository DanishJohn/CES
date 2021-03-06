using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ParcelDelivery.Data.DataContracts.City;
using ParcelDelivery.Data.DataContracts.Enums;
using ParcelDelivery.Data.DataContracts.Route;
using ParcelDelivery.Data.DataContracts.Search;
using ParcelDelivery.Data.DataContracts.Segment;
using ParcelDelivery.Data.Entity.Routes;
using ParcelDelivery.Data.Models.Parcel;
using ParcelDelivery.Services;
using ParcelDelivery.Shared;

namespace ParcelDelivery.Pages.Search
{
    [Authorize(Roles = "Admin")]
    public class SearchPageModel : PageModel
    {
        private readonly ICityService _cityService;
        private readonly IParcelCategoryService _parcelCategoryService;
        private readonly IRouteService _routeService;
        private readonly IParcelService parcelService;
        private readonly IPriceService priceService;

        public SearchPageModel(ICityService cityService, 
            IParcelCategoryService parcelCategoryService, 
            IRouteService routeService,
            IParcelService parcelService,
            IPriceService priceService)
        {
            _cityService = cityService;
            _parcelCategoryService = parcelCategoryService;
            _routeService = routeService;
            this.parcelService = parcelService;
            this.priceService = priceService;
        }

        public SelectList cityList { get; set; }
        public SelectList categoryList { get; set; }

        public SelectList weightList { get; set; }

        public SelectList heightList { get; set; }

        public SelectList depthList { get; set; }

        public SelectList breadthList { get; set; }

        [BindProperty]
        public int departureCityId { get; set; }

        [BindProperty]
        public int destinationCityId { get; set; }

        [BindProperty]
        public int categoryId { get; set; }

        [BindProperty]
        public int heightId { get; set; }

        [BindProperty]
        public int depthId { get; set; }

        [BindProperty]
        public int breadthId { get; set; }

        [BindProperty]
        public int weightId { get; set; }

        public List<RouteResult> searchResult { get; set; }

        public IActionResult OnGet()
        {
            cityList = new SelectList(_cityService.FindAllCities(), nameof(City.Id), nameof(City.Name), null, null);
            categoryList = new SelectList(_parcelCategoryService.FindAllCategories(), nameof(ParcelCategory.Id), nameof(ParcelCategory.Name), null, null);

            string data = EnumHelper.GetStringValue(SizeEnum.Between25And40);
            var parcelDimensionList = Enum.GetValues(typeof(SizeEnum)).Cast<SizeEnum>()
               .Select(t => new ParcelInformation
               {
                   Id = ((int)t),
                   Name = EnumHelper.GetStringValue(t)
               }); ;

            heightList = new SelectList(parcelDimensionList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null);
            depthList = new SelectList(parcelDimensionList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null); 
            breadthList = new SelectList(parcelDimensionList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null);

            var parcelInformationList = Enum.GetValues(typeof(WeightEnum)).Cast<WeightEnum>()
               .Select(t => new ParcelInformation
               {
                   Id = ((int)t),
                   Name = EnumHelper.GetStringValue(t)
               });

            weightList = new SelectList(parcelInformationList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null);

            return Page();
        }

        public IActionResult OnPost()
        {
            cityList = new SelectList(_cityService.FindAllCities(), nameof(City.Id), nameof(City.Name), null, null);
            categoryList = new SelectList(_parcelCategoryService.FindAllCategories(), nameof(ParcelCategory.Id), nameof(ParcelCategory.Name), null, null);
            var parcelDimensionList = Enum.GetValues(typeof(SizeEnum)).Cast<SizeEnum>()
               .Select(t => new ParcelInformation
               {
                   Id = ((int)t),
                   Name = EnumHelper.GetStringValue(t),
               });

            heightList = new SelectList(parcelDimensionList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null);
            depthList = new SelectList(parcelDimensionList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null);
            breadthList = new SelectList(parcelDimensionList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null);

            var parcelInformationList = Enum.GetValues(typeof(WeightEnum)).Cast<WeightEnum>()
               .Select(t => new ParcelInformation
               {
                   Id = ((int)t),
                   Name = EnumHelper.GetStringValue(t),
               });

            weightList = new SelectList(parcelInformationList, nameof(ParcelInformation.Id), nameof(ParcelInformation.Name), null, null);

            var parcSize = parcelService.ParseSize(breadthId, heightId, depthId);
            var parcWeight = parcelService.ParseWeight(weightId);
            var finalPrice = priceService.GetPrice(parcSize.Id, parcWeight.Id);
            var parcCategory = _parcelCategoryService.findById(categoryId);
            searchResult = _routeService.SearchRoute(_cityService.GetCity(departureCityId), _cityService.GetCity(destinationCityId), finalPrice, parcCategory);

            return Page();
        }
    }

    public class ParcelInformation
    {
        public int Id { get; set; }

        public String Name { get; set; }
    }
}
