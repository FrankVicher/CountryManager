using AutoMapper;
using CountryManager.Data.Persistence;
using CountryManager.Models;

namespace CountriesManager.Configuration
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Country, CountryViewModel>();
            CreateMap<CountryViewModel,Country>();
        }
    }
}
