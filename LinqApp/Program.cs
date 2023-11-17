using System.Text;

namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CollectionsLinq();
            //MethodSyntaxLinq();
            IList<Student> studentList = new List<Student>()
            {
                new Student {StudentId = 1, Name="John",  Age=18 },
                new Student {StudentId = 2, Name="asd",  Age=15 },
                new Student {StudentId = 3, Name="zxc",  Age=20 },
                new Student {StudentId = 4, Name="qwe",  Age=25 },
            };

            //query syntax
            var students1 = from s in studentList
                            select s;
            foreach (var student in students1)
            {
                Console.WriteLine($"Id {student.StudentId} Ad {student.Name} Age {student.Age}");
            }

            //method syntax
            var students2 = studentList.ToList();

            //belirli kolonları almak için
            var students3 = from s in studentList
                            select new {s.StudentId, s.Name };
            //belirli kolonları method syntax ile alma
            var students4 = studentList.Select(s => new {s.StudentId,s.Name});

            //ordery by query syntax
            var students5 = from s in studentList
                            orderby s.Name ascending
                            select s;
            //order by method syntax
            var students6 = studentList.OrderBy(s => s.Name).ToList();

            //yas 30 dan buyuk olanları ısme gore sıralama
            //query
            var students7 = from s in studentList
                            orderby s.Name descending
                            where s.Age > 20
                            select s;
            //method
            var students8 = studentList.Where(s=>s.Age > 20).OrderByDescending(s => s.Name).ToList();

        }

        private static void MethodSyntaxLinq()
        {
            List<Personel> personelList = new List<Personel>()
            {
                new Personel {Id = 1, FirstName="John", LastName="Doe", Maas=1000 },
                new Personel {Id = 2, FirstName="asd", LastName="Doe", Maas=12000 },
                new Personel {Id = 3, FirstName="zxc", LastName="Doe", Maas=13000 },
                new Personel {Id = 4, FirstName="qwe", LastName="Doe", Maas=14000 },
            };

            //query syntax
            var personeller = from p in personelList
                              where p.Maas >= 7500 //maası 7500 den buyuk olanları almak ıcın
                              // where p.firstname.contains('o') || p.lastname.contains('o') ad veya soyadında o gecen
                              select p;
            foreach (var personel in personeller)
            {
                Console.WriteLine($"Id {personel.Id} Ad {personel.FirstName} Soyad {personel.LastName} Maas {personel.Maas}");
            }

            //method syntax
            var personeller2 = personelList.Where(x => x.Maas >= 7500).ToList();
            var personeller3 = personelList.Where(x => x.FirstName.Contains('o') || x.LastName.Contains('o')).ToList();
        }

        private static void CollectionsLinq()
        {
            string[] dersler = { "Matematil", "Türkçe", "Beden", "Fizik", "Kimya" };

            var dersList = from ders in dersler select ders;
            StringBuilder str = new StringBuilder();
            foreach (var item in dersList)
            {
                str.Append(item);
            }
            Console.WriteLine(str.ToString());
        }
    }
}