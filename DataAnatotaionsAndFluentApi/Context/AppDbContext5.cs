using DataAnatotaionsAndFluentApi.Models;
using DataAnatotaionsAndFluentApi.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnatotaionsAndFluentApi.Context
{
    public class AppDbContext5 : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=AnnotationAndFluent;User Id=sa;Password=unequalled88");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Models te yapmak yerine fluent api ile context te yapmak için (anno)                                  
        {
            modelBuilder.Entity<Book>().Property(p => p.Title).HasColumnName("BookTitle")
                .HasColumnType("nvarchar(50)").HasColumnOrder(2);

            modelBuilder.Entity<Author>().HasKey(p => p.AuthorKey);

            modelBuilder.Entity<Author>().Property(p => p.AuthorName).HasMaxLength(150);
            modelBuilder.Entity<Author>().Property(p => p.AuthorName).IsRequired();

            //modelBuilder.Entity<Book>().HasForeignKey(p => p.AuthorFk);

            modelBuilder.Entity<Author>().Ignore(p => p.AuthorName);
            modelBuilder.Entity<Book>().ToTable("BookTable");

            //Seed Data // data eklemek ıcın
            modelBuilder.Entity<Author>().HasData(new Author { AuthorKey = 1, FirstName = "John", LastName = "Doe" },
                new Author { AuthorKey = 2, FirstName = "asd", LastName = "fgh" });

            modelBuilder.ApplyConfiguration(new SeedBooks()); //seed boks classında eklenenlerı uygulamak ıcın

            base.OnModelCreating(modelBuilder);
        }
    }
}
