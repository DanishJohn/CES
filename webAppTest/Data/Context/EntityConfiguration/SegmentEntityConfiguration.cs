using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelDelivery.Data.Entity.Routes;

namespace ParcelDelivery.Data.Context.EntityConfiguration
{
    public class SegmentEntityConfiguration : IEntityTypeConfiguration<Segment>
    {
        public void Configure(EntityTypeBuilder<Segment> builder)
        {
            builder.HasOne(x => x.From);
            builder.HasOne(x => x.To);
        }
    }
}
