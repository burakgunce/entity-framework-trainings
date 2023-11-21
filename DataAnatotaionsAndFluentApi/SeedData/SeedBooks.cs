using DataAnatotaionsAndFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnatotaionsAndFluentApi.SeedData
{
    public class SeedBooks : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { BookKey = 1, Title = "suc ve ceza", AuthorFK = 2 },
                new Book { BookKey = 2, Title = "kasagı", AuthorFK = 2 },
                new Book { BookKey = 3, Title = "donkısot", AuthorFK = 2 },
                new Book { BookKey = 4, Title = "olasılıksız", AuthorFK = 2 },
                new Book { BookKey = 5, Title = "kumarbaz", AuthorFK = 2 }
                );
        }
    }
}
