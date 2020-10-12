﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using net_migrations.Infrastructure;

namespace net_migrations.Migrations
{
    [DbContext(typeof(ArtistDBContext))]
    partial class ArtistDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("net_migrations.Dominio.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Artistic_name")
                        .HasColumnType("text");

                    b.Property<float>("Average_salary")
                        .HasColumnType("real");

                    b.Property<Guid?>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Ocuppation")
                        .HasColumnType("text");

                    b.Property<string>("Real_name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("net_migrations.Dominio.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Country_name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("net_migrations.Dominio.Artist", b =>
                {
                    b.HasOne("net_migrations.Dominio.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });
#pragma warning restore 612, 618
        }
    }
}
