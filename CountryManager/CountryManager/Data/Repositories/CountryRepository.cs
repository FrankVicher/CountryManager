using CountriesManager.Data;
using CountryManager.Data.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager.Data.Repositories
{
    public class CountryRepository : Repository<Country>
    {
        private readonly CountriesContext db;

        public CountryRepository(CountriesContext db) : base(db)
        {
            this.db = db;
        }
    }
}
