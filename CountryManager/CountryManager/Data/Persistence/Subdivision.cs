using CountryManager_API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Data.Persistence
{
    public class Subdivision : ISubdivision
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
