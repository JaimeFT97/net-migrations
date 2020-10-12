using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using net_migrations.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_migrations.Infrastructure.EntityConfiguration
{
    public class ArtistEntityConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> artistConfiguration)
        {
            artistConfiguration.HasKey(p => p.Id);
            artistConfiguration.Property(p => p.Artistic_name)
                .HasMaxLength(20)
                .IsRequired(true);
            artistConfiguration.Property(p => p.Real_name)
                .HasMaxLength(20)
                .IsRequired(true);
            artistConfiguration.Property<Guid>("Country_id")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("country_id")
                .IsRequired(true);
            artistConfiguration.HasOne(p => p.Country)
                .WithMany()
                .HasForeignKey("Country_id");
            artistConfiguration.Property(p => p.Average_salary)
                .HasMaxLength(20)
                .IsRequired(true);
            artistConfiguration.Property(p => p.Ocuppation)
                .HasMaxLength(20)
                .IsRequired(true);
        }
    }
}
