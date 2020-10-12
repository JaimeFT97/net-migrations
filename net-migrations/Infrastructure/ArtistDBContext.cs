using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using net_migrations.Dominio;
using net_migrations.Infrastructure.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace net_migrations.Infrastructure
{
    public class ArtistDBContext: DbContext
    {
        public ArtistDBContext(DbContextOptions<ArtistDBContext> options
            ): base(options)
        {
        
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected void onModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CountryEntityConfiguration());
            builder.ApplyConfiguration(new ArtistEntityConfiguration());
        }
    }
}
