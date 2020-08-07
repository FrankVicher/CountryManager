using CountryManager_API.Domain;

namespace CountryManager_API.Models
{
    public class SubdivisionModel : ISubdivision
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
