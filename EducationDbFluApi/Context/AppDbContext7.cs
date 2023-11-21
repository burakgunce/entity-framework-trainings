using EducationDbFluApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationDbFluApi.Context
{
    public class AppDbContext7 : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=HayvanDataAnnoDB;User Id=sa;Password=qualled888");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lesson>().HasKey(l => l.LesId);

            modelBuilder.Entity<Student>().Property(s=>s.Name).HasMaxLength(50);
            modelBuilder.Entity<School>().Property(sc=>sc.Name).HasMaxLength(50);
            modelBuilder.Entity<Lesson>().Property(l=>l.Name).HasMaxLength(50);
            modelBuilder.Entity<Laptop>().Property(lp=>lp.Brand).HasMaxLength(50);

            //modelBuilder.Entity<Laptop>().HasOne(l => l.Student).WithOne(l => l.Laptop).HasForeignKey<Student>(l => l.StudentId);
            modelBuilder.Entity<Student>().HasOne(s => s.Laptop).WithOne(s => s.Student).HasForeignKey<Student>(s => s.LaptopId);
            //navıgatıon prop larda bunların seylerını yazarsan bu kodları bıle yazmana gerek yok ama student ve laptop ta ıkısınde de 
            //fk olmıcak bırınde ya studentıd fk olcak yada dıgerınde laptopıd fk olucak

            modelBuilder.Entity<Student>().Property(s => s.LaptopId).HasColumnName("LaptopFK");

            
            modelBuilder.Entity<Student>().Ignore(s=> s.Age);

            modelBuilder.Entity<Laptop>().ToTable("Computers");

            modelBuilder.Entity<Student>().Property(s => s.Name).HasColumnName("FullName");

            base.OnModelCreating(modelBuilder);
        }
    }
}
