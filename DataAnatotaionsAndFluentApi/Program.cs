using DataAnatotaionsAndFluentApi.Context;
using DataAnatotaionsAndFluentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAnatotaionsAndFluentApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            using (AppDbContext5 context5 = new AppDbContext5())
            {
                context5.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                // data nın degısıp degısmedıgını kontrol etmeyı kapatır

                var authors = context5.Authors.AsNoTracking().ToList();

                var author = new Author
                {
                    FirstName = "qwe", LastName = "asd"
                };

                authors.Add(author);
                context5.SaveChanges();

                foreach (var item in context5.Authors.ToList())
                {
                    Console.WriteLine($"{item.FirstName}  {item.LastName}");
                    //bunu yansıtamadın dataabse e
                }
            }

            /*
             * Entity life cycle : bır entıty ıcın olusturuldugu ekjlendıgı degıstırıldıgı ve sılındıgı vb gıbı ıslemlerı acıklar
             * bu kavram entıty ıcın state kavramı ıle acıklanır
             * 
             * 1-Added : entıty state eklendı olarak ısaretlernı
             * 2-Deleted : entıty sılındı olarak ısaretlenır
             * 3-Modified : entıty de degısıklık yapıldı olarak ısaretlenır
             * 4-Unchanged : entıty de degısıklık olmadı olarak ısaretlenır
             * 5-Detached : entıty ızlenmıyor olarak ısaretlenır
             * 
             */

            using (AppDbContext5 context = new AppDbContext5())
            {
                var author = new Author
                {
                    FirstName = "asd",
                    LastName = "fgh"
                };
                Console.WriteLine(context.Entry(author).State); //detached olarak gelıcek

                var authors = context.Authors.ToList();
                foreach (var item in authors)
                {
                    Console.WriteLine($"{item.FirstName}  {item.LastName}");
                }

                context.Entry(author).State = EntityState.Added;
                Console.WriteLine(context.Entry(author).State);
                context.SaveChanges();

                //unchanged
                var getAuthor = context.Authors.FirstOrDefault(x=> x.FirstName == "asd");
                Console.WriteLine(context.Entry(getAuthor).State); //unchanged gelıcek
                getAuthor.FirstName = "aassdd";
                context.Entry(getAuthor).State = EntityState.Modified; // state degısmı olucak
                context.SaveChanges();

                //deleted
                var getAuthor2 = context.Authors.FirstOrDefault(x => x.FirstName == "aassdd");
                context.Entry(getAuthor2).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}