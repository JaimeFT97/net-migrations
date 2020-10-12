using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net_migrations.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_migrations.Infrastructure.EntityConfiguration
{
    public class CountryEntityConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> countryConfiguration)
        {
            countryConfiguration.HasKey(p => p.Id);
            countryConfiguration.Property(p => p.Country_name)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
