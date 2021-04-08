using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ParcelDelivery.Data.Entity.Routes;
using ParcelDelivery.Services;

namespace ParcelDelivery.Pages.Search
{
    public class SearchPageModel : PageModel
    {
        private readonly ICityService _cityService;

        public SearchPageModel(ICityService cityService)
        {
            _cityService = cityService;
        }

        public SelectList cityList { get; set; }

        [BindProperty]
        public int departureCityId { get; set; }

        [BindProperty]
        public int destinationCityId { get; set; }

        public IActionResult OnGet()
        {
            var cities = _cityService.FindAllCities();
            cityList = new SelectList(cities, nameof(City.Id), nameof(City.Name), null, null);


            return Page();
        }
    }
}
