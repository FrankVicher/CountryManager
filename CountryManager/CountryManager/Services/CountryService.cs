using CountryManager.Data.Persistence;
using CountryManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager.Services
{
    public class CountryService
    {
        private readonly CountryRepository repository;

        public CountryService(CountryRepository repository)
        {
            this.repository = repository;
        }
        internal async Task<List<Country>> GetAll()
        {
            var countries = await repository.GetAll();
            return countries.ToList();
        }

        internal async Task<Country> GetById(int id)
        {
            var country = await repository.GetById(id);
            return country;
        }

        internal async Task Create(Country country)
        {
            country.Created = DateTime.Now;
            country.Updated = DateTime.Now;
            await repository.Create(country);
        }

        internal async Task Update(Country country)
        {
            country.Updated = DateTime.Now;
            await repository.Update(country);            
        }

        internal async Task Delete(int id)
        {
            var entity = await repository.GetById(id);
            entity.IsActive = false;
            entity.Updated = DateTime.Now;
            await repository.Update(entity);
        }
    }
}
