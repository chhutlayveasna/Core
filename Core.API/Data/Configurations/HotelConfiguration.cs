using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
