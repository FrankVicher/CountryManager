
using CountryManager_API.Data.Configurations;
using CountryManager_API.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CountriesManager.Data
{
    public class CountriesContext : DbContext
    {
        public CountriesContext(DbContextOptions<CountriesContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());
            modelBuilder.ApplyConfiguration<Subdivision>(new SubdivisionConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}

