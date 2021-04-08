using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ParcelDelivery.Data.Entity.Routes;
using ParcelDelivery.Data.Models.Parcel;

namespace ParcelDelivery.Data
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
        public DbSet<ParcelCategory> ParcelCategory { get; set; }
        public DbSet<SearchRouteHistory> SearchRouteHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityRole[] seedRoles = {new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN"},
                                        new IdentityRole {Id = "2", Name = "User", NormalizedName = "USER" } };
            builder.Entity<IdentityRole>().HasData(seedRoles);

            var haser = new PasswordHasher<IdentityRole>();
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = haser.HashPassword(null, "admin"),
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                });
        }
    }
}
