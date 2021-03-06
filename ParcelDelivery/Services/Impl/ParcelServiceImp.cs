using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using ParcelDelivery.Data;
using ParcelDelivery.Data.DataContracts.Enums;
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

        public ParcelWeight ParseWeight(float weight)
        {
            var weightId = 0;
            if (weight < 1)
            {
                weightId = 1;
            }
            else if (weight <= 5)
            {
                weightId = 2;
            }
            else if (weight <= 20)
            {
                weightId = 3;
            }
            try
            {
                return _context.ParcelWeight.Find(weightId);
            }
            catch
            {
                throw new Exception("Weight type not found");
            }
        }

        public ParcelSize ParseSize(float breadth, float height, float depth)
        {
            var sizeList = this.FindAllParcelSizes();
            ParcelSize returnSize = null;
            foreach (var parc in sizeList)
            {
                if (breadth <= parc.Breadth && height <= parc.Height && depth <= parc.Depth)
                {
                    returnSize = parc;
                    break;
                }
            }
            return returnSize;
        }

        public ParcelCategory GetCategory(int id)
        {
            return _context.ParcelCategory.Find(id);
        }

        public ParcelCategory GetCategoryByCode(string category)
        {
            var output = _context.ParcelCategory.SingleOrDefault(c => c.Code.Equals(category) && c.IsSupported);
            return output ;
        }
    }
}
