using CountryManager_API.Data.Persistence;
using CountryManager_API.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Services
{
    public class CountryService:BaseService<CountryRepository,Country>
    {
        private readonly CountryRepository repository;

        public CountryService(CountryRepository repository):base(repository)
        {
            this.repository = repository;
        }

        internal override async Task Create(Country country)
        {
            country.Created = DateTime.Now;
            country.Updated = DateTime.Now;
            await repository.Create(country);
        }

        internal override async Task Update(Country country)
        {
           
            var oldCountry = await GetById(country.Id);
            oldCountry.Updated = DateTime.Now;
            oldCountry.Alpha2Code = country.Alpha2Code;
            oldCountry.Alpha3Code = country.Alpha3Code;
            oldCountry.NumericCode = country.NumericCode;
            oldCountry.ShortName = country.ShortName;
            oldCountry.IsIndependent = country.IsIndependent;
            await repository.Update(oldCountry);            
        }

        internal override async Task Delete(int id)
        {
            var entity = await repository.GetById(id);
            entity.IsActive = false;
            entity.Updated = DateTime.Now;
            await repository.Update(entity);
        }
    }
}

