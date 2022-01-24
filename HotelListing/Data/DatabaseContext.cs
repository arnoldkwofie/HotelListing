using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

       
        public DbSet<Country> Countries { get; set; } 
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Ghana",
                    ShortName = "GH"
                },
                new Country
                {
                    Id = 3,
                    Name = "United State",
                    ShortName = "US"
                }
             );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spur",
                    Address = "Ngril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel De Hilda",
                    Address = "Tarkwa",
                    CountryId = 2,
                    Rating = 1.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Miami Hotel",
                    Address = "Miami",
                    CountryId = 3,
                    Rating = 8.5
                }
             );
        }

    }
}
