using CountryManager.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager.Models
{
    public class CountryViewModel : ICountry
    {
        public int Id { get; set; }
        [Required]
        public string ShortName { get; set; }
        [Required]
        public string Alpha3Code { get; set; }
        [Required]
        public string Alpha2Code { get; set; }
        [Required]
        public string NumericCode { get; set; }
        [Required]
        public bool IsIndependent { get; set; }

        public List<ISubdivision> Subdivisions { get; set; }

    }
}
