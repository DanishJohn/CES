using ParcelDelivery.Data;
using ParcelDelivery.Data.Models.Parcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Services.Impl
{
    public class PriceService : IPriceService
    {
        private readonly ApplicationDbContext context;
        private readonly IParcelService parcelService;

        public PriceService(ApplicationDbContext context,
                            IParcelService parcelService)
        {
            this.context = context;
            this.parcelService = parcelService;
        }
        public double GetPrice(ParcelWeight weight, ParcelSize size)
        {
            var sizeList = parcelService.FindAllParcelSizes();
            var priceList = parcelService.FindAllParcelPrices();
            ParcelSize returnSize = null;

            foreach (var parc in sizeList)
            {
                if(size.Breadth <= parc.Breadth && size.Height <= parc.Height && size.Depth <= parc.Depth)
                {
                    returnSize = parc;
                    break;
                }
            }
            if (returnSize is null)
            {
                return 0.0;
            }

            ParcelPrice returnPrice = null;
            foreach (var parc in priceList)
            {
                if (parc.Size == size && parc.Weight.Weight == parc.Weight.Weight)
                {
                    returnPrice = parc;
                    break;
                }
            }

            
            return returnPrice.Price;
        }
    }
}
 