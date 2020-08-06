
using Microsoft.EntityFrameworkCore;

namespace CountriesManager.Data
{
    public class CountriesContext:DbContext
    {
        public CountriesContext(DbContextOptions<CountriesContext> options):base(options)
        {

        }
    }
}
