using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Domain
{
    public interface ICountry
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Alpha3Code { get; set; }
        public string Alpha2Code { get; set; }
        public string NumericCode { get; set; }
        public bool IsIndependent { get; set; }
    }
}
