using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ParcelDelivery.Data.DataContracts.City;
using ParcelDelivery.Data.DataContracts.Route;
using ParcelDelivery.Data.DataContracts.Search;
using ParcelDelivery.Data.DataContracts.Segment;
using ParcelDelivery.Data.Entity.Routes;
using ParcelDelivery.Data.Models.Parcel;
using ParcelDelivery.Services;

namespace ParcelDelivery.Pages.Search
{
    public class SearchPageModel : PageModel
    {
        private readonly ICityService _cityService;
        private readonly IParcelCategoryService _parcelCategoryService;
        private readonly IRouteService _routeService;
        private readonly IPriceService _priceService;
        private readonly IParcelService _parcelService;

        public SearchPageModel(ICityService cityService, 
            IParcelCategoryService parcelCategoryService, 
            IRouteService routeService,
            IPriceService priceService,
            IParcelService parcelService)
        {
            _cityService = cityService;
            _parcelCategoryService = parcelCategoryService;
            _routeService = routeService;
            _priceService = priceService;
            _parcelService = parcelService;
        }

        public SelectList cityList { get; set; }
        public SelectList categoryList { get; set; }

        [BindProperty]
        public int departureCityId { get; set; }

        [BindProperty]
        public int destinationCityId { get; set; }

        [BindProperty]
        public int categoryId { get; set; }

        public List<RouteResult> searchResult { get; set; }

        public IActionResult OnGet()
        {
            cityList = new SelectList(_cityService.FindAllCities(), nameof(City.Id), nameof(City.Name), null, null);
            categoryList = new SelectList(_parcelCategoryService.FindAllCategories(), nameof(ParcelCategory.Id), nameof(ParcelCategory.Name), null, null);

            return Page();
        }

        public IActionResult OnPost()
        {
            cityList = new SelectList(_cityService.FindAllCities(), nameof(City.Id), nameof(City.Name), null, null);
            categoryList = new SelectList(_parcelCategoryService.FindAllCategories(), nameof(ParcelCategory.Id), nameof(ParcelCategory.Name), null, null);

            double price = 0.0;
            searchResult = _routeService.SearchRoute(_cityService.GetCity(departureCityId), _cityService.GetCity(destinationCityId), 0);

            return Page();
        }
    }
}
