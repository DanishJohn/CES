using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParcelDelivery.Data.DataContracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Data.Context.EntityConfiguration
{
    public class ParcelWeightEntityConfiguration : IEntityTypeConfiguration<ParcelWeight>
    {
        public void Configure(EntityTypeBuilder<ParcelWeight> builder)
        {
            builder.Property(x => x.Weight)
                .HasConversion(new EnumToStringConverter<WeightEnum>())
                .HasMaxLength(32);
        }
    }
}
