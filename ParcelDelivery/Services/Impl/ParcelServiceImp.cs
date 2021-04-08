using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using ParcelDelivery.Data;
using ParcelDelivery.Data.DataContracts.Parcel;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Services.Impl
{
    public class ParcelServiceImp : IParcelService
    {
        ApplicationDbContext _context;

        public ParcelServiceImp(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ParcelSize> FindAllParcelSizes()
        {
            return _context.ParcelSize.ToList();
        }

        public List<ParcelWeight> FindAllParcelWeights()
        {
            return _context.ParcelWeight.Where(x => x.IsSupported).ToList();
        }

        public List<ParcelPrice> FindAllParcelPrices()
        {
            return _context.ParcelPrice
                .Include(x => x.Size)
                .Include(x => x.Weight)
                .ToList();
        }
    }
}
