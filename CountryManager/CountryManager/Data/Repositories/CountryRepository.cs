﻿using CountriesManager.Data;
using CountryManager_API.Data.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Data.Repositories
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
