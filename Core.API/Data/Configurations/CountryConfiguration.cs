using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
