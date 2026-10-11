using EntityIntro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityIntro.Data
{
    class OkulDbContext:DbContext
    {
        public DbSet<Sinif> Siniflar => Set<Sinif>();
        public DbSet<Ogrenci> Ogrenci => Set<Ogrenci>();

        public DbSet<Ders> Dersler => Set<Ders>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=OkulDb;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }
    }
}
