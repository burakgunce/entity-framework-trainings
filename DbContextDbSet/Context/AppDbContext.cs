using DbContextDbSet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContextDbSet.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=BookStore;User Id=sa;Password=unequalled88");
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=BookStore;Integrated Security=true"); sifresiz girmek için 

            //base.OnConfiguring(optionsBuilder);
        }
    }
}
