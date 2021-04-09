using ParcelDelivery.Data.Models.Parcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDelivery.Services
{
    public interface IPriceService
    {
        double GetPrice(int weightId, int sizeId);
    }
}
