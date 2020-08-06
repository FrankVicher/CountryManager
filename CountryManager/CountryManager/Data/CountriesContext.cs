
using CountryManager.Data.Configurations;
using CountryManager.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CountriesManager.Data
{
    public class CountriesContext : DbContext
    {
        public CountriesContext(DbContextOptions<CountriesContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}

