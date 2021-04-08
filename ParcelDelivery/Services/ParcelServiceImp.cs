using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using ParcelDelivery.Data;
using ParcelDelivery.Data.DataContracts.Parcel;

namespace ParcelDelivery.Services.Impl
{
    public class ParcelServiceImp : IParcelService
    {
        ApplicationDbContext _context;

        public ParcelServiceImp(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ParcelTypeDTO> FindAllParcelTypes()
        {
            var parcelPriceList = _context.ParcelPrice.Include(x => x.Size)
                                                       .Include(x => x.Weight).ToList();
            List<ParcelTypeDTO> parcelTypes = new List<ParcelTypeDTO>();
            foreach(var item in parcelPriceList)
            {
                var parcel = new ParcelTypeDTO
                {
                    Name = item.Size.Name,
                    Size = new ParcelSizeDTO(item.Size)
                };
            }
            return parcelTypes;
        }
    }
}
