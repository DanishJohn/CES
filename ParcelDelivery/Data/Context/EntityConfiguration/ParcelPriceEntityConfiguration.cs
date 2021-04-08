using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Data.Context.EntityConfiguration
{
    public class ParcelPriceEntityConfiguration : IEntityTypeConfiguration<ParcelPrice>
    {
        public void Configure(EntityTypeBuilder<ParcelPrice> builder)
        {
            builder.HasOne(x => x.Size);
            builder.HasOne(x => x.Weight);
        }
    }
}
