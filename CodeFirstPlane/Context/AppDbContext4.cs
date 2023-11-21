using CodeFirstPlane.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstPlane.Context
{
    public class AppDbContext4 : DbContext
    {
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Seat> Seats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=RelationEFCore;User Id=sa;Password=unequalled88");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seat>().HasOne(s => s.Plane).WithMany(s => s.Seats)
                .HasForeignKey(s => s.PlaneRefId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
