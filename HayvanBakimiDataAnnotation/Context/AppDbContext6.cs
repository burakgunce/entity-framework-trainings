using HayvanBakimiDataAnnotation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanBakimiDataAnnotation.Context
{
    public class AppDbContext6 : DbContext
    {
        public DbSet<Hayvan> Hayvanlar { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        public DbSet<Bakici> Bakicilar { get; set; }
        public DbSet<Sahip> Sahipler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=HayvanDataAnnoDB;User Id=sa;Password=unequalled88");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hayvan>().HasKey(h => h.HayId);

            modelBuilder.Entity<Hayvan>().Property(h=>h.Ad).HasMaxLength(50);
            modelBuilder.Entity<Yiyecek>().Property(y=>y.Ad).HasMaxLength(50);
            modelBuilder.Entity<Bakici>().Property(b=>b.Ad).HasMaxLength(50);
            modelBuilder.Entity<Sahip>().Property(s=>s.Ad).HasMaxLength(50);

            modelBuilder.Entity<Hayvan>().Ignore(h=>h.Yas);

            modelBuilder.Entity<Hayvan>().Property(h => h.Agirlik).HasColumnName("Kilo");

            base.OnModelCreating(modelBuilder);
        }
    }
}
