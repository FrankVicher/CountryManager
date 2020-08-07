using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Domain
{
    public interface ISubdivision
    {
        string Code { get; set; }
        string Name { get; set; }
        string Category { get; set; }        
    }
}
