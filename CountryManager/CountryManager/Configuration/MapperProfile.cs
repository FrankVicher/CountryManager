using AutoMapper;
using CountryManager_API.Data.Persistence;
using CountryManager_API.Models;

namespace CountriesManager.Configuration
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Country, CountryViewModel>();
            CreateMap<CountryViewModel,Country>();
            CreateMap<Subdivision, SubdivisionModel>();
            CreateMap<SubdivisionModel, Subdivision>();
        }
    }
}
