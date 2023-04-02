using Core.API.Models.Hotels;

namespace Core.API.Models.Country
{
    public class CountryDto: BaseCountryDto
    {
        public int Id { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }
}
