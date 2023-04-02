using AutoMapper;
using Core.API.Data;
using Core.API.Models.Country;

namespace Core.API.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
        }
    }
}
