using ManyToManyEfCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyEfCore.Context
{
    public class AppDbContext3 : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7G5LBG3\SQLSERVERBG;Initial Catalog=RelationEFCore;User Id=sa;Password=unequalled88");
        }
        // add-migration AddColumnStudent // kolon eklemeyı unutup sonradan eklemek ıcın
        // remove-migration // son migration u siler // sonuna -force yazarsan db ye yansımıs olsa bile etki eder

    }
}
