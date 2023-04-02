using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core.API.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApiUser>
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Cambodia",
                    ShortName = "KH"
                },
                new Country
                {
                    Id = 2,
                    Name = "Thailand",
                    ShortName = "TH"
                },
                new Country
                {
                    Id = 3,
                    Name = "Vietname",
                    ShortName = "VN"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel 
                {
                    Id = 1,
                    Name = "Sokha Hotel",
                    Address = "Phnom Penh, Cambodia",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hyatt Regency",
                    Address = "Bangkok, Cambodia",
                    Rating = 4.4,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Luxury Hotel",
                    Address = "Ho Chi Minh, Cambodia",
                    Rating = 4.5,
                    CountryId = 3
                }
            );
        }
    }
}
