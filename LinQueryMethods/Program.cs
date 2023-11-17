namespace LinQueryMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Person> personList = new List<Person>()
            {
                new Person{Id = 1, Name = "John", Age = 18, City = "İstanbul" },
                new Person{Id = 2, Name = "qwe", Age = 15, City = "İstanbul" },
                new Person{Id = 3, Name = "asd", Age = 25, City = "İstanbul" },
                new Person{Id = 4, Name = "zxc", Age = 20, City = "Trabzon" },
                new Person{Id = 5, Name = "rty", Age = 19, City = "İzmir" },
            };
            //SelectLinq(personList);
            //WhereLinq(personList);
            //OrderbyLinq(personList);
            //GroupbyLinq(personList);
            //AgregateLinq(personList);
            //TakeLinq(personList);
            //FirstOrDefaultLinq(personList);
            //LastOrDefaultLinq(personList);
            //SingleOrDefaultLinq(personList);

        }

        private static void SingleOrDefaultLinq(IList<Person> personList)
        {
            //Single ve SingleOrDefault Linq
            // ilgili collection dan tek bır kayıt almak ıcın kullanılır
            var single1 = personList.Single();
            var single2 = personList.Single(p => p.Name == "John");
            var single3 = personList.SingleOrDefault();
            var single4 = personList.SingleOrDefault(p => p.Name == "John");
        }

        private static void LastOrDefaultLinq(IList<Person> personList)
        {
            // Last ve LastorDefault Linq
            var last1 = personList.Last();
            var last2 = personList.Last(p => p.Name == "John");// yoksa hata dondurur
            var last3 = personList.LastOrDefault();
            var last4 = personList.LastOrDefault(p => p.Name == "John");//yoksa hata dondurmez
        }

        private static void FirstOrDefaultLinq(IList<Person> personList)
        {
            //First ve FirstOrDefault Linq
            var first = personList.First();
            var first1 = personList.First(p => p.Name == "John"); // eger listede yoksa hata fırlatır
            var firstd = personList.FirstOrDefault();
            var first2 = personList.FirstOrDefault(p => p.Name == "John"); // eger lıstede yoksa hata fırlatmaz
        }

        private static void TakeLinq(IList<Person> personList)
        {
            //Take linq

            var take = personList.Take(3); // ilk 3 kaydı alır
            var takewhile = personList.TakeWhile(p => p.City == "İstanbul");
        }

        private static void AgregateLinq(IList<Person> personList)
        {
            //Agregate linq

            var avg = personList.Average(x => x.Age);
            var count = personList.Count();
            var max = personList.Max();
            var min = personList.Min();
            var sum = personList.Sum(x => x.Age);
        }

        private static void GroupbyLinq(IList<Person> personList)
        {
            //group by query syntax
            var groupby1 = from p in personList
                           group p by p.Age;

            //group by method syntax
            var groupby2 = personList.GroupBy(p => p.Age);
        }

        private static void OrderbyLinq(IList<Person> personList)
        {
            //orderby query syntax
            var orderby1 = from p in personList
                           orderby p.Name descending
                           select p;
            //orderby method syntax
            var orderby2 = personList.OrderByDescending(p => p.Name);
        }

        private static void WhereLinq(IList<Person> personList)
        {
            //where query syntax
            var where1 = from p in personList
                         where p.Age > 12 && p.Age < 20
                         select p;

            //where method syntax
            var where2 = personList.Where(p => p.Age > 12 && p.Age < 20);
        }

        private static void SelectLinq(IList<Person> personList)
        {
            // select query syntax
            var select1 = from p in personList
                          select p;
            var selectcolumn1 = from p in personList
                                select new { p.Id, p.City };

            //select method syntax
            var select2 = personList.ToList();
            var selectcolumn2 = personList.Select(p => new { p.Name, p.City });
        }
    }
}