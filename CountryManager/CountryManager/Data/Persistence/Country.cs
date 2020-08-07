using CountryManager_API.Domain;
using System;
using System.Collections.Generic;

namespace CountryManager_API.Data.Persistence
{
    public class Country : ICountry
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Alpha3Code { get; set; }
        public string Alpha2Code { get; set; }
        public string NumericCode { get; set; }
        public bool IsIndependent { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsActive { get; set; } = true;

        public IEnumerable<Subdivision> Subdivisions { get; set; }
    }
}
