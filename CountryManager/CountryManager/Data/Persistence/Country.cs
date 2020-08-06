using CountryManager.Domain;
using System;

namespace CountryManager.Data.Persistence
{
    public class Country : ICountry
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Alpha3Code { get; set; }
        public string Alpha2Code { get; set; }
        public string NumericCode { get; set; }
        public bool IsIndependent { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
