using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using webAppTest.Data.Entity.Routes;
using webAppTest.Data.Models.Parcel;

namespace webAppTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<City> City { get; set; }
        public DbSet<Segment> Segment { get; set; }
        public DbSet<SearchedCityHistory> SearchedCityHistory { get; set; }
        public DbSet<ParcelSize> ParcelSize { get; set; }
        public DbSet<ParcelWeight> ParcelWeight { get; set; }
        public DbSet<ParcelPrice> ParcelPrice { get; set; }

    }
}
