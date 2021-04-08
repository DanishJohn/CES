using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Models.Parcel;
using ParcelDelivery.Data.Entity.Routes;

namespace ParcelDelivery.Data.Context.EntityConfiguration
{
    public class SearchRouteHistoryConfiguration : IEntityTypeConfiguration<SearchRouteHistory>
    {
        public void Configure(EntityTypeBuilder<SearchRouteHistory> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
