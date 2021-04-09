using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ParcelDelivery.Data.Entity.Routes;
using ParcelDelivery.Data.Models.Parcel;
using ParcelDelivery.Services;

namespace ParcelDelivery.Pages.Search
{
    public class AdminSearchPageModel : PageModel
    {
        private readonly ICityService _cityService;
        private readonly IParcelCategoryService _parcelCategoryService;

        public AdminSearchPageModel(ICityService cityService, IParcelCategoryService parcelCategoryService)
        {
            _cityService = cityService;
            _parcelCategoryService = parcelCategoryService;
        }

        public SelectList cityList { get; set; }
        public SelectList categoryList { get; set; }

        [BindProperty]
        public int departureCityId { get; set; }

        [BindProperty]
        public int destinationCityId { get; set; }

        [BindProperty]
        public int categoryId { get; set; }

        public IActionResult OnGet()
        {
            cityList = new SelectList(_cityService.FindAllCities(), nameof(City.Id), nameof(City.Name), null, null);
            categoryList = new SelectList(_parcelCategoryService.FindAllCategories(), nameof(ParcelCategory.Id), nameof(ParcelCategory.Name), null, null);


            return Page();
        }
    }
}
