using CountryManager_API.Data.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryManager_API.Data.Configurations
{
    public class SubdivisionConfiguration : IEntityTypeConfiguration<Subdivision>
    {
        public void Configure(EntityTypeBuilder<Subdivision> builder)
        {
            builder.ToTable("Subdivisions");
            builder.HasKey(k => k.Id);
            builder.HasIndex(i => i.Code)
                .IsUnique();
            builder.HasIndex(i => new { i.CountryId, i.Code })
                .IsUnique();
            builder.HasIndex(i => i.Name)
                .IsUnique();
            builder.Property(p => p.Code)
                .HasMaxLength(8)
                .IsRequired();
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            builder.Property(p => p.CountryId)
                .IsRequired();
            builder.Property(p => p.Created)
                .IsRequired();
            builder.Property(p => p.IsActive)
                .IsRequired();
            builder.Property(p => p.Name)
                .HasMaxLength(128)
                .IsRequired();
            builder.Property(p => p.Category)
                .HasMaxLength(64)
                .IsRequired(false);
            builder.Property(p => p.Updated)
                .IsRequired();

            builder.HasOne(o => o.Country)
                .WithMany(m => m.Subdivisions)
                .HasForeignKey(k => k.CountryId);
            builder.HasData(new Subdivision[] {
                new Subdivision{ Id=1, Category="capital",Code="MX-CMX",CountryId=143,Name="Ciudad de México"}
,new Subdivision{ Id=2, Category="state",Code="MX-AGU",CountryId=143,Name="Aguascalientes"}
,new Subdivision{ Id=3, Category="state",Code="MX-BCN",CountryId=143,Name="Baja California"}
,new Subdivision{ Id=4, Category="state",Code="MX-BCS",CountryId=143,Name="Baja California Sur"}
,new Subdivision{ Id=5, Category="state",Code="MX-CAM",CountryId=143,Name="Campeche"}
,new Subdivision{ Id=6, Category="state",Code="MX-COA",CountryId=143,Name="Coahuila de Zaragoza"}
,new Subdivision{ Id=7, Category="state",Code="MX-COL",CountryId=143,Name="Colima"}
,new Subdivision{ Id=8, Category="state",Code="MX-CHP",CountryId=143,Name="Chiapas"}
,new Subdivision{ Id=9, Category="state",Code="MX-CHH",CountryId=143,Name="Chihuahua"}
,new Subdivision{ Id=10, Category="state",Code="MX-DUR",CountryId=143,Name="Durango"}
,new Subdivision{ Id=11, Category="state",Code="MX-GUA",CountryId=143,Name="Guanajuato"}
,new Subdivision{ Id=12, Category="state",Code="MX-GRO",CountryId=143,Name="Guerrero"}
,new Subdivision{ Id=13, Category="state",Code="MX-HID",CountryId=143,Name="Hidalgo"}
,new Subdivision{ Id=14, Category="state",Code="MX-JAL",CountryId=143,Name="Jalisco"}
,new Subdivision{ Id=15, Category="state",Code="MX-MEX",CountryId=143,Name="México"}
,new Subdivision{ Id=16, Category="state",Code="MX-MIC",CountryId=143,Name="Michoacán de Ocampo"}
,new Subdivision{ Id=17, Category="state",Code="MX-MOR",CountryId=143,Name="Morelos"}
,new Subdivision{ Id=18, Category="state",Code="MX-NAY",CountryId=143,Name="Nayarit"}
,new Subdivision{ Id=19, Category="state",Code="MX-NLE",CountryId=143,Name="Nuevo León"}
,new Subdivision{ Id=20, Category="state",Code="MX-OAX",CountryId=143,Name="Oaxaca"}
,new Subdivision{ Id=21, Category="state",Code="MX-PUE",CountryId=143,Name="Puebla"}
,new Subdivision{ Id=22, Category="state",Code="MX-QUE",CountryId=143,Name="Querétaro"}
,new Subdivision{ Id=23, Category="state",Code="MX-ROO",CountryId=143,Name="Quintana Roo"}
,new Subdivision{ Id=24, Category="state",Code="MX-SLP",CountryId=143,Name="San Luis Potosí"}
,new Subdivision{ Id=25, Category="state",Code="MX-SIN",CountryId=143,Name="Sinaloa"}
,new Subdivision{ Id=26, Category="state",Code="MX-SON",CountryId=143,Name="Sonora"}
,new Subdivision{ Id=27, Category="state",Code="MX-TAB",CountryId=143,Name="Tabasco"}
,new Subdivision{ Id=28, Category="state",Code="MX-TAM",CountryId=143,Name="Tamaulipas"}
,new Subdivision{ Id=29, Category="state",Code="MX-TLA",CountryId=143,Name="Tlaxcala"}
,new Subdivision{ Id=30, Category="state",Code="MX-VER",CountryId=143,Name="Veracruz de Ignacio de la Llave"}
,new Subdivision{ Id=31, Category="state",Code="MX-YUC",CountryId=143,Name="Yucatán"}
,new Subdivision{ Id=32, Category="state",Code="MX-ZAC",CountryId=143,Name="Zacatecas"}

            });

        }
    }
}
