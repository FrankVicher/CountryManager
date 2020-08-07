using AutoMapper;
using CountriesManager.Configuration;
using CountriesManager.Data;
using CountryManager_API.Data.Repositories;
using CountryManager_API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CountriesManager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<CountryService>();
            services.AddTransient<CountryRepository>();
            services.AddTransient<SubdivisionService>();
            services.AddTransient<SubdivisionRepository>();

            services.AddAutoMapper(typeof(MapperProfile));
            services.AddDbContext<CountriesContext>(o=>o.UseSqlServer(this.Configuration.GetConnectionString("CountriesManager")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddControllers();
            services.AddCors(c=>
                c.AddPolicy("AllowOrigin", options =>  options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().Build())  
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("AllowOrigin");
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            

        }
    }
}
