using CountryManager_API.Data.Persistence;
using CountryManager_API.Data.Repositories;
using CountryManager_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CountryManager_API.Services
{
    public class SubdivisionService : BaseService<SubdivisionRepository, Subdivision>
    {
        private readonly SubdivisionRepository repository;

        public SubdivisionService(SubdivisionRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        internal override async Task<List<Subdivision>> Seek(Subdivision filter)
        {
            var result = repository.Seek(s => s.Name.Contains(filter.Name))
                .ToList();
            return await Task.FromResult(result);
        }

        internal async Task<List<Subdivision>> GetByCountryId(int countryId)
        {
            var result = repository.Seek(s => s.CountryId == countryId)
                .ToList();
            return await Task.FromResult(result);
        }
    }
}
