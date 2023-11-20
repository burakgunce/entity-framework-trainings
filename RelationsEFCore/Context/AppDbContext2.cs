using Microsoft.EntityFrameworkCore;
using RelationsEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsEFCore.Context
{
    public class AppDbContext2 : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=RelationEFCore;User Id=sa;Password=unequalled88");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryRefId);

            modelBuilder.Entity<Product>().HasOne(p => p.ProductDetail).WithOne(p => p.Product)
                .HasForeignKey<ProductDetail>(p => p.ProductrefId);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
