using CountriesManager.Data;
using CountryManager_API.Data.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Data.Repositories
{
    public class SubdivisionRepository : Repository<Subdivision>
    {
        private readonly CountriesContext db;

        public SubdivisionRepository(CountriesContext db) : base(db)
        {
            this.db = db;
        }

        
    }
}
